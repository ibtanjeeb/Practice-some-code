using System;

namespace asci
{
    class Program
    {
        static char[] convertintToChar(char N)
        {

            // Count digits in number N
            int m = int.Parse(N);
            int digit = 0;

            while (m > 0)
            {

                // Increment number of digits
                digit++;

                // Truncate the last
                // digit from the number
                m /= 10;
            }

            // Declare char array for result
            char[] arr;

            // Declare duplicate char array
            char[] arr1 = new char[digit + 1];

            // Memory allocation of array
            arr = new char[digit];

            // Separating integer into digits and
            // accommodate it to character array
            int index = 0;

            while (m> 0)
            {

                // Separate last digit from
                // the number and add ASCII
                // value of character '0' is 48
                arr1[++index] = (char)(m % 10 + '0');

                // Truncate the last
                // digit from the number
                m /= 10;
            }

            // Reverse the array for result
            int i;
            for (i = 0; i < index; i++)
            {
                arr[i] = arr1[index - i];
            }

            // Return char array
            return (char[])arr;
        }

        // Driver Code
        public static void Main(String[] args)
        {

            // Given number
            char N = { 'a', 'b', 'c', 'd' };
            int len = 5;

            // Function call
            char[] arr = convertintToChar(N);

            // Print char array
            for (int i = 0; i < len; i++)
                Console.Write("{0}, ", arr[i]);
        }
    }
}

