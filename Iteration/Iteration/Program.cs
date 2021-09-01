using System;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i =0; i<=10;i++ )
            {
                if(i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            for (var i =10; i >=0; i--)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
