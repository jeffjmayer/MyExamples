using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TemplateMethodLib
{
   internal class MediaThumbnailerVideo : MediaThumbnailerBase
    {
        protected override Image ExtractThumbnail(MediaInfo mediaInfo, MediaMetadata mediaMetadata)
        {
            Console.WriteLine("MediaThumbnailerVideo.ExtractThumbnail");
            return CreateImage(400, 270, Color.DarkRed, Color.White, "I am a Video File");
        }

        protected override MediaMetadata ExtractMetadata(MediaInfo mediaInfo)
        {
            Console.WriteLine("MediaThumbnailerVideo.MediaMetadata");
            return null;
        }
    }
}
