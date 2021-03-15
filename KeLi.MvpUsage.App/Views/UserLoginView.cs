using System;
using System.Windows.Forms;

using KeLi.MvpUsage.App.Presenters;

namespace KeLi.MvpUsage.App.Views
{
    public partial class UserLoginView : Form, IUserLoginView
    {
        private readonly UserLoginCtrl _pst;

        public UserLoginView()
        {
            InitializeComponent();

            _pst = new UserLoginCtrl(this);
        }

        public string UserName { get; set; }

        public string Password { get; set; }

        public void ShowMsg(string msg)
        {
            MessageBox.Show(msg);
        }

        public bool ShowConfirm(string msg)
        {
            var result = MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return result == DialogResult.OK;
        }

        public void LoginSys()
        {
            _pst.LoginSys();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserName = txtUserName.Text.Trim();

            Password = txtPwd.Text.Trim();

            LoginSys();
        }
    }
}