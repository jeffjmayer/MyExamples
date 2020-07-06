using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFileSystem
{
    class Program
    {
        static readonly Random Random = new Random();

        static void Main(string[] args)
        {

            //CreateVideoFiles();
            
            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\";
            string[] videoExtensions = {".wmv", ".mp4", ".flv", ".mpeg", ".mov", ".ogg" };

            var files = Directory.EnumerateFiles(folderPath, "*.*", SearchOption.AllDirectories);
            var videoFiles = from f in files
                             let ext = Path.GetExtension(f)
                             where videoExtensions.Contains(ext, new CaseInsenitiveEqualityComparer())
                             group f by ext into g 
                             select new {g.Key, count = g.Count()};

            foreach (var item in videoFiles)
            {
                Console.WriteLine(item.Key + ": " + item.count);
            }

            Console.ReadLine();
        }
        

        public class CaseInsenitiveEqualityComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y)
            {
                return string.Compare(x, y, StringComparison.OrdinalIgnoreCase) == 0;
            }

            public int GetHashCode(string obj)
            {
                return obj.GetHashCode();
            }
        }

        static void CreateVideoFiles()
        {

            for (var  i = 0; i < 200;  i++)
            {
                var fileName = GetRandomVideoFileName();
                var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\";
                File.Create(folderPath + fileName);
                Console.WriteLine(fileName);
            }
        }

        private static string GetRandomVideoFileName()
        {
            char[] idChars =
                {
                    '0','1','2','3','4','5','6','7','8','9',
                    'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                    'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
                };

            string[] videoExtensions = {".wmv", ".mp4", ".flv", ".mpeg", ".mov", ".ogg"};
            var fileNameLength = Random.Next(5, 20);
            var chars = Enumerable.Range(0, fileNameLength -1 ).Select(n => idChars[Random.Next(0, idChars.Length -1)]);
            var fileExt = videoExtensions[Random.Next(0, videoExtensions.Length - 1)];
            return new string(chars.ToArray()) + fileExt;
            
        }
    }
}
