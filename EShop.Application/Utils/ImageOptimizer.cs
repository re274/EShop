using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;

namespace EShop.Application.Utils
{
    public static class ImageOptimizer
    {
        public static void ImageResizer(string inputImagePath, string outputImagePath, int? width, int? height)
        {
            var customWidth = width ?? 100;
            var customHeight = height ?? 100;

            using var image = Image.Load(inputImagePath);
            image.Mutate(x => x.Resize(customWidth, customHeight));

            image.Save(outputImagePath, new JpegEncoder
            {
                Quality = 100
            });
        }
    }
}
