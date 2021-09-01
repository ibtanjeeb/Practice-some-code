namespace UglyNumbers
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {
            int no = UglyNumbersNo(120);
            Console.WriteLine("Hello World!" + no);
        }

        static int UglyNumbersNo(int n)
        {
            int i = 1;
            int count = 1;
            while (n > count)
            {
                i++;
                if (Isugly(i) == 1)
                    count++;

            }
        }
    }
}