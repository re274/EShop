using EShop.Domain.Entities.ProductOrder;

namespace EShop.Domain.IRepositories
{
    public interface IOrderRepository : ISaveChangesRepository
    {
        #region order
        Order GetUserOpenOrder(int userId);
        void CreateNewOrderForUser(Order order);
        #endregion

        #region order detail
        void AddOrderDetail(OrderDetail detail);
        #endregion
    }
}
