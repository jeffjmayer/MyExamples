using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateMethodLib;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var mediaInfo = new MediaInfo(("Some File Name"), "video/mp4", null);
            var thumbnailer = MediaThumbnailerFactory.CreateThumbnailer(mediaInfo.MimeType);
            
            using (var image = thumbnailer.GenerateThumbnail(mediaInfo))
            {
                


            }
            




        }
    }
}
