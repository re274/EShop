using EShop.Domain.Entities.ProductOrder;

namespace EShop.Application.Services.Interfaces
{
    public interface IOrderService
    {
        #region order
        Order GetUserOpenOrder(int userId);
        bool AddProductToUserOrder(int userId,int productId, int count);
        #endregion
    }
}
