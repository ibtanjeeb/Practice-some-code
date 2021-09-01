using System;
using System.Threading;

namespace VideoEncoder
{
    public class VideoEventArgs
    {
        public Video Video { get; set; } 
    }
    public class VideoEnoder
    {
        public delegate void VideoEncoderHandler(object source ,VideoEventArgs args);
        public event VideoEncoderHandler VideoEncoded;




            
            
            

            
        public void Encoder(Video video)
        {
            Console.WriteLine("Encoding the video....");

            Thread.Sleep(3000);

            OnvideoEncoded(video);
        }
        protected virtual void OnvideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() {Video =video });


        }
    }
}
