using System;

namespace ConditionalState
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("Its  autumn and a beatiful season");
                    break;

                case Season.Summer:
                    Console.WriteLine("Its perfect to go beach");
                    break;
                default:
                    Console.WriteLine("I don't understand that season");
                    break;


            }
            
        




        }
    }
}
