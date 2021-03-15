
namespace KeLi.MvpUsage.App.Entity
{
    public class SystemUser
    {
        public SystemUser(string userName, string pwd)
        {
            UserName = userName;

            Pwd = pwd;
        }

        public string UserName { get; set; }

        public string Pwd { get; set; }
    }
}