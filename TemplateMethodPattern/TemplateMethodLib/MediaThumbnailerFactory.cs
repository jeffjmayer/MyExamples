using System;

namespace TemplateMethodLib
{
    public static class MediaThumbnailerFactory
    {
        public static MediaThumbnailerBase CreateThumbnailer(string mimeType)
        {
            switch (mimeType)
            {
                case "image/jpg":
                    return new MediaThumbnailerImage();
                case "audio/mp3":
                case "audio/aac":
                    return new MediaThumbnailerAudio();
                case "video/mp4":
                case "video/flv":
                    return new MediaThumbnailerVideo();
                default:
                    throw new Exception("Mime Type not Supported");
            }
        }
    }
}
