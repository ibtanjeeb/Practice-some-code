using System;
namespace WorkflowEngine
{
    public class SendEmailuser : IActiviy
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email to Owner");
        }
    }
}
