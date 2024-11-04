using ArrayGenerics;

public class Program
{
     static void Main(string[] args)
     {
        ArraysGenerics arrayGen = new ArraysGenerics();
        // Using overloaded methods
        int[] intArray = arrayGen.CreateArray(1, 2);
        double[] doubleArray = arrayGen.CreateArray(3.5, 4.5);
        string[] stringArray = arrayGen.CreateArray("Hello", "World");

        // Displaying results from overloaded methods
        Console.WriteLine("Overloaded methods:");
        Console.WriteLine($"intArray: [{string.Join(", ", intArray)}]");
        Console.WriteLine($"doubleArray: [{string.Join(", ", doubleArray)}]");
        Console.WriteLine($"stringArray: [{string.Join(", ", stringArray)}]");

        // Using the generic method
        int[] genericIntArray = arrayGen.CreateArrayGeneric(5, 6);
        double[] genericDoubleArray = arrayGen.CreateArrayGeneric(7.5, 8.5);
        string[] genericStringArray = arrayGen.CreateArrayGeneric("Foo", "Bar");

        // Displaying results from generic method
        Console.WriteLine("\nGeneric method:");
        Console.WriteLine($"genericIntArray: [{string.Join(", ", genericIntArray)}]");
        Console.WriteLine($"genericDoubleArray: [{string.Join(", ", genericDoubleArray)}]");
        Console.WriteLine($"genericStringArray: [{string.Join(", ", genericStringArray)}]");
    }
}