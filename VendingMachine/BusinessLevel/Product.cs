namespace VendingMachine.BusinessLevel
{
    public class Product
    {
        private string itemNo;
        public string name;
        public double price;
        private int quantity;
        private int orderQuantity;
        private bool selected;

        public Product(string productNo, string productName, double productPrice, int productQuantity, int productOrderQuantity, bool productSelected)
        {
            itemNo = productNo;
            name = productName;
            price = productPrice;
            quantity = productQuantity;
            orderQuantity = productOrderQuantity;
            selected = productSelected;
        }

        public string ItemNo
        {
            get { return itemNo; }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int OrderQuantity
        {
            get { return orderQuantity; }
            set { orderQuantity = value; }
        }

        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }
    }
}
