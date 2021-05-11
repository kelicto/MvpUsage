using System;
using System.Windows.Forms;

using KeLi.MvpUsage.App.Views;

namespace KeLi.MvpUsage.App
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new UserLoginFrm());
        }
    }
}