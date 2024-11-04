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
        private List<T> numbers;
        public ListOfNumbers()
        {
            numbers = new List<T>();
        }

        public void AddNumber(T newNumber)
        {
            numbers.Add(newNumber);
        }
        // The GetNumber method include a check to ensure that the requested index is valid
        public T GetNumber(int index)
        {
            if(index < 0 || index >= numbers.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            return numbers[index];
        }
        public int Count => numbers.Count;
    }
}
