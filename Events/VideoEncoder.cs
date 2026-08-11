using System;
using System.Threading;

namespace CsharpAdvance.Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }


    public class VideoEncoder
    {
        /* # steps to implement event 
         * 1. Define a delegate
         * 2. Define an event based on that delegate
         * 3. Rasie teh event
         */

        //Step 1: Define delegate
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //Step 2: Define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Videos...");
            Thread.Sleep(3000);

            //Step 3: Rasie teh event
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs {Video=video });
        }

    }
}


/*
 * internal class Program
    {

        static void Main(string[] args)
        {
            var video = new Video { Title = "Video 1" };

            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //Subscriber
            var messageService=new MessageService(); //Subscriber

            videoEncoder.VideoEncoded += mailService.OnViceoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVicdeoEncoded;
            videoEncoder.Encode(video);


        }


    }
 */