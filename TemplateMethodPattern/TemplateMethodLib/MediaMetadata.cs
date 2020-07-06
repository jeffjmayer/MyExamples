namespace TemplateMethodLib
{
    public class MediaMetadata
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public MediaType MediaType { get; set; }
        public string Codec { get; private set; }
        public int Bitrate { get; private set; }
        public long FileSize { get; set; }

        public MediaMetadata(MediaType mediaType, int width, int height, string codec, int bitrate, long fileSize )
        {
            MediaType = mediaType;
            Width = width;
            Height = height;
            Codec = codec;
            Bitrate = bitrate;
            FileSize = fileSize;
        }
    }
}