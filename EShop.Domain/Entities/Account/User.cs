using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Entities.Account
{
    public class User
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(150, ErrorMessage = "نام وارد شده نمی تواند بیش از 150 کاراکتر باشد")]
        public string FirstName { get; set; }


        [MaxLength(150, ErrorMessage = "نام خانوادگی وارد شده نمی تواند بیش از 150 کاراکتر باشد")]
        public string LastName { get; set; }


        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "ایمیل اجباری می باشد")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        public string Email { get; set; }


        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string Password { get; set; }


        [MaxLength(200)]
        public string Avatar { get; set; }
    }
}
