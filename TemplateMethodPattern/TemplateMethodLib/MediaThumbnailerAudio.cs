using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TemplateMethodLib
{
    internal class MediaThumbnailerAudio: MediaThumbnailerBase
    {
     protected override Image ExtractThumbnail(MediaInfo mediaInfo, MediaMetadata mediaMetadata)
     {
         Console.WriteLine("MediaThumbnailerAudio.ExtractThumbnail");
         return CreateImage(300, 300, Color.DarkRed, Color.White, "I am an audio file");
     }

     protected override MediaMetadata ExtractMetadata(MediaInfo mediaInfo)
     {
         Console.WriteLine("MediaThumbnailerAudio.MediaMetadata");
         return null;
     }

    }
}
