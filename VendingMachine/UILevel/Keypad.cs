using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace VendingMachine.UILevel
{
    public partial class Keypad : UserControl
    {
        public Keypad()
        {
            InitializeComponent();
        }

        // Declare delegate for OK button clicked.
        // 
        // Most action events (like the Click event) in Windows Forms 
        // use the EventHandler delegate and the EventArgs arguments. 
        // We will define our own delegate that does not specify parameters.
        // Mostly, we really don't care what the conditions of the
        // click event for the OK button were, we just care that
        // the OK button was clicked.
        public delegate void CancelClickedHandler();
        public delegate void OkClickedHandler();
        public delegate void NumberClickedHandler(object sender, EventArgs e);

        // Declare the event, which is associated with our
        // delegate OkClickedHandler(). Add some attributes
        // for the Visual C# control property.
        [Category("Action")]
        [Description("Occurs when the Cancel button is clicked.")]
        public event CancelClickedHandler CancelClicked;
        [Category("Action")]
        [Description("Occurs when the Ok button is clicked.")]
        public event OkClickedHandler OkClicked;
        [Category("Action")]
        [Description("Occurs when the others button is clicked.")]
        public event NumberClickedHandler NumberClicked;

        // Add a protected method called OnSubmitClicked(). 
        // You may use this in child classes instead of adding
        // event handlers.
        protected virtual void OnCancelClicked()
        {
            // If an event has no subscribers registerd, it will 
            // evaluate to null. The test checks that the value is not
            // null, ensuring that there are subsribers before
            // calling the event itself.
            if (CancelClicked != null)
            {
                CancelClicked();  // Notify Subscribers
            }
        }

        protected virtual void OnOkClicked()
        {
            // If an event has no subscribers registerd, it will 
            // evaluate to null. The test checks that the value is not
            // null, ensuring that there are subsribers before
            // calling the event itself.
            if (OkClicked != null)
            {
                OkClicked();  // Notify Subscribers
            }
        }

        protected virtual void OnNumberClicked(object sender, EventArgs e)
        {
            // If an event has no subscribers registerd, it will 
            // evaluate to null. The test checks that the value is not
            // null, ensuring that there are subsribers before
            // calling the event itself.
            if (NumberClicked != null)
            {
                NumberClicked(sender, e);  // Notify Subscribers
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            OnOkClicked();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            OnNumberClicked(sender, e);
        }

        // Read / Write Property for the Keypad. This Property
        // will be visible in the containing application.
        [Category("Appearance")]
        [Description("Gets or sets the number in the label")]
        public string Num
        {
            get { return lblNumber.Text; }
            set { lblNumber.Text = value; }
        }

        [Category("Appearance")]
        [Description("Gets or sets the name for the Ok button")]
        public string OkButtonName
        {
            get { return btnOk.Text; }
            set { btnOk.Text = value; }
        }
    }
}
