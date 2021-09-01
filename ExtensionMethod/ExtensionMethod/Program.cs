namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string Post = "My name is Mohammad Tanjeebur rahaman chowdhury hjhg lkads Hjdhsadadah ashdasjhda ... ashdjs ";
            var shortenpost = Post.Shorten(5);


        }


    }

    public static class StringExtensions
    {
        public static string Shorten(this String str,int numberofwords )
        {

        }

    }

    
}
