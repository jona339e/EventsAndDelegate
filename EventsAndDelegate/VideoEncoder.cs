using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegate
{
    public class VideoEncoder
    {
        // 1- define a delegate
        // 2- define an event based on that delegate
        // 3- raise the event
        // 4- create subscribers

        // declare delegate
        // the delegates holds a reference with the same signature
        // for delegates you add EventHandler to the event name so in this case VideoEncoded will be the event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);



        // declare event

        //public event VideoEncodedEventHandler VideoEncoded;

        // this build in eventhandler can declare delegate and event for us!
        // EventHandler
        // EvenHandler<TEventArgs>
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(2000);
            Console.WriteLine($"{video.Title} done encoding!");

            // remember to call the event
            OnVideoEncoded(video);
        }

        // raise event
        // event publisher methods should be protected virtual and void
        // naming should start with On followed by the event
        //
        // the purpose of this method is to notify subsribers

        protected virtual void OnVideoEncoded(Video video)
        {
            // check if subscribers exist
            if(VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { MyVideo = video }); 
                // first define source of event (which is this class) then give data to send (in this case I send nothing)
        }

    }
}
