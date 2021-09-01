using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Results = new int[100, 100];

            (int x,int y)[] points = new (int x,int y)[100];

            int count = 0;

            for (int i = 1; i < 100; i++)
            {

                for (int j = 1; j <= 100; i++)
                {

                   // points[count++] = new (int x, int y) { x = i, y = j };




                }
            }

            int r = 0;

            for(int i =0; i<count;i++)
            {
                r += (points[i].x * points[i].y + points[i].x / points[i].y);


            }
            (string[] data, int count) mydata = Getdata();

            Console.WriteLine(mydata.count);
            foreach(var i in mydata.data)
            {
                Console.WriteLine(i);
            }


        }

        static (string[] Data ,int count)Getdata()
        {

            string[] r = new string[] {"Hello","World" };

            int c = 9;
            return (r, c);



        }



        //public struct Points
        //{
          //  public int x;
            //public int y;
        //}
    
    }
}
