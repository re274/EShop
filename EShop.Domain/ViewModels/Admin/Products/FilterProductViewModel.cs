using EShop.Domain.ViewModels.Paging;
using System.Collections.Generic;

namespace EShop.Domain.ViewModels.Admin.Products
{
    public class FilterProductViewModel : BasePaging
    {
        public FilterProductViewModel()
        {
            OrderBy = FilterProductOrder.CreateDate_Asc;
            State = FilterProductState.All;
        }
        public string Title { get; set; }

        //public int? StartPrice { get; set; }

        //public int? EndPrice { get; set; }

        public FilterProductOrder OrderBy { get; set; }

        public FilterProductState State { get; set; }

        public List<Entities.Products.Product> Products { get; set; }

        public FilterProductViewModel SetPaging(BasePaging pager)
        {
            Page = pager.Page;
            Take = pager.Take;
            Skip = pager.Skip;
            StartPage = pager.StartPage;
            EndPage = pager.EndPage;
            HowManyPagesShowAfterBefore=pager.HowManyPagesShowAfterBefore;
            AllEntitiesCount = pager.AllEntitiesCount;
            AllPagesCount= pager.AllPagesCount;

            return this;
        }
    }

    public enum FilterProductOrder
    {
        CreateDate_Asc,
        CreateDate_Des,
        Price_Asc,
        Price_Des,
        ExistsProducts
    }

    public enum FilterProductState
    {
        All,
        ActiveProducts,
        DeletedProducts,
        ExistsProducts
    }
}
