namespace InterviewPrepLib.DataStructures
{
    public interface IChargeable
    {
        void Charge();

        int BatteryLevel { get; set; }
    }
}