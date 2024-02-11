using EShop.Domain.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Entities.Account
{
    public class User : BaseEntity
    {
        #region properties
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

        public UserGender UserGender { get; set; }

        [MaxLength(300, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string ActiveCode { get; set; }

        public bool IsActive { get; set; }

        public DateTime RegisterDate { get; set; }

        public bool IsSuperUser { get; set; }
        #endregion

        #region relations

        #endregion
    }
    public enum UserGender
    {
        Male,
        Female
    }
}
