namespace KeLi.MvpUsage.App.IViews
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