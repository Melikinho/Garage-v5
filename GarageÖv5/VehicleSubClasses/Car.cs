using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5.VehicleSubClasses
{
    public partial class Car : Vehicle
    {
        public override string Name { get; } = "Car";
        public FuelType fuelType
        {
            get; set;
        }
        
        public Car(string color, string licenseNumber, uint amountWheels, uint cyliderVolume, FuelType fuelType = FuelType.Gasoline) : base(color, licenseNumber, amountWheels, cyliderVolume)
        {
            this.fuelType = fuelType;
        }

        public override string ToString()
        {
            return base.ToString() + $"The Fueltype is:  {fuelType}";
        }
    }
}
