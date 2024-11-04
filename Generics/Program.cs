using Generics;

public class Program
 {
    private static void Main(string[] args)
    {
        // Skapa ett PractiseList<int> objekt
        PractiseList<int> intList = new PractiseList<int>();

        // Fyll listan med minst 3 items
        intList.AddItem(5);
        intList.AddItem(10);
        intList.AddItem(15);

        // Hämta och skriv ut samtliga items i intList
        List<int> items = intList.GetItems();
        Console.WriteLine("Items in intList:");
        foreach (int item in items)
        {
            Console.WriteLine(item);
        }

        // Skapa ett PractiseList<string> objekt
        PractiseList<string> stringList = new PractiseList<string>();
        
        // Fyll listan med minst 5 items
        stringList.AddItem("Apple");
        stringList.AddItem("Banana");
        stringList.AddItem("Cherry");
        stringList.AddItem("Date");
        stringList.AddItem("Elderberry");

        // Hämta och skriv ut det tredje item i stringList
        List<string> items1 = stringList.GetItems();
        Console.WriteLine("Det tredje item i stringList är:");
        if (items1.Count >= 3)
        {
            Console.WriteLine(items1[2]); // Index 2 motsvarar det tredje elementet
        }
        else
        {
            Console.WriteLine("Listan har färre än tre items.");
        }


        /* var list = new ListOfNumbers<int>();
         list.AddNumber(10);
         list.AddNumber(20);

         Console.WriteLine(list.GetNumber(1));
         Console.WriteLine("Count: " + list.Count);*/

        // Step 2: Create a List<Car> with at least 4 cars
        List<Car> cars = new List<Car>
        {
            new Car("Toyota"),
            new Car("Honda"),
            new Car("Ford"),
            new Car("BMW")
        };
        // Step 3: Remove the third car in the list
                cars.RemoveAt(2);

        // Step 4: Add a new car at the third position
                 cars.Insert(2, new Car("Mercedes"));

        // Step 5: Attempt to drive the first car in the list (should not work due to no fuel).
                 cars[0].Drive();

        // Step 6: Refuel the first car in the list.
                 cars[0].Refuel();

        // Step 7: Attempt to drive the first car again (should work now).
                 cars[0].Drive();
    }
}