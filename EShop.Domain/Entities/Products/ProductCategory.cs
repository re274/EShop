using EShop.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Entities.Products
{
    public class ProductCategory : BaseEntity
    {
        #region properties

        public int? ParentId { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string Title { get; set; }

        [Display(Name = "عنوان در URL")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string UrlName { get; set; }
        public bool IsActive { get; set; }

        #endregion

        #region relations
        #endregion
    }
}
