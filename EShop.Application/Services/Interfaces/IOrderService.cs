using EShop.Domain.Entities.ProductOrder;

namespace EShop.Application.Services.Interfaces
{
    public interface IOrderService
    {
        #region order
        Order GetUserOpenOrder(int userId);
        #endregion
    }
}
