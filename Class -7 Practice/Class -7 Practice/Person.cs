using System;
using System.Collections.Generic;
using System.Text;

namespace Class__7_Practice
{
    public class Person
    {

        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }
        protected readonly string  PrefixId;

        public string Generateid()
        {
            if (!string.IsNullOrEmpty(Name))
                return $"{PrefixId}-{Name.Substring(0, 2)}";

            else
                return null;

        }

        public Person(string PrefixId)
        {
            this.PrefixId = PrefixId;
        }

    }
}
