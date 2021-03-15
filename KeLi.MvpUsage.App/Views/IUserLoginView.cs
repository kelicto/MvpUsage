namespace KeLi.MvpUsage.App.Views
{
    public interface IUserLoginView
    {
        string UserName { get; set; }

        string Password { get; set; }

        void ShowMsg(string msg);

        bool ShowConfirm(string msg);

        void LoginSys();
    }
}