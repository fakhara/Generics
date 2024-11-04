using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //By using <T> the class can handle any datatype (e.g. int, float, string
    public class ListOfNumbers<T>
    {
        //List<T> replaces the need for manual resizing, as List automatically resizes when new items are added.
        private List<T> _numbers;
        public ListOfNumbers()
        {
            _numbers = new List<T>();
        }

        public void AddNumber(T newNumber)
        {
            _numbers.Add(newNumber);
        }
        // The GetNumber method include a check to ensure that the requested index is valid
        public T GetNumber(int index)
        {
            if(index < 0 || index >= _numbers.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            return _numbers[index];
        }
        public int Count => _numbers.Count;
    }
}
