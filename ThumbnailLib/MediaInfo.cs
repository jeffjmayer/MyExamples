using System.IO;

namespace ThumbnailLib
{
    public class MediaInfo
    {
        public string FileName { get; private set; }
        public string MimeType { get; private set; }
        public Stream FileStream { get; private set; }

        public MediaInfo(string fileName, string mimeType, Stream FileStream)
        {
            FileName = fileName;
            MimeType = mimeType;
            this.FileStream = FileStream;
        }
    }


}
