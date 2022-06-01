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
        public int Length { get; set; }


        public Boat(string color, string licenseNumber, int amountWheels, int cylinderVolume, int length) : base(color, licenseNumber, amountWheels, cylinderVolume)  
        {
            this.Length = length;
        }

        public override string ToString()
        {
            return base.ToString() + $" Length of Boat: {Length}";
        }

    }
}
