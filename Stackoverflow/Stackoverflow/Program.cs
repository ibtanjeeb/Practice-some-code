using System;
using System.Collections.Generic;
namespace Stackoverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var stac = new stack();
            var ini = 1;
            var max = 6;
            for(var i = ini;i<= max;i++)
            
                stac.Push(i);

            stac.Clear();

            for (var i = ini; i <= max; i++)

              Console.WriteLine(  stac.Pop());




        }
    }
    public class stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("........");
            _list.Add(obj);
                
        }

        public object  Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("......");
            var index = _list.Count - 1;
            var toReturn = _list[index];

            _list.RemoveAt(index);

            return toReturn;

        }
        public void Clear()
        {
            _list.Clear();
        }
        
    }
}
