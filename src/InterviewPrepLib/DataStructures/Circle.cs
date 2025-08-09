namespace InterviewPrepLib.DataStructures
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}