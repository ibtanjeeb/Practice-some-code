using System;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = "Hello";
            string st1 = "He";

            string name = "Mohammmad Tanjeebur Rahaman Chowdhury";

            Console.WriteLine(st.Contains(st1));
            Console.WriteLine( name.ToLower());
            Console.WriteLine(name.StartsWith("Mo"));
            Console.WriteLine(name.EndsWith("Chowdhury"));
            Console.WriteLine( name.IndexOf('T'));

            string st11 = "My life is not okay Right now";
            char[] arr = { 'l', 'o', 'y' ,'R'};


            Console.WriteLine(st11.IndexOfAny(arr)+1);

            //string tanjeeb = "Rahman Chowdhry";

            //Console.WriteLine(tanjeeb.Insert(7, "Mohammad Tanjeebur "));

            //Console.WriteLine(tanjeeb.LastIndexOf('C'));
            //Console.WriteLine(st11.LastIndexOfAny(arr) );

            //string sr = "abcdefcbdgh";
            //char[] n = { 'c','d'};
            //Console.WriteLine(sr.LastIndexOfAny(n));
            //string nn = sr.PadLeft(30);
            //Console.WriteLine(nn);

            //string jj = nn.PadRight(30);
            //Console.WriteLine(jj);


            //Console.WriteLine(sr.Remove(6));

            //Console.WriteLine(sr.Replace('a', 'e'));

            //string sr1 = "a,b,c,d,e,fcbdgh";



            //string[] spli = sr1.Split(',');
            

            //foreach(var ch in spli)
            //{
            //    Console.WriteLine(ch);
            //}

            //char [] ll = sr1.ToCharArray();

            //foreach (var kk in ll)

            //{
            //    Console.WriteLine(kk);
            //}


            //Console.WriteLine(sr1.Substring(2));
            //string up = "mujibur rahman ";


            //Console.WriteLine(up.ToUpper());
            //char[] cg = { 'y', 'h', 'k' };
            //string tr = "yyyhkhhhhssskyykhjhsjh";
            //Console.WriteLine(tr.TrimEnd(cg));





              



          
            







        }
    }
}
