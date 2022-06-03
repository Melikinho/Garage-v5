using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5.VehicleSubClasses
{
    internal class Bus : Vehicle
    {
        public uint NumOfSeats
        {
            get; set;
        }
        public override string Name { get; } = "Bus";

        public Bus(string color, string licenseNumber, uint amountWheels, uint cylinderVolume, uint numOfSeats) : base(color, licenseNumber, amountWheels, cylinderVolume)
        {
            NumOfSeats = numOfSeats;

        }
        public override string ToString()
        {
            return base.ToString() + $"Number of Seats: {NumOfSeats} seats ";
        }
    }
}

