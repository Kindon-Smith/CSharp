using InterviewPrepLib.Algorithms;
using InterviewPrepLib.DataStructures;

namespace HelloWorld.Exercises
{
    /// <summary>
    /// Exericse 3: LINQ and Collections
    /// 
    /// Features:
    /// - Populates a garage with randomly generated gas and
    ///   electric cars
    /// - Demonstrates filtering, sorting, and aggregation 
    ///   using LINQ
    ///       - Lists all cars, electric cars, and gas cars
    ///       - Sorts gas cars by year
    ///       - Aggregates cars by make and counts them
    ///       - Finds the newest car in the garage
    ///       - Finds a random model in the garage, lists all cars
    ///         that match
    /// </summary>
    public static class Exercise3
    {

        public static void Run()
        {
            // Create a garage and populates it with random cars
            var garage = new Garage();
            var garage2 = new Garage();

            for (int i = 0; i < 10; i++)
            {
                garage.AddCar(CarFactory.createRandomCar());
                // Console.WriteLine($"Added car {i + 1} to the garage.");
            }

            // Two ways to display info for all cars.
            // Standard C#:
            //      foreach (var car in garage.Cars)
            //      {
            //          car.DisplayInfo();
            //      }
            // Using LINQ:
            //      garage.Cars.ToList().ForEach(car => car.DisplayInfo());

            // Find all electric cars in the garage with LINQ
            var electricCars = garage.Cars.OfType<ElectricCar>().ToList();
            //electricCars.ForEach(ec => ec.DisplayInfo());
            Console.WriteLine($"");
            // OR
            // var electricCars2 = garage.Cars.Where(car => car is ElectricCar).ToList();
            // both yield the same result and use LINQ, one using 'OfType' and the other using 'Where'.

            // Same for gas cars.
            var gasCars = garage.Cars.OfType<GasCar>().ToList();
            //gasCars.ForEach(gc => gc.DisplayInfo());
            Console.WriteLine($"");
            var carsSortedByYear = garage.Cars.OrderBy(car => car.GetYear()).ToList();
            // Display the sorted cars
            //carsSortedByYear.ForEach(car => car.DisplayInfo());
            Console.WriteLine($"");


            // var gasCarsSortedByYear = gasCars.OrderBy(car => car.GetYear()).ToList();
            // OR
            var gasCarsSortedByYear = garage.Cars
                .OfType<GasCar>()
                .OrderBy(car => car.GetYear())
                .ToList();
            // Display the sorted gas cars
            gasCarsSortedByYear.ForEach(car => car.DisplayInfo());

            // Aggregation, getting counts of cars by Make    
            var carsByMake = garage.Cars
                .GroupBy(c => c.Make)
                .Select(g => new { Make = g.Key, Count = g.Count() });

            foreach (var group in carsByMake)
            {
                Console.WriteLine($"{group.Make} : {group.Count} car(s)");
            }

            var newestCar = garage.Cars.OrderByDescending(c => c.GetYear()).FirstOrDefault();
            Console.Write($"Newest Car is: ");
            if (newestCar is not null)
            {
                newestCar.DisplayInfo();
            }
            else
            {
                Console.WriteLine("No cars in the garage.");
            }

            Random rng = new Random();


            string modelToFind = garage.Cars[rng.Next(garage.Cars.Count)].Model;

            var matchingCars = garage.Cars.Where(c => c.Model.Equals(modelToFind)).ToList();

            if (matchingCars is not null && matchingCars.Count > 0)
            {
                Console.WriteLine($"Cars matching model '{modelToFind}' in the garage:");
                matchingCars.ForEach(car => car.DisplayInfo());
            }
            
        }
    }
}