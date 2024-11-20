using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class People<T> : IEnumerable<T>
    {
        private List<T> people;

        public People()
        {
            people = new List<T>();
        }
        public void Add(T p)
        {
            people.Add(p);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new PeopleEnumerator<T>(people);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
