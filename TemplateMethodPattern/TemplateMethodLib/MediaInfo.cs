using System.IO;

namespace TemplateMethodLib
{
    public class MediaInfo
    {
        public string FileName { get; set; }
        public string MimeType { get; private set; }
        public Stream FileStream { get; private set; }

        public MediaInfo(string fileName, string mimeType, Stream fileStream)
        {
            FileName = fileName;
            MimeType = mimeType;
            FileStream = fileStream;
        }
    }
}