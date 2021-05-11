using KeLi.FormMvp.App.IViews;
using KeLi.FormMvp.App.Models;
using KeLi.FormMvp.Business.Services;

namespace KeLi.FormMvp.App.Presenters
{
    public class UserPresenter
    {
        private readonly IUserLoginView _view;

        public UserPresenter(IUserLoginView view)
        {
            _view = view;
        }

        public void LoginSystem()
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

            var mod = new UserModel
            {
                UserName = _view.UserName,
                Password = _view.Password
            };

            var user = UserLoginBService.GetItem(mod.UserName);

            _view.ShowMsg(user.Password == mod.Password ? "Logins successful!" : "Logins failed!");
        }
    }
}