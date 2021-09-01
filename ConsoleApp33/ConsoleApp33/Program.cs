using System;

namespace ConsoleApp33
{



    class Program
    {
        static int MaxDevide(int a,int b)
        {
           while(a%b == 0)
            {
                a = a / b;
                

            }

            return a;
        }


        static int IsUgly (int no)
        {
            no = MaxDevide(no, 2);

            no = MaxDevide(no, 3);
            no = MaxDevide(no, 5);
            return (no == 1 ? 1 : 0);



        }


        static int GetUgly (int n)
        {
            int i = 1;
            int cout = 1;
            while(n>cout)
            {
                i++;
                if (IsUgly(i) == 1)
                    cout++;
            }

            return i;
        }
        static void Main(string[] args)
        {
            int no = GetUgly(50);


            Console.WriteLine("Hello World!" +no);
        }
    }
}
