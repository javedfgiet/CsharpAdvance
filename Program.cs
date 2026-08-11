using CsharpAdvance.ExceptionHandling;
using System;
using System.IO;
using System.Linq;
using BookRepository = CsharpAdvance.LINQ.BookRepository;
namespace CsharpAdvance
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("javed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message) ;
            }
            
        }
    }
}
