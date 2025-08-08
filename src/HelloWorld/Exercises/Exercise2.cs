using HelloWorld.E2Lib;
using HelloWorld.E3Lib;

namespace HelloWorld.Exercises
{
    /// <summary>
    /// Exercise 2 demonstrates fundamental OOP concepts in C#,
    /// including classes, inheritance, interfaces, and polymorphism.
    /// 
    /// Features:
    /// - Uses abstract classes (Shape, Car, Animal) and inheritance (Circle, Square, GasCar, ElectricCar, Dog, Cat)
    /// - Implements and demonstrates interfaces (IDriveable)
    /// - Shows polymorphism with method overriding and base class references
    /// - Demonstrates encapsulation and composition with a Garage class
    /// - Provides example usage and output for each concept
    /// </summary>
    public static class Exercise2
    {
        public static void Run()
        {
            Console.WriteLine("This is Exercise 2!");

            Car car = new GasCar("Toyota", "Corolla", 2020);
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
            garage.AddCar(car);
            garage.AddCar(eCar);
            garage.Cars[0].DisplayInfo();
            garage.Cars[1].DisplayInfo();
            Console.WriteLine($"Cars in garage: {garage.Cars.Count}");
        }
    }

    

    
}