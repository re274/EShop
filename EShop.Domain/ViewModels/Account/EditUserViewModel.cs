using EShop.Domain.Entities.Account;
using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.ViewModels.Account
{
    public class EditUserViewModel
    {
        [MaxLength(150, ErrorMessage = "نام وارد شده نمی تواند بیش از 150 کاراکتر باشد")]
        public string FirstName { get; set; }

        [MaxLength(150, ErrorMessage = "نام خانوادگی وارد شده نمی تواند بیش از 150 کاراکتر باشد")]
        public string LastName { get; set; }

        public UserGender UserGender { get; set; }
    }
}
