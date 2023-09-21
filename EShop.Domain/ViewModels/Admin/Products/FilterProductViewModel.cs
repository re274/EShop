﻿using EShop.Domain.Entities.Products;
using EShop.Domain.ViewModels.Paging;
using System.Collections.Generic;

namespace EShop.Domain.ViewModels.Admin.Products
{
    public class FilterProductViewModel : BasePaging
    {
        public string Title { get; set; }

        //public int? StartPrice { get; set; }

        //public int? EndPrice { get; set; }

        public List<Product> Products { get; set; }
    }

    public enum FilterProductOrder
    {
        CreateDate_Asc,
        CreateDate_Des,
        Id_Asc,
        Id_Des,
        Price_Asc,
        Price_Des,
    }
}
