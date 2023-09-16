using System;

namespace EShop.Domain.ViewModels.Paging
{
    public class Pager
    {
        public static BasePaging Build(int page, int allEntitiesCount, int take, int howManyPagesShowAfterBefore)
        {
            var allPagesCount = (int)Math.Ceiling(allEntitiesCount / (double)take);

            return new BasePaging()
            {
                Page = page,
                AllEntitiesCount = allEntitiesCount,
                Take = take,
                Skip = take * (page - 1),
                AllPagesCount = allPagesCount,
                HowManyPagesShowAfterBefore = howManyPagesShowAfterBefore,
                StartPage = page > howManyPagesShowAfterBefore ? page - howManyPagesShowAfterBefore : 1,
                EndPage = page + howManyPagesShowAfterBefore > allPagesCount ? allPagesCount : page + howManyPagesShowAfterBefore,
            };
        }
    }
}
