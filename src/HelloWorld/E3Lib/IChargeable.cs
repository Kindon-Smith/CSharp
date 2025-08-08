namespace HelloWorld.E3Lib
{
    public interface IChargeable
    {
        void Charge();

        int BatteryLevel { get; set; }
    }
}