using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumerable
{
   public class People:IEnumerable
    {
        private Person[] _people;
        public People(Person[] Parray)
        {
            _people = new Person[Parray.Length];
            for(int i =0 ;i<Parray.Length;i++)
            {
                _people[i] = Parray[i];
            }

            

        }

        public Person this[int index]
        {
            get
            {
                return _people[index];
            }
            set
            {
                _people[index] = value;
            }

        }

        public Person this[string index]
        {
            get
            {
                return _people.Where(x => x.FirstName==index).First();
            }
            set
            {
                var person = this[index];
                person.LastName = value.LastName;
            }

        }


       IEnumerator IEnumerable. GetEnumerator()
        {
            return new Peopleenum(_people);
        }
    }
}
