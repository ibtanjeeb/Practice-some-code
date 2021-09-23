using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Enumerable
{
   public class Peopleenum:IEnumerator
    {
       public Person[] _people;

        int position = -1;

        public Peopleenum(Person[] list)
        {
            _people = list;



        }

       


        public bool MoveNext()
        {
            position++;

            return (position < _people.Length);
        }

        public void Reset()
        {
            position = -1;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {

                    throw new InvalidOperationException();
                }
            }

        }


    }
}
