using System;
using System.Windows.Forms;
using VendingMachine.UI;

namespace VendingMachine.UILevel
{
    public partial class CtrlSetting : UserControl
    {
        public CtrlSetting()
        {
            InitializeComponent();
        }

        #region Button Events

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowMainPage();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FrmDashboard.machine.ResetMachine();
            FrmDashboard.calc.ResetDeno();
            FrmDashboard.cancelCashPayment = false;
            FrmDashboard.isCardPayment = false;
            FrmDashboard.isCoinInserted = false;
            FrmDashboard.isTransactionDone = true;
            FrmDashboard.isTrasactionSuccess = false;
            FrmDashboard.isSkipCart = true;
        }

        #endregion Button Events
    }
}
