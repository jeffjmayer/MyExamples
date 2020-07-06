using System;
using System.Drawing;

namespace TemplateMethodLib
{
    public abstract class MediaThumbnailerBase
    {
        public Image GenerateThumbnail(MediaInfo mediaInfo)
        {
            ValidateMediaInfo(mediaInfo);
            EnsureMimTypeIsSupported(mediaInfo.MimeType);
            MediaMetadata mediaMetadata = ExtractMetadata(mediaInfo);
            
            return ExtractThumbnail(mediaInfo, mediaMetadata);

        }

        protected abstract Image ExtractThumbnail(MediaInfo mediaInfo, MediaMetadata mediaMetadata);
        protected abstract MediaMetadata ExtractMetadata(MediaInfo mediaInfo);

        protected virtual void EnsureMimTypeIsSupported(string p)
        {
            Console.WriteLine("MediaThumbnailerBase.EnsureMimTypeIsSupported");
        }

        private void ValidateMediaInfo(MediaInfo mediaInfo)
        {
            Console.WriteLine("MediaThumbnailerBase.ValidateMediaInfo");
        }


        protected Image CreateImage(int width, int height, Color backgroundColor, Color foregroundColor, string text)
        {
            var bitmap = new Bitmap(width, height);
            try
            {
                using (var graphics = Graphics.FromImage(bitmap))
                using (var backgroundBrush = new SolidBrush(backgroundColor))
                using (var paintBrush = new SolidBrush(foregroundColor))
                using (var font = new Font("Arial", 20f))
                {
                    graphics.FillRectangle(backgroundBrush, 0, 0, bitmap.Width, bitmap.Height);
                    graphics.DrawString(text, font, paintBrush, 10, 10);
                    return bitmap;
                }
            }
            catch (Exception)
            {
                bitmap.Dispose();
                throw;
            }
        }


    }


}
