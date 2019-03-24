using System.Drawing;
using System.Windows.Forms;

namespace VendingMachine.UILevel
{
	/// <summary>
	/// Description of ShadowForm.
	/// </summary>
	public partial class FrmShadow : Form
	{
		public FrmShadow()
		{
			InitializeComponent();
		}

        public void ShowShadow(Form parent)
        {
            Point p = new Point(0, 0);

            this.Owner = parent;
            p = parent.PointToScreen(p);
            this.Top = p.Y;
            this.Left = p.X;

            this.Height = parent.ClientRectangle.Height;
            this.Width = parent.ClientRectangle.Width;

            // Set the picture location 
            picLoading.BringToFront();
            picLoading.Left = (this.Width - picLoading.Width) / 2;
            picLoading.Top = (this.Height - picLoading.Height) / 2;
            
            lblProcessing.Left = (this.Width - lblProcessing.Width) / 2;
            lblProcessing.Top = (this.Height - lblProcessing.Height) / 2;
            lblProcessing.BringToFront();
            this.Show();
        }
	}
}
