namespace VideoEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { title = " Title 1" };
            var encoder = new VideoEnoder();
            var mail = new Mailservice();
            var mess = new MessageService();

            encoder.VideoEncoded += mail.OnEncodedVideo;


            encoder.VideoEncoded += mess.OnEncodedVideo;
            encoder.Encoder(video);


          







        }
    }
}
