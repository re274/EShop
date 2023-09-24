using EShop.Domain.Entities.Base;

namespace EShop.Domain.Entities.ProductOrder
{
    public class OrderDetail : BaseEntity
    {
        #region properties
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Count { get; set; }

        public int PayablePrice { get; set; }
        #endregion

        #region relations
        public Order Order { get; set; }
        #endregion
    }
}
