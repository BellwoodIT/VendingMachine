using System;
using System.Windows.Forms;
using VendingMachine.UI;

namespace VendingMachine.UILevel
{
    public partial class CtrlCheckout : UserControl
    {
        public static double paymentReceived = 0;
        public CtrlCheckout()
        {
            InitializeComponent();
        }

        public void CtrlCheckout_Load(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        public void RefreshInfo()
        {
            radCash.Checked = true;
            lblTransactionAmtValue.Visible = false;
            lblTransactionFee.Visible = false;
            paymentReceived = 0;
            lblTotalAmtValue.Text = "$" + CtrlSummary.totalSales.ToString("0.00");
            btnProceed.Enabled = CtrlSummary.totalSales == 0 ? false : true;
        }

        private void radCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if(radCreditCard.Checked)
            {
                double tax = CtrlSummary.totalSales * 0.05;
                lblTransactionAmtValue.Text = "$"+tax.ToString("0.00");
                paymentReceived = CtrlSummary.totalSales + tax;
                lblTotalAmtValue.Text = "$"+paymentReceived.ToString("0.00");

                FrmDashboard.isCardPayment = true;   
            }
            else
            {
                paymentReceived = CtrlSummary.totalSales;
                lblTotalAmtValue.Text = "$" + CtrlSummary.totalSales.ToString("0.00");
                FrmDashboard.isCardPayment = false;
            }
            lblTransactionFee.Visible = radCreditCard.Checked;
            lblTransactionAmtValue.Visible = radCreditCard.Checked;
        }
        
        private void btnProceed_Click(object sender, EventArgs e)
        {
            if(FrmDashboard.isCardPayment)
            {
                Program.MainForm.ShowControl(FrmDashboard.ControlsEnum.CARD_PAYMENT);
            }
            else
            {
                Program.MainForm.ShowControl(FrmDashboard.ControlsEnum.CASH_PAYMENT);
            }
        }
    }
}
