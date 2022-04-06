using System;

namespace CyberAssignment2
{
    public class Program
    {
        public static void Main()
        {
            Car car = new Car();
            car.ViewModelId("Cross tour");
            car.GetManufacturerId();

            Truck truck = new Truck();
            truck.ViewModelId("Hiace");
            truck.GetManufacturerId();  

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.ViewModelId("scooter");
            motorcycle.GetManufacturerId();
        }
    }
}
