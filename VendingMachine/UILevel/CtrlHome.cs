using System;
using System.Windows.Forms;
using VendingMachine.UI;

namespace VendingMachine.UILevel
{
    public partial class CtrlHome : UserControl
    {
        private const int MAX_LENGTH = 4;
        string retMessage = "";
        public CtrlHome()
        {
            InitializeComponent();
        }
        
        #region Keypad Handler Events

        private void keypadCart_NumberClicked(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Visible = false;
                string labelName = ((Control)sender).Name.Remove(0, 3);
                switch (labelName)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        if (keypadCart.Num.Length < MAX_LENGTH)
                        {
                            keypadCart.Num += labelName;
                        }
                        break;
                    case "Backspace":
                    case "Clear":
                        keypadCart.Num = keypadCart.Num.Remove(keypadCart.Num.Length - 1);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
            }
        }
        
        private void keypadCart_OkClicked()
        {
            string itemID = keypadCart.Num;
            string retMessage="";
            lblStatus.Visible = false;
            if (FrmDashboard.machine.VerifyProductID(itemID, ref retMessage))
            {
                lstCart.Items.Add(itemID);

            }
            else
            {
                lblStatus.Text = retMessage;
                lblStatus.Visible = true;
            }
            FrmDashboard.isSkipCart = true;
            FrmDashboard.isTransactionDone = false;
            keypadCart.Num = "";
        }

        #endregion Keypad Handler Events

        #region Button Handler Events

        private void btnGoToCart_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowSummaryPage();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedItem != null)
            {
                if (FrmDashboard.machine.CancelProduct(lstCart.SelectedItem.ToString(), ref retMessage))
                {
                    lstCart.Items.RemoveAt(lstCart.SelectedIndex);
                    FrmDashboard.isSkipCart = true;
                }
            }
        }

        #endregion Button Handler Events

        public void RefreshInfo()
        {
            if(FrmDashboard.isTransactionDone)
            {
                lstCart.Items.Clear();
                CtrlSummary.totalSales = 0;
                CtrlCheckout.paymentReceived = 0;
                CtrlCashPayment.amtAccepted = 0;
                FrmDashboard.cancelCashPayment = false;
                FrmDashboard.isCoinInserted = false;
                FrmDashboard.machine.EndSale();
                FrmDashboard.calc.EndCalculation();
            }
        }

        public void CtrlHome_Load(object sender, EventArgs e)
        {
            RefreshInfo();
        }
    }
}
