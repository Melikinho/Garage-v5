using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5.VehicleSubClasses
{
    internal class Bus : Vehicle
    {
        public int NumOfSeats
        {
            get; set;
        }
        public override string Name { get; } = "Bus";

        public Bus(string color, string licenseNumber, int amountWheels, int cylinderVolume, int numOfSeats) : base(color, licenseNumber, amountWheels, cylinderVolume)
        {
            Color = color;
            LicenseNumber = licenseNumber;
            AmountWheels = amountWheels;
            CyliderVolume = cylinderVolume;
            NumOfSeats = numOfSeats;

        }
        public override string ToString()
        {
            return base.ToString() + $"Number of Seats: {NumOfSeats}";
        }
    }
}

