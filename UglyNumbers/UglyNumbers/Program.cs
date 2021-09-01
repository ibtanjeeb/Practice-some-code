using System;

namespace UglyNumbers
{
    class Program : ProgramBase
    {
        static int MaxDevide(int a ,int b)
        {
            while(a % b ==0)
            
                a = a / b;
                return a;

            
        }

        static int Isugly(int no)
        {
            no = MaxDevide(no, 2);
            no = MaxDevide(no, 3);
            no = MaxDevide(no, 5);

            return (no == 1 ? 1 : 0);

              
        }
    }
}
