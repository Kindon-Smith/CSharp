using HelloWorld.E3Lib;

namespace HelloWorld.E2Lib
{
    public class ElectricCar : Car, IChargeable
    {
        private int _batteryCapacity;
        public int BatteryCapacity
        {
            get => _batteryCapacity;
            set => _batteryCapacity = Math.Clamp(value, 1, 200);
        }
        public int BatteryLevel { get; set; }

        public ElectricCar(string make, string model, int year, int batteryCapacity)
            : base(make, model, year)
        {
            BatteryCapacity = batteryCapacity;
            BatteryLevel = 100; // Default battery level
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
        }

        public void Charge()
        {
            // Implementation for charging the electric car
            BatteryLevel = BatteryCapacity; // Reset battery level to full
            Console.WriteLine($"Charging the {Make} {Model}. Battery level is now {BatteryLevel}%.");
        }

        public override void TopUp()
        {
            Charge();
        }

        public override void Drive()
        {
            if (BatteryLevel <= 20)
            {
                Console.WriteLine($"Cannot drive {Make} {Model}. Battery is empty.");
                return;
            }
            else
            {
                BatteryLevel -= 20; // Simulate battery consumption
                Console.WriteLine($"Driving {Make} {Model}. Battery level is now {BatteryLevel}%.");
            }
        }
        
    }
}