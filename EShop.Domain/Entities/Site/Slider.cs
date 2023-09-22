using EShop.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Entities.Site
{
    public class Slider : BaseEntity
    {
        #region properties
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(300, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string Title { get; set; }

        [Display(Name = "عنوان دوم")]
        [MaxLength(300, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string SecondTitle { get; set; }

        [Display(Name = "توضیحات مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(300, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string ShortDescription { get; set; }

        [Display(Name = "لینک")]
        [MaxLength(300, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string URL { get; set; }

        public bool IsActive { get; set; }

        public string ImageName { get; set; }
        #endregion
    }
}
