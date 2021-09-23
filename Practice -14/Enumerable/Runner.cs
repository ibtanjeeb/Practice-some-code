using System;
using System.Collections.Generic;
using System.Text;

namespace Enumerable
{
    public class Runner
    {

        public string Name => "Emumerable Example";

        public void Run ()
        {
            Person[] peoplearray = new Person[3]
            {
                new Person("Tanjeeb", "Rahman"),
                new Person("Ashi", "Disk"),
                new Person("Ths", "hgsjd"),
            };

            People peoplelist = new People(peoplearray);

            foreach (Person p in peoplelist)

                Console.WriteLine(p.FirstName+" "+p.LastName);

        }
        
    }
}
