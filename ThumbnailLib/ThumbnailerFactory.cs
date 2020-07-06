using System;

namespace ThumbnailLib
{
    public static class ThumbnailerFactory
    {
        public static ThumbnailerBase CreateThumbnailer(string mimeType)
        {
            switch (mimeType)
            {
                case "audio/mp3":
                    return new ThumbnailerAudio();
                case "image/jpeg":
                    return new ThumbnailerImage();
                case "video/mp4":
                    return new ThumbnailerVideo();
                default:
                    throw  new Exception("Mime Type not Supported");
            }
        }
    }
}
