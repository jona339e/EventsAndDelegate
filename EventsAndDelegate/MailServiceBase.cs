using EventsAndDelegate;

public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine($"MailService: Email Sent! {e.MyVideo.Title}");
    }
}