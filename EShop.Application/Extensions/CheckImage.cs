using Microsoft.AspNetCore.Http;
using System.IO;

namespace EShop.Application.Extensions
{
    public static class FileChecker
    {
        public static bool IsCompressFile(this IFormFile file)
        {
            string ex = Path.GetExtension(file.FileName);

            return ex.Contains("rar") || ex.Contains("zip");
        }
    }
}
