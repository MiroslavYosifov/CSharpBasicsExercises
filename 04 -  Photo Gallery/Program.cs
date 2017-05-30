using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04____Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var photoSizeInByte = int.Parse(Console.ReadLine());
            var widthResolution = int.Parse(Console.ReadLine());
            var heigthResolution = int.Parse(Console.ReadLine());


            var photoSizeFormat = ConvertBytes(photoSizeInByte);
            var kindOfPhoto = DefineKindOfPhoto(widthResolution, heigthResolution);

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg \n" +
                $"Date Taken: {day:D2}/{month:D2}/{year:D4} {hours:D2}:{minutes:D2} \n" +
                $"Size: {photoSizeFormat} \n" +
                $"Resolution: {widthResolution}x{heigthResolution} ({kindOfPhoto})");


        }

        private static string DefineKindOfPhoto(int widthResolution, int heigthResolution)
        {
            string kindOfPhoto;
            if (widthResolution > heigthResolution)
            {
                kindOfPhoto = "landscape";
            }
            else if (widthResolution < heigthResolution)
            {
                kindOfPhoto = "portrait";
            }
            else
            {
                kindOfPhoto = "square";
            }

            return kindOfPhoto;
        }

        private static string ConvertBytes(int photoSizeInByte)
        {
            var converFromKb = 0.0;
            var sizeFormat1 = "";
            if(photoSizeInByte < 1024)
            {
                sizeFormat1 = photoSizeInByte.ToString() + "B";
            }
            else if (photoSizeInByte >= 1000 && photoSizeInByte < 1000000)
            {
                converFromKb = Math.Round((double)photoSizeInByte / 1000,1);
                sizeFormat1 = converFromKb.ToString() + "KB";
            }
            else if (photoSizeInByte >= 1000000)
            {
                converFromKb = Math.Round((double)photoSizeInByte / 1000000, 1);
                sizeFormat1 = converFromKb.ToString() + "MB";
            }
            return sizeFormat1;
        }
    }
}
