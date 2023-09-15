using System.IO;

namespace EShop.Application.StaticItems
{
    public class PathTools
    {
        #region default
        public static string DefaultImagePath = "/images/defaults/NoImage.jpg";
        #endregion

        #region product

        public static string ProductImagePath = "/images/products/main/";

        public static string ProductImageUploadPath =
            Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot/images/products/main/");

        public static string ProductThumbImagePath = "/images/products/thumb/";

        public static string ProductThumbImageUploadPath =
            Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot/images/products/thumb/");

        #endregion
    }
}
