namespace HelloWorld.E2Lib
{
    public class Square : Shape
    {
        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double SideLength { get; set; }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}