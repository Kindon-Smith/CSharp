using HelloWorld.E2Lib;

namespace HelloWorld.Exercises
{
    public static class Exercise2
    {
        public static void Run()
        {
            Console.WriteLine("This is Exercise 2!");

            Car car = new Car("Toyota", "Corolla", 2020);
            car.DisplayInfo();

            ElectricCar eCar = new ElectricCar("Tesla", "Model 3", 2022, 75);
            eCar.DisplayInfo();

            Animal dog = new Dog();
            Animal cat = new Cat();
            Cat cat2 = new Cat();
            // Animal otter = new Animal(); does not work because Animal is abstract
            dog.Speak();
            cat.Speak();
            cat2.Speak();

            Circle circle = new Circle(5);
            Square square = new Square(4);

            Console.WriteLine($"Circle Area: {circle.GetArea()}");
            Console.WriteLine($"Square Area: {square.GetArea()}");

            Garage garage = new Garage();
            garage.AddCars(new List<Car> { car });
            Console.WriteLine($"Cars in garage: {garage.Cars.Count}");
        }
    }

    

    
}