using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TemplateMethodLib
{
    internal class MediaThumbnailerImage: MediaThumbnailerBase
    {
        protected override Image ExtractThumbnail(MediaInfo mediaInfo, MediaMetadata mediaMetadata)
        {
            Console.WriteLine("MediaThumbnailerImage.ExtractThumbnail");
            return CreateImage(400, 300, Color.DarkGreen, Color.White, "I am an Image File");
        }

        protected override MediaMetadata ExtractMetadata(MediaInfo mediaInfo)
        {
            Console.WriteLine("MediaThumbnailerImage.MediaMetadata");
            return null;
        }
    }
}
