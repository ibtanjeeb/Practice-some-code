using System;

namespace Inheritence
{
    public class Text : PresentaionObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlimk(string url)
        {
            Console.WriteLine("Added hyper link" + url);
        }
    }
}
