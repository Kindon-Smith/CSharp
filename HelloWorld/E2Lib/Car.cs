namespace HelloWorld.E2Lib
{
    public class Car : IDriveable
    {
        public string Make { get; set; }
        public string Model { get; set; }
        private int _year;

        public int GetYear()
        {
            return _year;
        }
        public int SetYear(int year)
        {
            if (year < 1886) // The first car was invented in 1886
            {
                throw new ArgumentException("Year cannot be before the invention of the car.");
            }
            _year = year;
            return _year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Car Make: {Make}, Model:{Model}, Year: {GetYear()}");
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            SetYear(year);
        }
        
        public virtual void Drive()
        {
            Console.WriteLine($"Driving a {Make} {Model} from {GetYear()}.");
        }
    }
}