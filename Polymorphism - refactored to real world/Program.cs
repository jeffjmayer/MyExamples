using System;
using ThumbnailLib;

namespace Polymorphism
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter Mime Type");
            var mimeType = Console.ReadLine();

            var mediaInfo = new MediaInfo("Some file name", mimeType, null);

            ThumbnailerBase thumbnailer = ThumbnailerFactory.CreateThumbnailer(mediaInfo.MimeType);
            using (var image = thumbnailer.GetThumbnail(mediaInfo))
            {


            }

            Console.ReadLine();
        }
    }
}




