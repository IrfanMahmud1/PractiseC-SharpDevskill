using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class NumberEnumerator<T> : IEnumerator<T>
    {
        private List<T> list;
        private int _index;
        public NumberEnumerator(List<T> val)
        {
            list = val;
            _index = -1;
        }
        public T Current => list[_index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            list = new List<T>();
        }

        public bool MoveNext()
        {
            _index++;
            return _index < list.Count && _index >= 0;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
