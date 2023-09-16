namespace EShop.Domain.ViewModels.Paging
{
    public class BasePaging
    {
        public int Page { get; set; }

        public int AllEntitiesCount { get; set; }

        public int AllPagesCount { get; set;}

        public int Take { get; set;}

        public int Skip { get; set; }

        public int HowManyPagesShowAfterBefore { get; set; }
    }
}
