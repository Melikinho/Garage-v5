using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5.VehicleSubClasses
{
    internal class Motorcycle : Vehicle
    {
        public override string Name { get; } = "Motorcycle";
        public double Length
        {
            get; set;
        }
        public Motorcycle(string color, string licenseNumber, int amountWheels, int cylinderVolume, double length) : base(color, licenseNumber, amountWheels, cylinderVolume)    
        {
            Length = length;
        }

        public override string ToString()
        {
            return base.ToString() + $" Length of MotorCycle: {Length} ";
        }
    }
}
