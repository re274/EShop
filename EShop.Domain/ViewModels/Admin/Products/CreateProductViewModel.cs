using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.ViewModels.Admin.Products
{
    public class CreateProductViewModel
    {
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(300, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string Title { get; set; }

        [Display(Name = "توضیحات مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(360, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string ShortDescription { get; set; }

        [Display(Name = "توضیحات اصلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Description { get; set; }

        [Display(Name = "قیمت")]
        public int Price { get; set; }

        public bool IsActive { get; set; }

        public IFormFile ProductImage { get; set; }
    }
}
