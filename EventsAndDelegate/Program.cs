using EventsAndDelegate;

partial class Program
{
    private static void Main(string[] args)
    {
        var video = new Video() { Title = "video1"};
        var videoEncoder = new VideoEncoder(); // publisher
        var mailService = new MailService(); // subscriber
        var messageService = new MessageService(); // subscriber

        videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // register subscriber pointer/reference 
        videoEncoder.VideoEncoded += messageService.OnVideoEncoded; // register subscriber pointer/reference

        // remember to subscribe before raising the event
        videoEncoder.Encode(video);

    }

}

