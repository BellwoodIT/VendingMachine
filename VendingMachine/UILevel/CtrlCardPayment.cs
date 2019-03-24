using System;
using System.Threading;
using System.Windows.Forms;

namespace VendingMachine.UILevel
{
    public partial class CtrlCardPayment : UserControl
    {
        public const int MAX_LENGTH = 16;
        public bool isSuccess=true;
        FrmShadow frmShadow = new FrmShadow();

        public CtrlCardPayment()
        {
            InitializeComponent();
        }

        public void CtrlCardPayment_Load(object sender, EventArgs e)
        {
            picLoading.Visible = false;
            keypadCard.Num = "";
        }

        #region Keypad events

        private void keypadCard_NumberClicked(object sender, EventArgs e)
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
                        if (keypadCard.Num.Length < MAX_LENGTH)
                        {
                            keypadCard.Num += labelName;
                        }
                        break;
                    case "Backspace":
                    case "Clear":
                        keypadCard.Num = keypadCard.Num.Remove(keypadCard.Num.Length - 1);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
            }
        }

        private void keypadCard_OkClicked()
        {
            lblStatus.Visible = false;
            if(keypadCard.Num.Length<MAX_LENGTH)
            {
                lblStatus.Text = "Invalid Length";
                lblStatus.Visible = true;
                keypadCard.Num = "";
                return;
            }
            
            Thread.Sleep(1000);
            Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Processing...";
                lblStatus.Visible = true;
                picLoading.BringToFront();
                picLoading.Visible = true;
            });
            frmShadow.ShowShadow(Program.MainForm);
            
            Thread.Sleep(5000);
            frmShadow.Hide();
            lblStatus.Visible = false;
            picLoading.Visible = false;
            // Proceed to complete payment
            Program.MainForm.ShowControl(UI.FrmDashboard.ControlsEnum.THANKS);
        }

        #endregion Keypad events

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowControl(UI.FrmDashboard.ControlsEnum.CHECKOUT);
        }

        
    }
}
