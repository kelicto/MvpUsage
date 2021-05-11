namespace KeLi.HelloMvp.Persistence.Models
{
    public class UserPModel
    {
        public UserPModel(string userName, string password)
        {
            Password = password;
            UserName = userName;
        }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}