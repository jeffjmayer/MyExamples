using System;
using System.Drawing;

namespace ThumbnailLib
{
    public abstract class ThumbnailerBase
    {
        public Image GetThumbnail(MediaInfo mediaInfo)
        {
            GetMetadata(mediaInfo); 
            Console.WriteLine("ThumbnailerBase.GetThumbnail");
            return GetThumbnailCore(mediaInfo);
        }

        protected Image GenerateImage(int width, int height, Color backgroundColor, Color foregroundColor, string text)
        {
            var bitmap = new Bitmap(width, height);
            try
            {
                using (var graphics = Graphics.FromImage(bitmap))
                using (var backgroundBrush = new SolidBrush(backgroundColor))
                using (var paintBrush = new SolidBrush(foregroundColor))
                using (var font = new Font("Arial", 20f))
                {
                    graphics.FillRectangle(backgroundBrush,0,0,bitmap.Width, bitmap.Height);
                    graphics.DrawString(text,font,paintBrush,10,10);
                    return bitmap;
                }                    
            }
            catch (Exception)
            {
                bitmap.Dispose();
                throw;
            }
        }

        protected abstract void GetMetadata(MediaInfo mediaInfo);
        protected abstract Image GetThumbnailCore(MediaInfo mediaInfo);      
    }

    internal class ThumbnailerImage : ThumbnailerBase
    {
        protected override void GetMetadata(MediaInfo mediaInfo)
        {
            Console.WriteLine("ThumbnailerImage.GetMetadata");
        }

        protected override Image GetThumbnailCore(MediaInfo mediaInfo)
        {
            return GenerateImage(400,300, Color.Orange, Color.White, "I am a Image");
        }
    }

    internal class ThumbnailerVideo : ThumbnailerBase
    {
        protected override void GetMetadata(MediaInfo mediaInfo)
        {
            Console.WriteLine("ThumbnailerVideo.GetMetadata");
        }

        protected override Image GetThumbnailCore(MediaInfo mediaInfo)
        {
            return GenerateImage(480, 270, Color.Blue, Color.White, "I am a Video");
        }
    }

    internal class ThumbnailerAudio : ThumbnailerBase
    {
        protected override void GetMetadata(MediaInfo mediaInfo)
        {
            Console.WriteLine("ThumbnailerAudio.GetMetadata");
        }

        protected override Image GetThumbnailCore(MediaInfo mediaInfo)
        {
            return GenerateImage(300, 300, Color.DarkGreen, Color.White, "I am a Audio");
        }
    }
}
