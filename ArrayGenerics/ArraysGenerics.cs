using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGenerics
{
     public class ArraysGenerics
     {
        // Overloaded method to create an int array
        public int[] CreateArray(int a, int b)
        {
            return new int[] { a, b };
        }

        // Overloaded method to create a double array
        public double[] CreateArray(double a, double b)
        {
            return new double[] { a, b };
        }

        // Overloaded method to create a string array
        public string[] CreateArray(string a, string b)
        {
            return new string[] { a, b };
        }
        // Generic method to create an array of any type
        public T[] CreateArrayGeneric<T>(T a, T b)
        {
            return new T[] { a, b };
        }
    }
}
