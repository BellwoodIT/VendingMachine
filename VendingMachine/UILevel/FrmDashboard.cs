using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VendingMachine.BusinessLevel;
using VendingMachine.UILevel;

namespace VendingMachine.UI
{
    public partial class FrmDashboard : Form
    {
        public static VendingMachineManager machine = new VendingMachineManager();
        public static Calculation calc = new Calculation();
        public CtrlHome homeCtrl = new CtrlHome();
        public CtrlSummary summaryCtrl = new CtrlSummary();
        public CtrlCheckout checkoutCtrl = new CtrlCheckout();
        public CtrlCardPayment cardCtrl = new CtrlCardPayment();
        public CtrlCashPayment cashCtrl = new CtrlCashPayment();
        public CtrlThanks thanksCtrl = new CtrlThanks();
        public CtrlSetting settingCtrl = new CtrlSetting();

        //Dictionary that holds all our instantiated user controls.
        private IDictionary<ControlsEnum, Control> controls = new Dictionary<ControlsEnum, Control>();
        public static bool
            cancelCashPayment = false,
            inProgress = false,
            isCardPayment = false,
            isCoinInserted = false,
            isTransactionDone = false,
            isTrasactionSuccess = false,
            isSkipCart = true;
        public enum ControlsEnum
        {         
            CARD_PAYMENT,
            CASH_PAYMENT,
            CHECKOUT,
            HOME,
            SETTING,
            SUMMARY,
            THANKS
        }
        public FrmDashboard()
        {
            InitializeComponent();
            ShowControl(ControlsEnum.HOME);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Get the button name
            string buttonName = ((Control)sender).Name.Remove(0, 3);
            switch (buttonName)
            {
                case "Home":
                    ShowMainPage();
                    break;

                case "Summary":
                    ShowSummaryPage();
                    break;

                case "Checkout":
                    ShowCheckoutPage();
                    break;

                case "Setting":
                    ShowControl(ControlsEnum.SETTING);
                    break;
                default:
                    break;
            }

            // Set the panel position
            pnlSide.Height = ((Control)sender).Height;
            pnlSide.Top = ((Control)sender).Top;
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Public Methods

        public void ShowMainPage()
        {
            // Set the panel position
            pnlSide.Height = btnHome.Height;
            pnlSide.Top = btnHome.Top;
            ShowControl(ControlsEnum.HOME);
        }

        public void ShowSummaryPage()
        {
            // Set the panel position
            pnlSide.Height = btnSummary.Height;
            pnlSide.Top = btnSummary.Top;
            ShowControl(ControlsEnum.SUMMARY);
        }

        public void ShowCheckoutPage()
        {
            // Set the panel position
            pnlSide.Height = btnCheckout.Height;
            pnlSide.Top = btnCheckout.Top;
            // Check the total sales from Home page
            if(isSkipCart)
            {
                summaryCtrl.RefreshInfo();
            }
            ShowControl(ControlsEnum.CHECKOUT);
        }

        #endregion Public MEthods

        #region User control events

        public void ShowControl(ControlsEnum ctrl)
        {
            Control new_ctrl = null;

            //If our dictionary already contains instance of
            if (controls.ContainsKey(ctrl))
            {
                new_ctrl = controls[ctrl];
                ControlOnLoad(ctrl);
            }
            else
            {
                new_ctrl = CreateControl(ctrl);
                controls[ctrl] = new_ctrl;
            }

            new_ctrl.Parent = pnlMain;
            new_ctrl.Dock = DockStyle.Fill;
            new_ctrl.BringToFront();
            new_ctrl.Show();
        }

        /// <summary>
        /// Create a new instance for the user control
        /// </summary>
        private Control CreateControl(ControlsEnum ctrl)
        {
            switch (ctrl)
            {
                case ControlsEnum.HOME:
                    return homeCtrl.Controls.Owner;
                case ControlsEnum.CHECKOUT:
                    return checkoutCtrl.Controls.Owner;
                case ControlsEnum.SUMMARY:
                    return summaryCtrl.Controls.Owner;
                case ControlsEnum.CARD_PAYMENT:
                    return cardCtrl.Controls.Owner;
                case ControlsEnum.CASH_PAYMENT:
                    return cashCtrl.Controls.Owner;
                case ControlsEnum.SETTING:
                    return settingCtrl.Controls.Owner;
                case ControlsEnum.THANKS:
                    return thanksCtrl.Controls.Owner;
                default:
                    return null;
            }
        }
        
        /// <summary>
        /// Call the Loading event for the usercontrol
        /// </summary>
        private void ControlOnLoad(ControlsEnum ctrl)
        {
            switch (ctrl)
            {
                case ControlsEnum.HOME:
                    homeCtrl.CtrlHome_Load(null, null);
                    return;
                case ControlsEnum.CHECKOUT:
                    checkoutCtrl.CtrlCheckout_Load(null, null);
                    return;
                case ControlsEnum.SUMMARY:
                    summaryCtrl.CtrlSummary_Load(null, null);
                    return;
                case ControlsEnum.CARD_PAYMENT:
                    cardCtrl.CtrlCardPayment_Load(null, null);
                    return;
                case ControlsEnum.CASH_PAYMENT:
                    cashCtrl.CtrlCashPayment_Load(null, null);
                    return;
                case ControlsEnum.THANKS:
                    thanksCtrl.CtrlThanks_Load(null, null);
                    return;
                default:
                    return;
            }
        }

        #endregion User control events
        
    }
}
