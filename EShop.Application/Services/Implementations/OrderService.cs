using EShop.Application.Services.Interfaces;
using EShop.Domain.Entities.ProductOrder;
using EShop.Domain.IRepositories;

namespace EShop.Application.Services.Implementations
{
    public class OrderService : IOrderService
    {
        #region constructor
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        #endregion

        #region order
        public Order GetUserOpenOrder(int userId)
        {
            var openOrder = _orderRepository.GetUserOpenOrder(userId);

            if (openOrder == null)
            {
                var newOrder = new Order { UserId = userId };
                _orderRepository.CreateNewOrderForUser(newOrder);
                _orderRepository.SaveChanges();
                return newOrder;
            }
            return openOrder;
        }
        public bool AddProductToUserOrder(int userId, int productId, int count)
        {
            var userOpenOrder = GetUserOpenOrder(userId);

            var orderDetail = new OrderDetail
            {
                ProductId = productId,
                OrderId = userOpenOrder.Id,
                Count = count
            };
            _orderRepository.AddOrderDetail(orderDetail);
            _orderRepository.SaveChanges();

            return true;
        }
        #endregion
    }
}
