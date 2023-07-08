using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EShop.Domain.ViewModels.Account
{
    public class RegisterUserViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        [Compare("Password", ErrorMessage = "کلمه های عبور مغایرت دارند")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }

    public enum RegisterUserResult
    {
        Success,
        NotSentEmail,
        DuplicateEmail
    }
}
