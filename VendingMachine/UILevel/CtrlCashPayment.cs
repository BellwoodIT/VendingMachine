using System;
using System.Windows.Forms;
using VendingMachine.UI;

namespace VendingMachine.UILevel
{
    public partial class CtrlCashPayment : UserControl
    {
        public static double amtAccepted = 0;
        double amtAddOn = 0;

        public CtrlCashPayment()
        {
            InitializeComponent();
        }

        public void CtrlCashPayment_Load(object sender, EventArgs e)
        {
            lblTotalAmtValue.Text = amtAccepted == 0 ?
                CtrlSummary.totalSales.ToString("$0.00") :
                amtAddOn.ToString("$0.00");
            if (amtAccepted == 0)
            {
                lstCash.Items.Clear();
            }
            lblStatus.Visible = false;
            btnProceed.Enabled = amtAccepted >= CtrlSummary.totalSales ? true : false;
        }

        #region Button Events

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowControl(UI.FrmDashboard.ControlsEnum.CHECKOUT);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmDashboard.cancelCashPayment = true;
            // Cancel item
            FrmDashboard.machine.ClearShoppingCart();
            Program.MainForm.ShowControl(UI.FrmDashboard.ControlsEnum.THANKS);
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowControl(UI.FrmDashboard.ControlsEnum.THANKS);
        }

        private void btnDeno_Click(object sender, EventArgs e)
        {
            bool isChangeAvailable = true;
            try
            {
                int indextSelected = -1;
                lblStatus.Visible = false;
                string btnName = ((Control)sender).Name.Remove(0, 3);
                switch (btnName)
                {
                    case "500":
                        indextSelected = 0;
                        break;
                    case "100":
                        indextSelected = 1;
                        break;
                    case "25":
                        indextSelected = 2;
                        break;
                    case "10":
                        indextSelected = 3;
                        break;
                    case "5":
                        indextSelected = 4;
                        break;
                    default:
                        break;
                }
                // Update the accepted coin
                FrmDashboard.isCoinInserted = true;
                FrmDashboard.calc.acceptedCoin[indextSelected].Accepted = true;
                FrmDashboard.calc.acceptedCoin[indextSelected].AcceptedQuantity++;
                amtAccepted += FrmDashboard.calc.acceptedCoin[indextSelected].Value;
                Console.WriteLine("Amount Accetped: $" + amtAccepted.ToString("0.00"));
                amtAddOn = CtrlSummary.totalSales - amtAccepted;
                lblTotalAmtValue.Text = "$" + amtAddOn.ToString("0.00");
                Console.WriteLine("Pending: $" + amtAddOn.ToString("0.00"));
                if (amtAccepted >= CtrlSummary.totalSales)
                {
                    btnProceed.Enabled = true;
                }

                // Update the change
                if (amtAccepted > CtrlSummary.totalSales)
                {
                    isChangeAvailable=FrmDashboard.calc.CalculateChange(CtrlSummary.totalSales);
                    for (int i = 0; i < FrmDashboard.calc.acceptedCoin.Length; i++)
                    {
                        if (FrmDashboard.calc.changes.ContainsKey(FrmDashboard.calc.acceptedCoin[i].Value))
                        {
                            int changeQty = FrmDashboard.calc.changes[FrmDashboard.calc.acceptedCoin[i].Value];
                            //FrmDashboard.calc.acceptedCoin[i].Quantity -= changeQty;
                            lstCash.Items.Add(FrmDashboard.calc.acceptedCoin[i].Value.ToString("0.00") + "X" + changeQty.ToString());
                        }

                    }
                }
                if (!isChangeAvailable)
                {
                    lblStatus.Text = "No change available";
                    lblStatus.Visible = true;
                }

                btnProceed.Enabled = isChangeAvailable;
            }
            catch (Exception)
            {
            }
        }

        #endregion Button Events
    }
}
