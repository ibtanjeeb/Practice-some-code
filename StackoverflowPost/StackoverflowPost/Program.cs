using System;

namespace StackoverflowPost

{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("Test my post ", "Here is description");
            
            Console.WriteLine($"Title: { post.Title}");
            Console.WriteLine($"Description: {post.Description}");
            Console.WriteLine($"DateTime: {post.timedatecreated}");
            Console.WriteLine($"Count: {post.votecount}");
            post.Votedown ();
            Console.WriteLine($"Count: {post.votecount}");
            post.Voteup();
            Console.WriteLine($"Count: {post.votecount}");



        }
    }
}
