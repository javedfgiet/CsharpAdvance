using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance.Delegates
{
    //public delegate void PhotoFilterHandler(Photo photo);

    public class PhotoProcessor
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();

        }
    }

    /*
     *  internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

           // PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;

            processor.Process("photo.jpg",filterHandler);
        }

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Applied RemoveRedEye");
        }
    }

     */
}
