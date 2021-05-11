using System;
using System.Windows.Forms;

using KeLi.FormMvp.App.Views;

namespace KeLi.FormMvp.App
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