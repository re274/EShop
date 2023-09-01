using EShop.Domain.Entities.Products;
using System.Collections.Generic;

namespace EShop.Domain.IRepositories
{
    public interface IProductRepository : ISaveChangesRepository
    {
        //CRUD operation only
        #region 
        //void AddUser(User user);
        //void EditUser(User user);
        //bool IsUserExistsByEmail(string email);
        //User GetUserByEmail(string email);

        #endregion


        #region categories

        List<ProductCategory> GetAllActiveProductCategories();

        #endregion


        #region products

        #endregion
    }
}
