using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Class
{
    class Bus: Vehicle
    {
        public byte PassengerCount;

        public Bus()
        {
        }

        public Bus(string brand, string model, string colour, byte maxSpeed, byte passengerCount) : base(brand,model,colour,maxSpeed)
        {
            PassengerCount = passengerCount;
        }
       
        public override string Info()
        {
            if (string.IsNullOrEmpty(Brand) || string.IsNullOrWhiteSpace(Brand)|| string.IsNullOrEmpty(Model) || string.IsNullOrWhiteSpace(Model))
            {
                return $"Vehicle not found";
            }
            else
            {
                return $"Brand: {Brand} \nModel: {Model} \nColor: {Colour} \nMax Speed: {MaxSpeed} \nPassenger Capacity: {PassengerCount}";

            }
        }
       
        
        
    }
}
