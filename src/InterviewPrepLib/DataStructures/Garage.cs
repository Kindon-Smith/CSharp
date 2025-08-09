using System.Runtime.InteropServices;

namespace InterviewPrepLib.DataStructures
{
    public class Garage
    {
        private List<Car> _cars = new List<Car>();
        public IReadOnlyList<Car> Cars => _cars;

        public void AddCars(List<Car> newCars)
        {
            if (newCars is null)
            {
                throw new ArgumentNullException(nameof(newCars), "New cars list cannot be null.");
            }
            _cars.AddRange(newCars);
        }
        
        public void AddCar(Car car)
        {
            if (car is null)
            {
                throw new ArgumentNullException(nameof(car), "Car cannot be null.");
            }
            _cars.Add(car);
        }
        
    }
}