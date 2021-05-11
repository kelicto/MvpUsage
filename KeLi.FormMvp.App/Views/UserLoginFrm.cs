using System;
using System.Windows.Forms;

using KeLi.FormMvp.App.IViews;
using KeLi.FormMvp.App.Presenters;

namespace KeLi.FormMvp.App.Views
{
    public partial class UserLoginFrm : Form, IUserLoginView
    {
        private readonly UserPresenter _pst;

        public UserLoginFrm()
        {
            InitializeComponent();

            _pst = new UserPresenter(this);
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
            _pst.LoginSystem();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserName = txtUserName.Text.Trim();

            Password = txtPwd.Text.Trim();

            LoginSys();
        }
    }
}