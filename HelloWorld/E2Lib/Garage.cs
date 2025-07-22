using System.Runtime.InteropServices;

namespace HelloWorld.E2Lib
{
    public class Garage
    {
        private List<Car> _cars = new List<Car>();
        public List<Car> Cars { get { return new List<Car>(_cars); } }

        public void AddCars(List<Car> newCars){
            _cars.AddRange(newCars);
        }
        
    }
}