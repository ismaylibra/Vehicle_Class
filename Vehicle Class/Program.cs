using System;

namespace Vehicle_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus("Hyundai", "H-1", "White", 200, 12);
            if (string.IsNullOrEmpty(bus.Brand) || string.IsNullOrWhiteSpace(bus.Brand) || string.IsNullOrEmpty(bus.Model) || string.IsNullOrWhiteSpace(bus.Model))
            {
                Console.WriteLine("Car wasn't created");
            }
            else
            {
                Bus bus1 = new Bus();
            }
               
            
            Console.WriteLine(bus.Info());
           
           
            
        }
    }
}
