using System;

namespace Class5
{
    class Program
    {
        
        static void Main(string[] args)
        {

             var name = new int [200] ;
            var number = 12030;
            var count = 0;
            for(var i=0;i<10;i++)

            {
                if (number % 2 == 0)
                    
                    continue;
                else
                    number /= 2;
                name[count++] = number;
                if (number < 100)
                    break;

            }
            
            
            Console.WriteLine("Hello World!" +count);
        }
    }
}
