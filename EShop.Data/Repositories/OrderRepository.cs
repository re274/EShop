﻿using EShop.Data.DBContext;
using EShop.Domain.Entities.ProductOrder;
using EShop.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EShop.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        #region constructor
        private readonly EShopDbContext _context;
        public OrderRepository(EShopDbContext context)
        {
            _context = context;
        }
        #endregion

        #region order

        public void CreateNewOrderForUser(Order order)
        {
            _context.Add(order);
        }

        public Order GetUserOpenOrder(int userId)
        {
            return _context.Orders.Include(s => s.OrderDetails).SingleOrDefault(o => o.UserId == userId && !o.IsPay);
        }
        #endregion

        #region order detail
        public void AddOrderDetail(OrderDetail detail)
        {
            _context.Add(detail);
        }

        public void UpdateOrderDetail(OrderDetail detail)
        {
            _context.Update(detail);
        }
        #endregion

        #region save changes
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        #endregion
    }
}
