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

    [Theory]
    [InlineData("Toyota", "Corolla", 2020)]
    [InlineData("Honda", "Civic", 2019)]
    public void GasCar_Create_ValidInputs_CreatesGasCar(string make, string model, int year)
    {
        var car = new GasCar(make, model, year);
        Assert.Equal(make, car.Make);
        Assert.Equal(model, car.Model);
        Assert.Equal(year, car.GetYear());
    }

    [Theory]
    [InlineData("Toyota", "Corolla", 1800)] // Invalid year
    [InlineData("Honda", "Civic", 1885)] // Year before first
    public void GasCar_Create_InvalidYear_ThrowsException(string make, string model, int invalidYear)
    {
        Assert.Throws<ArgumentException>(() => new GasCar(make, model, invalidYear));
    }

    [Fact]
    public void GasCar_ValidYear()
    {
        var car = new GasCar("Ford", "F-150", 2021);
        Assert.Equal(2021, car.GetYear());
    }

    [Fact]
    public void GasCar_DisplayInfo_WritesExpectedOutput()
    {
        var car = new GasCar("Ford", "F-150", 2021);
        var originalOut = Console.Out;
        using (var sw = new StringWriter())
        {
            try
            {
                Console.SetOut(sw);
                car.DisplayInfo();
                var output = sw.ToString().Trim();
                Assert.Equal("Car Make: Ford | Model:F-150 | Year: 2021", output);
            }
            finally
            {
                Console.SetOut(originalOut);
            }
        }
    }

    [Fact]
    public void ElectricCar_Charge_SetsBatteryLevelToFull()
    {
        var car = new ElectricCar("Tesla", "Model 3", 2022, 75);
        car.BatteryLevel = 10;
        car.Charge();
        Assert.Equal(75, car.BatteryLevel);
    }

    [Fact]
    public void ElectricCar_Drive_LowBattery_CannotDrive()
    {
        var car = new ElectricCar("Tesla", "Model 3", 2022, 75);
        car.BatteryLevel = 10; // Low battery
        var originalOut = Console.Out;

        using (var sw = new StringWriter())
        {
            try
            {
                Console.SetOut(sw);
                car.Drive();
                var output = sw.ToString().Trim();
                Assert.Equal("Cannot drive Tesla Model 3. Battery is empty.", output);
            }
            finally
            {
                Console.SetOut(originalOut);
            }
        }
    }

    
}
