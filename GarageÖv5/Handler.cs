using GarageÖv5.VehicleSubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GarageÖv5
{
    internal class Handler
    {
        private Garage<Vehicle> garage;
        private uint capacity;

        public Handler(uint capacity)
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

        internal void AddVehicles()
        {
            ConsoleUI.Print("Park your Vehicle");



        }

        internal void CreateGarage()
        {
            var capacity = ConsoleUI.ReadUInt();
            garage = new Garage<Vehicle>(capacity);
            ConsoleUI.Print("Garage has been created! ");
           
        }

        internal void SearchVehicles()
        {
            ConsoleUI.Print("Search Vehicles: ");

        }

        internal void ParkVehicles()
        {
            ConsoleUI.Print("Please, enter to park your vehicle: ");

        }

        internal void ListTypesInVehicles()
        {
            ConsoleUI.Print("Please, enter the desired type to print all vehicles: ");

        }

        internal void UnParkVehicle()
        {
            ConsoleUI.Print("Please, enter your desired Vehcile to unpark it: ");
        }
        private IEnumerable<Vehicle> GetDummyVehicles()
        {
            return new List<Vehicle>()
            {
                new Car("White", "ABC123", 4,34, Car.FuelType.Diesel),
                new Bus("Red", "KLM187", 6, 8, 20),
                new Motorcycle("Black", "JKL987", 2, 4, 1.1)
            };
        }
        public static void Exit()
        {
            ConsoleUI.Print("Exiting program");
            ConsoleUI.Print("3...2.....1....");
            Environment.Exit(0);
        }
    }
}
