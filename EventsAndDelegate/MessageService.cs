
using EventsAndDelegate;

public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MessageSerivce: Text Message Sent! {e.MyVideo.Title}");
        }
    }


