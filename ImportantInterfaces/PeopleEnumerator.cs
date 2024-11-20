using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class PeopleEnumerator<T> : IEnumerator<T>
    {
        private List<T> list;
        private int position;

        public PeopleEnumerator(List<T> people)
        {
            list = people;
            position = -1;
        }
        public T Current => list[position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            list = new List<T>();
        }

        public bool MoveNext()
        {
            position++;
            return position < list.Count && position >=0;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
