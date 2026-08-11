using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance.Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applied Brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Contrast Applied");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Photo Resized");
        }
    }
}
