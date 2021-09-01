using System;

namespace Stopwatch1
{
    public class StopWatch
    {
        private DateTime _start;
        private DateTime _stop;

        private Random _rand;

        private bool _isRunning;

        public StopWatch()
        {
            _start = new DateTime();
            _stop = new DateTime();
            _rand = new Random();
            _isRunning = false;

        }

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException();
            _start = DateTime.Now;
            _isRunning = true;
            Console.WriteLine("Start Time" + _start.Hour + ":" + _start.Minute + ":" + _start.Second + ":" + _start.Millisecond);


        }



        public void Stop()
        {
            System.Threading.Thread.Sleep(_rand.Next(2000, 6000));

            _stop = DateTime.Now;
            _isRunning = false;
            Console.WriteLine("Start Time" + _stop.Hour + ":" + _stop.Minute + ":" + _stop.Second + ":" + _stop.Millisecond);
            TimeSpan duration = _stop - _start;

            Duration(duration);

        }
        private void Duration(TimeSpan duration)
        {
            Console.WriteLine("Duration:" + duration.Seconds + "sec" + duration.Milliseconds + "milisec");
        }


    }
}
