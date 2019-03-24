using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VendingMachine.UI;

namespace VendingMachine.UILevel
{
    public partial class CtrlThanks : UserControl
    {
        public CtrlThanks()
        {
            InitializeComponent();
        }

        public void CtrlThanks_Load(object sender, EventArgs e)
        {
            string tipsMsg = "";
            FrmDashboard.isTransactionDone = true;
            lblInstruction.Visible = false;
            lblRefNo.Visible = false;
            lblTips.Visible = false;
            if (FrmDashboard.isCardPayment)
            {
                // Credit card payment
                if(FrmDashboard.isTrasactionSuccess)
                {
                    // Complete payment
                    lblThanks.Text = "Thank you for the payment of $" + CtrlCheckout.paymentReceived.ToString("0.00");
                    lblInstruction.Text = "Your product has been despensed";
                    lblInstruction.Visible = true;

                    Random r = new Random();
                    string x = r.Next(10000).ToString("0000")+ r.Next(10000).ToString("0000")
                        + r.Next(10000).ToString("0000")+ r.Next(10000).ToString("0000");
                    lblRefNo.Text = "Ref No: " + x;
                    lblRefNo.Visible = true;
                }
                else
                {
                    // Failure payment
                    lblThanks.Text = "Something wrong for the payment of $" + CtrlCheckout.paymentReceived.ToString("0.00");
                    lblInstruction.Text = "Please try again later";
                    lblInstruction.Visible = true;
                }
                FrmDashboard.isTrasactionSuccess = !FrmDashboard.isTrasactionSuccess;
            }
            else
            {
                // Cash payment
                if(FrmDashboard.cancelCashPayment)
                {
                    // No payment
                    lblThanks.Text = "Thank you";
                }
                else
                {
                    // Complete payment
                    lblThanks.Text = "Thank you for the payment of $" + CtrlSummary.totalSales.ToString("0.00");
                    lblInstruction.Text = "Your product has been despensed";
                    lblInstruction.Visible = true;
                }
            }

            if(FrmDashboard.isCoinInserted && !FrmDashboard.isCardPayment && !FrmDashboard.cancelCashPayment)
            {
                if (FrmDashboard.calc.changes.Count > 0)
                {
                    for (int i = 0; i < FrmDashboard.calc.acceptedCoin.Length; i++)
                    {
                        if (FrmDashboard.calc.changes.ContainsKey(FrmDashboard.calc.acceptedCoin[i].Value))
                        {
                            tipsMsg += "$" + FrmDashboard.calc.acceptedCoin[i].Value.ToString("0.00 ") + " X " + 
                                FrmDashboard.calc.changes[FrmDashboard.calc.acceptedCoin[i].Value].ToString() + "\n\r";
                        }
                    }
                    lblTips.Visible = true;
                    lblTips.Text = "Your coins has been despensed\n\r" + tipsMsg;
                }
            }
            else if(FrmDashboard.isCoinInserted)
            {
                for (int i = 0; i < FrmDashboard.calc.acceptedCoin.Length; i++)
                {
                    if (FrmDashboard.calc.acceptedCoin[i].Accepted)
                    {
                        tipsMsg += "$" + FrmDashboard.calc.acceptedCoin[i].Value.ToString("0.00 ") + " X " + FrmDashboard.calc.acceptedCoin[i].AcceptedQuantity.ToString()+"\n\r";
                        FrmDashboard.calc.acceptedCoin[i].Accepted = false;
                        FrmDashboard.calc.acceptedCoin[i].AcceptedQuantity = 0;
                    }
                }
                lblTips.Visible = true;
                lblTips.Text = "Your coins has been despensed\n\r"+ tipsMsg;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowMainPage();
        }
    }
}
