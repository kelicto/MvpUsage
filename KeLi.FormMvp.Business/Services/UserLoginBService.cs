﻿using KeLi.FormMvp.Business.Models;
using KeLi.FormMvp.Persistence.Services;

namespace KeLi.FormMvp.Business.Services
{
    public class UserLoginBService
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

        public static UserBModel GetItem(string userName)
        {
            var user = UserLoginPService.GetItem(userName);

            return new UserBModel(user.UserName, user.Password);
        }
    }
}