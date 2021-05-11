namespace KeLi.FormMvp.Business.Models
{
    public class UserBModel
    {
        public UserBModel(string userName, string password)
        {
            Password = password;
            UserName = userName;
        }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}