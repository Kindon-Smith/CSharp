using Xunit;
using HelloWorld.E2Lib;
using HelloWorld.E3Lib;

public class CarTests
{
    [Fact]
    public void GasCar_Refuel_SetsFuelLevelToFull()
    {
        var car = new GasCar("Toyota", "Corolla", 2020);
        car.Refuel();
        Assert.Equal(10, car.FuelLevel); // Adjust if your full level is different
    }

    [Fact]
    public void ElectricCar_Charge_SetsBatteryLevelToFull()
    {
        var car = new ElectricCar("Tesla", "Model 3", 2022, 75);
        car.BatteryLevel = 10;
        car.Charge();
        Assert.Equal(75, car.BatteryLevel);
    }
}
