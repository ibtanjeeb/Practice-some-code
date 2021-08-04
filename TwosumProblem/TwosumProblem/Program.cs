using System;

namespace TwosumProblem
{
    class Program
    {
        public static int[] Twosums (int[] ar,int target)
        {
            int[] numbers = new int[2];
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar.Length; j++)
                {
                    if (i == j)
                        continue;
                    else
                    {
                        if (ar[i] + ar[j] == target)
                        {
                            numbers[0] = i;
                            numbers[1] = j;
                        }

                    }
                }
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            int[] ar = { 1, 3, 5, 6, 7 };
            int target = 4;
            var result = Twosums(ar, target);
            Console.WriteLine(result[0]+" "+result[1] );
        }
    }
}
