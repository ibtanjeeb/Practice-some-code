using System;
using System.Collections.Generic;

using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //ScenerioRegular();
            //Console.WriteLine("=======================");
            var random = new Random();
            var index = random.Next(2, 6);
            var stopwatch = new StopWatch();
            for(int i =0;i < index; i++)
            {
                stopwatch.Start();
                stopwatch.Stop();
            }
            Console.ReadLine();

        }

        private static void ScenerioRegular()
        {
            Console.WriteLine("Scenerio Regular\n");
            var stopwatch = new StopWatch();
            stopwatch.Start();

            stopwatch.Stop();
            
        }
    }
}
