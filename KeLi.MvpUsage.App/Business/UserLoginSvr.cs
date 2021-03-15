using KeLi.MvpUsage.App.Entity;
using KeLi.MvpUsage.App.Persistence;

namespace KeLi.MvpUsage.App.Business
{
    public class UserLoginSvr
    {
        public static int AddItem()
        {
            return 1;
        }

        public static int DeleteItem()
        {
            return 1;
        }

        public static int UpdateItem()
        {
            return 1;
        }

        public static SystemUser GetItem(string userName)
        {
            return UserLoginIo.GetItem(userName);
        }
    }
}