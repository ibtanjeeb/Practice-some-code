using System;
namespace Polymorphism
{
    public class SmsNotifisationChannnel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");

        }
    }
}
