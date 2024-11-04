using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     public class PractiseList<T>
     {
        // Generisk lista för att lagra items
        private List<T> items = new List<T>();

        // Metod för att lägga till ett item i listan
        public void AddItem(T item)
        {
            items.Add(item);
        }
        // Metod som returnerar hela listan
        public List<T> GetItems()
        {
            return items;
        }
    }
}
