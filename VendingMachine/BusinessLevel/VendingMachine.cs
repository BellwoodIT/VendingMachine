using System;
using System.Collections.Generic;

namespace VendingMachine.BusinessLevel
{
    public class VendingMachineManager
    {
        public const int 
            TOTAL_ITEMS=10,
            INIT_QUANTITY=3;
        public Product[] items = new Product[TOTAL_ITEMS];
        int[] ItemSelected = new int[TOTAL_ITEMS];
        public int totalOrderQuantity = 0;
        public int totalItemSelected = 0;
        //Dictionary that holds all our sales.
        public Dictionary<string, int> sales = new Dictionary<string, int>();

        public VendingMachineManager()
        {
            // Product
            items[0] = new Product("0001", "Coco", 1.60, INIT_QUANTITY,0,false);
            items[1] = new Product("0002", "Soya Bean Milk", 02.00, INIT_QUANTITY, 0, false);
            items[2] = new Product("0003", "Meneral Water", 1.50, INIT_QUANTITY, 0, false);
            items[3] = new Product("0004", "Ice Lemon Tea", 2.00, INIT_QUANTITY, 0, false);
            items[4] = new Product("0005", "Milo", 2.40, INIT_QUANTITY, 0, false);
            items[5] = new Product("0006", "Snickers", 3.60, INIT_QUANTITY, 0, false);
            items[6] = new Product("0007", "Cookies", 3.20, INIT_QUANTITY, 0, false);
            items[7] = new Product("0008", "Bun", 1.80, INIT_QUANTITY, 0, false);
            items[8] = new Product("0009", "Sandwiches", 4.60, INIT_QUANTITY, 0, false);
            items[9] = new Product("0010", "Orange Juice", 4.00, INIT_QUANTITY, 0, false);
        }

        /// <summary>
        /// Verify whether the product ID is valid or not
        /// </summary>
        /// <param name="productID">Item number</param>
        /// <returns>TRUE/FALSE</returns>
        public bool VerifyProductID(string productID, ref string message)
        {
            bool isTrue = false;
            message = "Ok";
            for (int i = 0; i < items.Length; i++)
            {
                if (productID == items[i].ItemNo)
                {
                    // Throw exception since sold out
                    if(items[i].Quantity==0)
                    {
                        message = "Sold Out";
                        isTrue = false;
                        return isTrue;
                    }
                    // Check the sale
                    if(!sales.ContainsKey(items[i].ItemNo))
                    {
                        sales.Add(items[i].ItemNo, i);
                    }
                    // Reduce the quantity from the product
                    items[i].Quantity--;
                    // Increase the order quantity
                    items[i].OrderQuantity++;
                    items[i].Selected = true;
                    totalOrderQuantity++;
                    isTrue = true;
                }
            }

            if(!isTrue)
            {
                message = "Invalid Item No";
            }
            return isTrue;
        }

        public bool CancelProduct(string productID, ref string message)
        {
            bool isSuccess = false;
            message = "Ok";
            try
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (productID == items[i].ItemNo)
                    {                        
                        // Increase the quantity from the product
                        items[i].Quantity++;
                        // Reduce the order quantity
                        Console.WriteLine("Before: "+items[i].ItemNo + "," + items[i].OrderQuantity.ToString() + "," + items[i].Selected.ToString());
                        items[i].OrderQuantity--;
                        if(items[i].OrderQuantity==0)
                        {
                            sales.Remove(items[i].ItemNo);
                            items[i].Selected = false;
                        }
                        Console.WriteLine("After: "+items[i].ItemNo + "," + items[i].OrderQuantity.ToString() + "," + items[i].Selected.ToString());
                        isSuccess = true;
                        totalOrderQuantity--;
                        return isSuccess;
                    }
                }
            }
            catch(Exception ex)
            {
                message = ex.Message;
            }
            return isSuccess;
        }

        public void ClearShoppingCart()
        {            
            try
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (sales.ContainsKey(items[i].ItemNo))
                    {
                        // Reduce the order quantity
                        Console.WriteLine("Before clear cart: " + items[i].ItemNo + "," + items[i].OrderQuantity.ToString() + "," + items[i].Quantity.ToString() + "," + items[i].Selected.ToString());
                        items[i].Quantity+=items[i].OrderQuantity;                        
                            items[i].Selected = false;
                        items[i].OrderQuantity = 0;
                        Console.WriteLine("After clear cart: " + items[i].ItemNo + "," + items[i].OrderQuantity.ToString() + "," + items[i].Quantity.ToString() + "," + items[i].Selected.ToString());
                        
                    }
                }
                sales.Clear();
            }
            catch (Exception)
            {
            }
        }

        public void GetCurItemSelected()
        {
             int counter = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Selected)
                {
                    counter++;
                    Console.WriteLine("Item Selected => "+ items[i].ItemNo + "," + items[i].OrderQuantity.ToString() + "," + items[i].Selected.ToString());
                }
            }
            totalItemSelected = counter;
        }

        // Clear the cart after sale end
        public void EndSale()
        {
            // Clear the counter for sale
            totalOrderQuantity = 0;
            totalItemSelected = 0;
            sales.Clear();
            // Reset the initial status for each item
            for (int i = 0; i < items.Length; i++)
            {
                items[i].OrderQuantity = 0;
                items[i].Selected = false;
            }
        }

        // Reset the machine to the initial state
        public void ResetMachine()
        {
            EndSale();
            // Reset the initial quatity for each item
            for(int i=0;i<items.Length;i++)
            {
                items[i].Quantity = INIT_QUANTITY;
            }
        }
    }
}
