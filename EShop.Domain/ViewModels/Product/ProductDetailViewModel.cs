using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using EShop.Domain.Entities.Products;

namespace EShop.Domain.ViewModels.Product
{
    public class ProductDetailViewModel
    {
        public int Id { get; set; }

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

        [Display(Name = "نام تصویر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(360, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string ImageName { get; set; }

        [Display(Name = "قیمت")]
        public int Price { get; set; }

        public int Inventory { get; set; }

        public DateTime CreateDate { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
