using GarageÖv5.VehicleSubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GarageÖv5.VehicleSubClasses.Car;

namespace GarageÖv5
{
    internal class Handler
    {
        private Garage<Vehicle> garage;

        public Handler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
        }

        internal void SeedVehicles()
        {
            var vehicles = GetDummyVehicles(); 
            
            foreach (var vehicle in vehicles)
            {
                garage.Park(vehicle);
            }
        }

        private IEnumerable<Vehicle> GetDummyVehicles()
        {
            return new List<Vehicle>()
            {
                new Car("White", "ABC123", 4,34, FuelType.Diesel),
                new Bus("Red", "KLM187", 6, 8, 20),
                new Motorcycle("Black", "JKL987", 2, 4, 1.1)
            };
        }
        public static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
