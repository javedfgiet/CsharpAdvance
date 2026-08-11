using System;

namespace CsharpAdvance.Events
{
    public class MessageService
    {
        public void OnVicdeoEncoded(object source, VideoEventArgs e)
        {

            Console.WriteLine("MessageService: Sending a text message .. "+e.Video.Title);
        }
    }
}
