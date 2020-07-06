using System;

namespace Polymorphism
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a choice");
            var choice = Console.ReadLine();

            ThumbnailerBase thumbnailer = CreateThumbnailer(choice); 
            thumbnailer.GetThumbnail();

            Console.ReadLine();
        }

        private static ThumbnailerBase CreateThumbnailer(string choice)
        {
            switch (choice)
            {
                case "I":
                case "i":
                    return new ThumbnailerImage();
                case "V":
                case "v":
                    return new ThumbnailerVideo();
                case "A":
                case "a":
                    return new ThumbnailerAudio();
                default:
                    throw new Exception("Your choice is invalid");
            }
        }
    }

    abstract class ThumbnailerBase
    {
        protected abstract void GetMetadata();

        public void GetThumbnail()
        {
            GetMetadata();
            Console.WriteLine("ThumbnailerBase.GetThumbnail");
        }
    }

    class ThumbnailerImage : ThumbnailerBase
    {
        protected override void GetMetadata()
        {
            Console.WriteLine("ThumbnailerImage.GetMetadata");
        }
    }

    class ThumbnailerVideo : ThumbnailerBase
    {
        protected override void GetMetadata()
        {
            Console.WriteLine("ThumbnailerVideo.GetMetadata");
        }
    }

    class ThumbnailerAudio : ThumbnailerBase
    {
        protected override void GetMetadata()
        {
            Console.WriteLine("ThumbnailerAudio.GetMetadata");
        }
    }
}




