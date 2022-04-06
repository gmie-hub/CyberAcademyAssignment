using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberAssignment2
{
    public class Vehicle
    {
        public string manufacturerId = "Honda";
        
        public void ViewModelId(string modelId)
        {
            Console.WriteLine("This is a {0}", modelId);
        }
        
    }

    public class Car : Vehicle
    {
        public string modelId = "Car";

        public void GetManufacturerId()
        {
            Console.WriteLine("Model: {0}", manufacturerId);
        }
    }

    public class Truck : Vehicle
    {
        public string modelId = "Truck";

        public void GetManufacturerId()
        {
            Console.WriteLine("Model: {0}", manufacturerId);
        }
    }

    public class Motorcycle : Vehicle
    {
        public string modelId = "Motorcycle";

        public void GetManufacturerId()
        {
            Console.WriteLine("Model: {0}", manufacturerId);
        }
    }

}
