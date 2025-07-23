using HelloWorld.E3Lib;
using HelloWorld.E2Lib;

namespace HelloWorld.E3Lib
{
    public class CarFactory
    {
        private static readonly string[] Makes = { "Toyota", "Honda", "Ford", "Tesla", "Chevy" };
        private static readonly string[] Models = { "Corolla", "Civic", "F-150", "Model 3", "Bolt" };
        private static readonly Random rng = new Random();

        public static Car createRandomCar()
        {
            string make = Makes[rng.Next(Makes.Length)];
            string model = Models[rng.Next(Models.Length)];
            int year = rng.Next(2000, 2023); // Random year between 2000 and 2022

            if(rng.Next(2) == 0) // Randomly decide to create an ElectricCar or GasCar
            {
                int batteryCapacity = rng.Next(50, 100); // Random battery capacity between 50 and 100 kWh
                return new ElectricCar(make, model, year, batteryCapacity);
            }
            else
            {
                return new GasCar(make, model, year);
            }
        }
    }
}