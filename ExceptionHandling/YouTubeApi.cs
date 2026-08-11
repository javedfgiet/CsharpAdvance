using CsharpAdvance.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance.ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                throw new Exception("Ooops Some low level Youtube error occured.");

            }
            catch(Exception ex)
            {
                throw new YouTubeException("Could not fetch videos from youtube",ex);
            }
            return new List<Video>();
        }
    }
}
