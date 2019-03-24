using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using VendingMachine.UI;
using VendingMachine.UILevel;

namespace VendingMachine
{
    static class Program
    {
        //private variable that holds the main form
        private static FrmDashboard frmDashboard;
        
        //public property that provides a getter for main form
        public static FrmDashboard MainForm
        {
            get { return frmDashboard; }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string guid = ((GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), false).GetValue(0)).Value.ToString();
            
            using (Mutex mutex = new Mutex(false, guid))
            {
                if (!mutex.WaitOne(0, true))
                {
                    MessageBox.Show("Unable to run multiple instances of this program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                
                //create new instance of FrmKiosk (our main form)                
                frmDashboard = new FrmDashboard();
                //run the application for the first time                
                try
                {
                    Application.Run(frmDashboard);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
