using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            var name = new List<string>();
            while (true)
            {
                
                Console.Write("Type a name (or hit ENTER to quit): ");

                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                   
                    break;

                name.Add(input);
            }
            if (name.Count > 2)
                Console.WriteLine("{0},{1} and {2} the numbers of others like your post", name[0], name[1], name[2] , name.Count-2);

            else if (name.Count == 2)
                Console.WriteLine("{0} and {1}  like your post", name[0], name[1] );

            else if (name.Count == 1)
                Console.WriteLine("{0} like your post", name[0] );
            else
                Console.WriteLine();



        }
    }
}
