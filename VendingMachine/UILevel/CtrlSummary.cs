using System;
using System.Windows.Forms;
using VendingMachine.BusinessLevel;
using VendingMachine.UI;

namespace VendingMachine.UILevel
{
    public partial class CtrlSummary : UserControl
    {
        public static double totalSales = 0;
        public CtrlSummary()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowCheckoutPage();
        }

        public void CtrlSummary_Load(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        public void RefreshInfo()
        {       
            if(FrmDashboard.inProgress)
            {
                return;
            }
            FrmDashboard.inProgress = true;
            HideControls(false);
            // Reset the counter
            int value = 0;
            double subSales = 0;
            totalSales = 0;

            // Start to calculate the total
            FrmDashboard.isSkipCart = false;

            // Calculate the item selected for the cart

            FrmDashboard.machine.GetCurItemSelected();
            Console.WriteLine("item selected: " + FrmDashboard.machine.totalItemSelected.ToString()+" & total order quantity = "
                +FrmDashboard.machine.totalOrderQuantity.ToString() + " & total sale counter = "
                +FrmDashboard.machine.sales.Count.ToString());
            lblSummary.Text = FrmDashboard.machine.totalOrderQuantity.ToString() + " Items in Cart";

            if (FrmDashboard.machine.totalItemSelected > 0)
            {
                for (int i = value; i < VendingMachineManager.TOTAL_ITEMS; i++)
                {
                    if (FrmDashboard.machine.sales.ContainsValue(i))
                    {
                        Console.WriteLine("value: " + i.ToString());
                        value = i;
                        break;
                    }
                }
                lblItemName1.Text = FrmDashboard.machine.items[value].Name;
                lblItemNo1.Text = FrmDashboard.machine.items[value].ItemNo;
                lblItemQty1.Text = FrmDashboard.machine.items[value].OrderQuantity.ToString();
                subSales= CalculateItemPrice(value);
                totalSales += subSales;
                Console.WriteLine("Total Sales-1: " + subSales.ToString("$0.00"));
                lblItemPrice1.Text = subSales.ToString("0.00");

                lblItemName1.Visible = true;
                lblItemNo1.Visible = true;
                lblItemQty1.Visible = true;
                lblItemPrice1.Visible = true;
            }
            value++;
            if (FrmDashboard.machine.totalItemSelected > 1)
            {
                for (int i = value; i < VendingMachineManager.TOTAL_ITEMS; i++)
                {
                    if (FrmDashboard.machine.sales.ContainsValue(i))
                    {
                        Console.WriteLine("value: " + i.ToString());
                        value = i;
                        break;
                    }
                }
                lblItemName2.Text = FrmDashboard.machine.items[value].Name;
                lblItemNo2.Text = FrmDashboard.machine.items[value].ItemNo;
                lblItemQty2.Text = FrmDashboard.machine.items[value].OrderQuantity.ToString();
                subSales = CalculateItemPrice(value);
                totalSales += subSales;
                Console.WriteLine("Total Sales-2: " + subSales.ToString("$0.00"));
                lblItemPrice2.Text = subSales.ToString("0.00");

                lblItemName2.Visible = true;
                lblItemNo2.Visible = true;
                lblItemQty2.Visible = true;
                lblItemPrice2.Visible = true;
            }
            value++;
            if (FrmDashboard.machine.totalItemSelected > 2)
            {
                for (int i = value; i < VendingMachineManager.TOTAL_ITEMS; i++)
                {
                    if (FrmDashboard.machine.sales.ContainsValue(i))
                    {
                        value = i;
                        break;
                    }
                }
                lblItemName3.Text = FrmDashboard.machine.items[value].Name;
                lblItemNo3.Text = FrmDashboard.machine.items[value].ItemNo;
                lblItemQty3.Text = FrmDashboard.machine.items[value].OrderQuantity.ToString();
                subSales = CalculateItemPrice(value);
                totalSales += subSales;
                Console.WriteLine("Total Sales-3: " + subSales.ToString("$0.00"));
                lblItemPrice3.Text = subSales.ToString("0.00");

                lblItemName3.Visible = true;
                lblItemNo3.Visible = true;
                lblItemQty3.Visible = true;
                lblItemPrice3.Visible = true;
            }
            value++;
            if (FrmDashboard.machine.totalItemSelected > 3)
            {
                for (int i = value; i < VendingMachineManager.TOTAL_ITEMS; i++)
                {
                    if (FrmDashboard.machine.sales.ContainsValue(i))
                    {
                        value = i;
                        break;
                    }
                }
                lblItemName4.Text = FrmDashboard.machine.items[value].Name;
                lblItemNo4.Text = FrmDashboard.machine.items[value].ItemNo;
                lblItemQty4.Text = FrmDashboard.machine.items[value].OrderQuantity.ToString();
                subSales = CalculateItemPrice(value);
                totalSales += subSales;
                Console.WriteLine("Total Sales-4: " + subSales.ToString("$0.00"));
                lblItemPrice4.Text = subSales.ToString("0.00");

                lblItemName4.Visible = true;
                lblItemNo4.Visible = true;
                lblItemQty4.Visible = true;
                lblItemPrice4.Visible = true;
            }
            value++;
            if (FrmDashboard.machine.totalItemSelected > 4)
            {
                for (int i = value; i < VendingMachineManager.TOTAL_ITEMS; i++)
                {
                    if (FrmDashboard.machine.sales.ContainsValue(i))
                    {
                        value = i;
                        break;
                    }
                }
                lblItemName5.Text = FrmDashboard.machine.items[value].Name;
                lblItemNo5.Text = FrmDashboard.machine.items[value].ItemNo;
                lblItemQty5.Text = FrmDashboard.machine.items[value].OrderQuantity.ToString();
                subSales = CalculateItemPrice(value);
                totalSales += subSales;
                Console.WriteLine("Total Sales-5: " + subSales.ToString("$0.00"));
                lblItemPrice5.Text = subSales.ToString("0.00");

                lblItemName5.Visible = true;
                lblItemNo5.Visible = true;
                lblItemQty5.Visible = true;
                lblItemPrice5.Visible = true;
            }
            value++;
            if (FrmDashboard.machine.totalItemSelected > 5)
            {
                for (int i = value; i < VendingMachineManager.TOTAL_ITEMS; i++)
                {
                    if (FrmDashboard.machine.sales.ContainsValue(i))
                    {
                        value = i;
                        break;
                    }
                }
                lblItemName6.Text = FrmDashboard.machine.items[value].Name;
                lblItemNo6.Text = FrmDashboard.machine.items[value].ItemNo;
                lblItemQty6.Text = FrmDashboard.machine.items[value].OrderQuantity.ToString();
                subSales = CalculateItemPrice(value);
                totalSales += subSales;
                Console.WriteLine("Total Sales-6: " + subSales.ToString("$0.00"));
                lblItemPrice6.Text = subSales.ToString("0.00");

                lblItemName6.Visible = true;
                lblItemNo6.Visible = true;
                lblItemQty6.Visible = true;
                lblItemPrice6.Visible = true;
            }
            value++;
            if (FrmDashboard.machine.totalItemSelected > 6)
            {
                for (int i = value; i < VendingMachineManager.TOTAL_ITEMS; i++)
                {
                    if (FrmDashboard.machine.sales.ContainsValue(i))
                    {
                        value = i;
                        break;
                    }
                }
                lblItemName7.Text = FrmDashboard.machine.items[value].Name;
                lblItemNo7.Text = FrmDashboard.machine.items[value].ItemNo;
                lblItemQty7.Text = FrmDashboard.machine.items[value].OrderQuantity.ToString();
                subSales = CalculateItemPrice(value);
                totalSales += subSales;
                Console.WriteLine("Total Sales-7: " + subSales.ToString("$0.00"));
                lblItemPrice7.Text = subSales.ToString("0.00");

                lblItemName7.Visible = true;
                lblItemNo7.Visible = true;
                lblItemQty7.Visible = true;
                lblItemPrice7.Visible = true;
            }
            value++;
            if (FrmDashboard.machine.totalItemSelected > 7)
            {
                for (int i = value; i < VendingMachineManager.TOTAL_ITEMS; i++)
                {
                    if (FrmDashboard.machine.sales.ContainsValue(i))
                    {
                        value = i;
                        break;
                    }
                }
                lblItemName8.Text = FrmDashboard.machine.items[value].Name;
                lblItemNo8.Text = FrmDashboard.machine.items[value].ItemNo;
                lblItemQty8.Text = FrmDashboard.machine.items[value].OrderQuantity.ToString();
                subSales = CalculateItemPrice(value);
                totalSales += subSales;
                Console.WriteLine("Total Sales-8: " + subSales.ToString("$0.00"));
                lblItemPrice8.Text = subSales.ToString("0.00");

                lblItemName8.Visible = true;
                lblItemNo8.Visible = true;
                lblItemQty8.Visible = true;
                lblItemPrice8.Visible = true;
            }
            value++;
            if (FrmDashboard.machine.totalItemSelected > 8)
            {
                for (int i = value; i < VendingMachineManager.TOTAL_ITEMS; i++)
                {
                    if (FrmDashboard.machine.sales.ContainsValue(i))
                    {
                        value = i;
                        break;
                    }
                }
                lblItemName9.Text = FrmDashboard.machine.items[value].Name;
                lblItemNo9.Text = FrmDashboard.machine.items[value].ItemNo;
                lblItemQty9.Text = FrmDashboard.machine.items[value].OrderQuantity.ToString();
                subSales = CalculateItemPrice(value);
                totalSales += subSales;
                Console.WriteLine("Total Sales-9: " + subSales.ToString("$0.00"));
                lblItemPrice9.Text = subSales.ToString("0.00");

                lblItemName9.Visible = true;
                lblItemNo9.Visible = true;
                lblItemQty9.Visible = true;
                lblItemPrice9.Visible = true;
            }
            value++;
            if (FrmDashboard.machine.totalItemSelected > 9)
            {
                for (int i = value; i < VendingMachineManager.TOTAL_ITEMS; i++)
                {
                    if (FrmDashboard.machine.sales.ContainsValue(i))
                    {
                        value = i;
                        break;
                    }
                }
                lblItemName10.Text = FrmDashboard.machine.items[value].Name;
                lblItemNo10.Text = FrmDashboard.machine.items[value].ItemNo;
                lblItemQty10.Text = FrmDashboard.machine.items[value].OrderQuantity.ToString();
                subSales = CalculateItemPrice(value);
                totalSales += subSales;
                Console.WriteLine("Total Sales-10: " + subSales.ToString("$0.00"));
                lblItemPrice10.Text = subSales.ToString("0.00");

                lblItemName10.Visible = true;
                lblItemNo10.Visible = true;
                lblItemQty10.Visible = true;
                lblItemPrice10.Visible = true;
            }
            Console.WriteLine("Total Sales: " + totalSales.ToString("$0.00"));
            lblTotalAmtValue.Text = "$" + totalSales.ToString("0.00");
            FrmDashboard.inProgress = false;
        }

        private double CalculateItemPrice(int itemIndex)
        {
            double total= FrmDashboard.machine.items[itemIndex].Price * FrmDashboard.machine.items[itemIndex].OrderQuantity;
            return total;
        }

        private void HideControls(bool enable)
        {
            foreach (Control lbl in pnlSummary.Controls)
            {
                if (lbl is Label)
                {
                    lbl.Visible = enable;               
                } // end if(lbl is Label)
            } // end foreach loop
        }
    }
}
