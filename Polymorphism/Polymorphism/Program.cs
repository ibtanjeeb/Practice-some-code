using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var enocoder = new VideoEncoder();
            enocoder.ResgisterNotificationChannel(new MailNotificationChannel());
            enocoder.ResgisterNotificationChannel(new SmsNotifisationChannnel());

            enocoder.Encode(new Video());
        }
    }
}
