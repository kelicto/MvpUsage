using System;

using KeLi.FormMvp.Persistence.Models;

namespace KeLi.FormMvp.Persistence.Services
{
    public class UserLoginPService
    {
        public static int AddItem(UserPModel user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user));

            return 1;
        }

        public static int DeleteItem(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentNullException(nameof(userName));

            return 1;
        }

        public static int UpdateItem(UserPModel user)
        {
            if (user is null)
                throw new ArgumentNullException(nameof(user));

            return 1;
        }

        public static UserPModel GetItem(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentNullException(nameof(userName));

            return new UserPModel(userName, "123456");
        }
    }
}