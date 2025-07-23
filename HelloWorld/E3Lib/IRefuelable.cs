namespace HelloWorld.E3Lib
{
    public interface IRefuelable
    {
        void Refuel();
        int FuelLevel { get; }
    }
}