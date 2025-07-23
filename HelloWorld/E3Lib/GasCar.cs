using HelloWorld.E2Lib;

namespace HelloWorld.E3Lib
{
    public class GasCar : Car, IDriveable, IRefuelable
    {
        public GasCar(string make, string model, int year)
            : base(make, model, year)
        {
            FuelLevel = 10; // Default fuel level in gallons
        }

        public int FuelLevel { get; private set; }

        public void Refuel()
        {
            // Implementation for refueling the gas car
            FuelLevel = 10; // Reset fuel level to full in gallons
            Console.WriteLine($"Refueling the {Make} {Model}.");
        }

        public override void TopUp()
        {
            Refuel();
        }

        public override void Drive()
        {
            if (FuelLevel <= 1){
                Console.WriteLine($"Cannot drive {Make} {Model}. Fuel is low: {FuelLevel} gallon(s).");
                return;
            }
            else
            {
                FuelLevel -= 1; // Simulate fuel consumption
                Console.WriteLine($"Driving {Make} {Model}. Fuel level is now {FuelLevel} gallon(s).");
            }
        }
    }
}