namespace Class_Array
{
    partial class Program
    {
        public class Array
        {
            private int[] items;

            private int count;
            public Array(int Length)
            {
                items = new int[Length];
            }


            public void insert(int item)
            {
                items[count++] = item;

            }

            public void Print()
            {
                for(int i =0;i<count;i++)
                    System.Console.WriteLine(items[i]);
            }
        }
    }
}
