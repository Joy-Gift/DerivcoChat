using System.ComponentModel.DataAnnotations;

namespace ChatAppWinterSchool
{
    public class LoginCredentials
    {
        [Required]
        public string NickName { get; set; }
        [Required]
        public string Password { get; set; }

        /*public LoginCredentials(string Nickname , string Password)
        {
            this.Password = Password;
            this.NickName = NickName;
        }*/

    }


}





