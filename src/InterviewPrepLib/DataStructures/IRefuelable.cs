namespace InterviewPrepLib.DataStructures
{
    public interface IRefuelable
    {
        void Refuel();
        int FuelLevel { get; }
    }
}