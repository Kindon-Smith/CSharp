namespace HelloWorld.E2Lib
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }

        public ElectricCar(string make, string model, int year, int batteryCapacity)
            : base(make, model, year)
        {
            BatteryCapacity = batteryCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
        }
    }
}