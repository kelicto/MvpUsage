using KeLi.MvpUsage.App.Entity;

namespace KeLi.MvpUsage.App.Persistence
{
    public class UserLoginIo
    {
        public static int AddItem(SystemUser user)
        {
            return 1;
        }

        public static int DeleteItem(string userName)
        {
            return 1;
        }

        public static int UpdateItem(SystemUser user)
        {
            return 1;
        }

        public static SystemUser GetItem(string userName)
        {
            return new SystemUser(userName, "123456");
        }
    }
}