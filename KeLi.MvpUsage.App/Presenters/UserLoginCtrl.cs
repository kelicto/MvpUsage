using KeLi.MvpUsage.App.Business;
using KeLi.MvpUsage.App.Models;
using KeLi.MvpUsage.App.Views;

namespace KeLi.MvpUsage.App.Presenters
{
    public class UserLoginCtrl
    {
        private readonly IUserLoginView _view;

        public UserLoginCtrl(IUserLoginView view)
        {
            _view = view;
        }

        public void LoginSys()
        {
            if (string.IsNullOrWhiteSpace(_view.UserName))
            {
                _view.ShowMsg("User name cannot empty!");

                return;
            }

            if (string.IsNullOrWhiteSpace(_view.Password))
            {
                _view.ShowMsg("Password cannot empty!");

                return;
            }

            if (!_view.ShowConfirm("Are you sure to login system?"))
                return;

            var mod = new SystemUserVM
            {
                UserName = _view.UserName,

                Password = _view.Password
            };

            var ety = UserLoginSvr.GetItem(mod.UserName);

            _view.ShowMsg(ety.Pwd == mod.Password ? "Logins successful!" : "Logins failed!");
        }
    }
}