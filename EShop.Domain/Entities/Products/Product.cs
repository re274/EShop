using EShop.Domain.Entities.Base;
using System;

namespace EShop.Domain.Entities.Products
{
    public class Product : BaseEntity
    {
        #region properties
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public int Price { get; set; }
        public bool IsActive { get; set; }

        #endregion

    }
}
