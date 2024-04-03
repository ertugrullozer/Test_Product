using System.ComponentModel.DataAnnotations;

namespace Test_Product.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şiferenizi giriniz")]
        public string Password { get; set; }
    }
}
