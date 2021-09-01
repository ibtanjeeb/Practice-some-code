using System;
namespace VideoEncoder
{
    public class MessageService
    {
        public void OnEncodedVideo(Object source ,VideoEventArgs e)
        {
            Console.WriteLine("Sending Message....." +e.Video.title);
        }
    }
}
