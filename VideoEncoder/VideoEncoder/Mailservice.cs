using System;

namespace VideoEncoder
{
    public class Mailservice
    {
        public void OnEncodedVideo(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending Mail....." +e.Video.title);
        }
    }
}
