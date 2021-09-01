using System;
namespace WorkflowEngine
{
    public class NotifyService : IActiviy
    {
        public void Execute()
        {
            Console.WriteLine("Notifying the Third Party Service");
        }
    }
}
