using EShop.Domain.Entities.Base;

namespace EShop.Domain.Entities.Products
{
    public class ProductSelectedCategory : BaseEntity
    {
        #region properties
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        #endregion

        #region relations
        // Product : name of the relationship
        // [ForeignKey("ProductId")] : با توجه به پراپرتی بالا، خودش میفهمه
        public Product Product { get; set; }
        public ProductCategory ProductCategory { get; set; }
        #endregion
    }
}
