using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5
{
    public abstract class Vehicle
    {
        public abstract string Name { get; }
        public string Color { get; set; }
        
        public string LicenseNumber { get; set; }
        
        public int AmountWheels { get; set; }   

        public int CyliderVolume { get; set;  }

        public Vehicle(string color, string licenseNumber, int amountWheels, int cyliderVolume)
        {
            Color = color;
            LicenseNumber = licenseNumber;
            AmountWheels = amountWheels;
            CyliderVolume = cyliderVolume;
        }

        public override string ToString()
        {
            return base.ToString() + $"Vehicle type: {Name} Color: {Color} Registration Number: {LicenseNumber} Amount of Wheels: {AmountWheels} Amount of Cylinder Volume: {CyliderVolume}";
        }
    }
}
