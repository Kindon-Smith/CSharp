using InterviewPrepLib.DataStructures;

namespace Datastructures.Tests;

public class GarageTests
{
    [Fact]
    public void Adding_Car_To_Garage_Increases_Car_Count()
    {
        var newCar = new GasCar("Toyota", "Tundra", 2001);
        var newGarage = new Garage();
        Assert.Empty(newGarage.Cars);
        newGarage.AddCar(newCar);
        Assert.Single(newGarage.Cars);
    }
}