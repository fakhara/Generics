using Generics;

public class Program
 {
    private static void Main(string[] args)
    {
        var list = new ListOfNumbers<int>();
        list.AddNumber(10);
        list.AddNumber(20);

        Console.WriteLine(list.GetNumber(1));
        Console.WriteLine("Count: " + list.Count);

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