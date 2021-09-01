using System;
using System.Threading;

namespace Stopwatch12
{
    public class StopWatch
    {
        public DateTime _startTime;
        public DateTime _endTime;

        private bool _running;
        public void Start ()
        {
            
                if (_running)
           

                throw new InvalidOperationException("Stopwatch is already Running");
               
            _startTime = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            if (!_running)
            

                throw new InvalidOperationException("Stopwatch is not Running");
            
            _endTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan GetInterval()
        {
           return _endTime - _startTime;
            
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();
            for(var i =0; i < 10; i++)
            {
                stopwatch.Start();
                Thread.Sleep(2000);

                stopwatch.Stop();
                Console.WriteLine("Duration" + stopwatch.GetInterval());

                Console.WriteLine("Press Enter to run stopwatch One more time");

                Console.ReadLine();

            }

            

        }
    }
}
