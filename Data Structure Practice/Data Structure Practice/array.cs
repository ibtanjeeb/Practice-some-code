namespace Data_Structure_Practice
{
    partial class Program
    {
        public class array
        {
            private int[] items;


            private int count;



            public array(int length)
            {

                items = new int[length];




            }

            public void insert(int item)
            {
                if (items.Length == count)
                {
                    int[] newarray = new int[count * 2];

                    for (int i = 0; i < items.Length; i++)
                        newarray[i] = items[i];

                    items = newarray;

                   

                }
                items[count++] = item;


            }


            public void print()
            {
                for(int i=0;i<count;i++)
                    System.Console.WriteLine(items[i]);

            }

        }
    }
}
