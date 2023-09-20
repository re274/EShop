namespace EShop.Domain.ViewModels.Paging
{
    public class BasePaging
    {
        public BasePaging()
        {
            HowManyPagesShowAfterBefore = 3;
            Take = 2;
            Page = 1;
        }
        public int Page { get; set; }

        public int AllEntitiesCount { get; set; }

        public int AllPagesCount { get; set; }

        public int Take { get; set; }

        public int Skip { get; set; }

        public int HowManyPagesShowAfterBefore { get; set; }

        public int StartPage { get; set; }

        public int EndPage { get; set; }
    }
}
