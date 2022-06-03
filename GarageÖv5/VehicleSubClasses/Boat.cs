using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5.VehicleSubClasses
{
    internal class Boat : Vehicle
    {
        public override string Name { get; } = "Boat";
        public double Length { get; set; }


        public Boat(string color, string licenseNumber, uint amountWheels, uint cylinderVolume, double length) : base(color, licenseNumber, amountWheels, cylinderVolume)  
        {
            Length = length;
        }

        public override string ToString()
        {
            return base.ToString() + $" Length of Boat: {Length} meters";
        }

    }
}
