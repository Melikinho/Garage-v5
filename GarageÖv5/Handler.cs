using GarageÖv5.VehicleSubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GarageÖv5
{
    public class Handler 
    {
        private Garage<Vehicle> garage;
        private uint capacity;
        private readonly ConsoleUI ui;



        public Handler(uint capacity, ConsoleUI ui)
        {
            garage = new Garage<Vehicle>(capacity);
            this.ui = ui;
        }

        private IEnumerable<Vehicle> GetDummyVehicles()
        {
            return new List<Vehicle>()
            {
                new Car("White", "ABC123", 4,34, FuelType.Diesel),
                new Bus("Red", "KLM187", 6, 8, 20),
                new Motorcycle("Black", "JKL987", 2, 4, 1.1),
                new Airplane("White", "HUM372", 6, 18, 4),
                new Boat("Green", "LKJ764", 0, 12, 3.4),
                new Car("Black", "DFE321", 4, 6, FuelType.electric)
            };
        }

        internal void SeedVehicles()
        {
            var vehicles = GetDummyVehicles(); 
            
            foreach (var vehicle in vehicles)
            {
                garage.Park(vehicle);
            }
        }

        public void AddVehicle()
        {
            Console.WriteLine("Park your vehicle: ");
            try
            {
                if (garage is null)
                    throw new InvalidOperationException("Garage is not available. ");

                Console.WriteLine("Please enter your Vehicle Type ");
                var vehicleType = Console.ReadLine();

                Vehicle? vehicle = null;

                switch (vehicleType)
                {
                    case "Bus":
                        Console.WriteLine("Please Enter your colour for your Bus: ");
                        var BusColour = Console.ReadLine();

                        Console.WriteLine("Please Enter your Registration number for your Bus: ");
                        var BusRegistrationNumber = Console.ReadLine();

                        Console.WriteLine("Please Enter amount of wheels your Bus have: ");
                        var BusAmountWheels = Console.ReadLine();
                        UInt32.TryParse(BusAmountWheels, out UInt32 BusAmountWheelsResult);

                        Console.WriteLine("Please enter amount of Cylinder volume your Boat has: ");
                        var BusCylinderVolume = Console.ReadLine();
                        UInt32.TryParse(BusCylinderVolume, out UInt32 BusCylinderVolumeResult);

                        Console.WriteLine("Please enter number of seats for your Bus: ");
                        var BusNumOfSeats = Console.ReadLine();
                        UInt32.TryParse(BusNumOfSeats, out UInt32 BusNumOfSeatsResult);

                        break;
                    case "Boat":
                        Console.WriteLine("Enter yourc Color for Boat: ");
                        var BoatColor = Console.ReadLine();

                        Console.WriteLine("Enter your registration number for your Boat: ");
                        var BoatRegistrationNumber = Console.ReadLine();

                        Console.WriteLine("Enter amount of wheels your Boat have: ");
                        var BoatAmountOfWheels = Console.ReadLine();
                        UInt32.TryParse(BoatAmountOfWheels, out UInt32 BoatAmountOfWheelsResult);

                        Console.WriteLine("Enter your Cylinder Volume for your Boat: ");
                        var BoatCylinderVolume = Console.ReadLine();
                        UInt32.TryParse(BoatCylinderVolume, out UInt32 BoatCylinderVolumeResult);

                        Console.WriteLine("Enter your Length for your Boat: ");
                        var BoatLength = Console.ReadLine();
                        UInt32.TryParse(BoatLength, out UInt32 BoatLengthResult);

                        vehicle = new Boat(BoatColor, BoatRegistrationNumber, BoatAmountOfWheelsResult, BoatCylinderVolumeResult, BoatLengthResult);
                        break;

                    case "Motorcycle":
                        Console.WriteLine("Enter your color for your Motorcycle: ");
                        var MotorCycleColor = Console.ReadLine();

                        Console.WriteLine("Enter your Registration number for your motorcycle: ");
                        var MotorCycleRegistrationNumber = Console.ReadLine();

                        Console.WriteLine("Enter amount of wheels for your motorcycle: ");
                        var MotorCycleAmountOufWheels = Console.ReadLine();
                        UInt32.TryParse(MotorCycleAmountOufWheels, out UInt32 MotorCycleAmountOfWheelsResult);

                        Console.WriteLine("Enter cylinder volume for your motorcycle: ");
                        var MotorCycleCylinderVolume = Console.ReadLine();
                        UInt32.TryParse(MotorCycleCylinderVolume, out UInt32 MotorCycleCylinderVolumeResult);

                        Console.WriteLine("Enter the length of Motorcycle: ");
                        var MotorCycleLength = Console.ReadLine();
                        double.TryParse(MotorCycleLength, out double MotorCycleLengthResult);

                        vehicle = new Motorcycle(MotorCycleColor, MotorCycleRegistrationNumber, MotorCycleAmountOfWheelsResult, MotorCycleCylinderVolumeResult, MotorCycleLengthResult);
                        break;

                    case "Airplane":
                        Console.WriteLine("Enter your color: ");
                        var color = ui.ReadString();

                        Console.WriteLine("Enter your registration number: ");
                        var registerNumber = ui.ReadString();

                        Console.WriteLine("Enter amount of wheels");
                        var amountWheels = ui.ReadString();
                        UInt32.TryParse(amountWheels, out UInt32 amoutWheelsResult);


                        Console.WriteLine("Enter total cylinder volume: ");
                        var cylinderVolume = ui.ReadString();
                        UInt32.TryParse(cylinderVolume, out UInt32 cylinderVolumeResult);

                        Console.WriteLine("Enter total Engines: ");
                        var TotEngines = ui.ReadString();
                        UInt32.TryParse(TotEngines, out uint TotEngines2);

                        vehicle = new Airplane(color, registerNumber, amoutWheelsResult, cylinderVolumeResult, TotEngines2);
                        break;

                    case "Car":

                        Console.WriteLine("Please Enter your color for the car: ");
                        var CarColor = ui.ReadString();

                        Console.WriteLine("Please enter your Registration number for your car: ");
                        var CarRegistrationNumber = ui.ReadString();

                        Console.WriteLine("Please Enter your amount of wheels. ");
                        var CarAmountOfWheels = ui.ReadString();
                        UInt32.TryParse(CarAmountOfWheels, out uint CarAmountOfWheelsResult);

                        Console.WriteLine("Please enter your cylinder volume. ");
                        var CarCylinderVolume = ui.ReadString();
                        UInt32.TryParse(CarCylinderVolume, out uint CarCylinderVolumeResult);

                        Console.WriteLine($"Please Select fuelType: \n 1. Gasoline \n 2. Diesel \n 3. Electric ");

                        var input = Console.ReadKey();
                        FuelType fuelType = FuelType.Gasoline;

                        switch (input.Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                fuelType = FuelType.Gasoline;
                                break;
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                fuelType = FuelType.Diesel;
                                break;
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                fuelType = FuelType.electric;
                                break;
                            default:
                                throw new ArgumentException("Wrong type. Please, re-consider your input. ");
                                break;

                        }
                        vehicle = new Car(CarColor, CarRegistrationNumber, CarAmountOfWheelsResult, CarCylinderVolumeResult, fuelType);
                        break;
                }
                if (!garage.AddVehicle(vehicle))
                    Console.WriteLine("Garage is full. Cannot park vehicle. ");
            }
            catch
            {
                throw new ArgumentException("Wrong input. Please Try again: ");
            }

        }

        private Vehicle? SearchVehicleRegNr()
        {
            Console.WriteLine("Enter your Registration Number to search: ");
            var registrationNumber = Console.ReadLine();
            var vehicle = garage?.FirstOrDefault(v => v.LicenseNumber.ToUpper().Equals(registrationNumber.ToUpper()));

            return vehicle;
        }

        public void DeleteVehicle()
        {
            try
            {
                if (garage is null)
                    throw new ArgumentNullException("Garage not created. ");

                Console.WriteLine("UnPark your vehicle with Registraton number: ");
                var vehicle = SearchVehicleRegNr();

                if (vehicle != null)
                {
                    garage.removeVehicle(vehicle);
                    ui.Print($"You have successfully unparked your vehicle: {vehicle.LicenseNumber} ");
                }    
                else
                {
                    ui.Print("Couldn't park the Vehicle. The following Registration number doesn't exist. ");

                }
            }
        
            catch(InvalidOperationException)
            {
                Console.WriteLine("invalid. Please, try again. ");
            }
        }

        public void ListAllVehicles()
        {
            ui.Print("Print all Vehicles in garage ");

            try
            {
                if (garage is null)
                    throw new InvalidOperationException("Failed. try again!");

                foreach (Vehicle v in garage)
                    ui.Print(v.ToString());
            }


            catch (InvalidOperationException)
            {
                ui.Print(" Invalid ");
            }
        }

        internal void CreateGarage()
        {
            ui.Print("Please, enter to create your new garage: ");
            var capacity = ui.ReadUInt();
            garage = new Garage<Vehicle>(capacity);
            ui.Print("Garage has been created! ");
           
        }

        //public void SearchVehicles(string color)
        //{
        //    ui.Print("Search Vehicles: ");
        //    var result = garage.Where(item => item.Color.ToLower().StartsWith(color.ToLower()));

        //    foreach (var vehicles in result)
        //    {
        //        Console.WriteLine(vehicles.ToString());
        //    }

        //}

        public void ParkVehicles(Vehicle vehicle)
        {
            ui.Print("Please, enter to park your vehicle: ");
            Console.ReadLine();

            if (garage.Park(vehicle))
            {
                ui.Print($"You have been successfully parked your vehicle;  {vehicle.LicenseNumber}");
            }
            else
                {
                    ui.Print($" Garage is full. {vehicle.LicenseNumber}");
                }

        }

        public void ListTypesInVehicles()
        {
            ui.Print("Please, enter the desired type to print all vehicles: ");

        }

        public void UnParkVehicle(string registerNumber)
        {
            ui.Print("Please, enter your desired Vehcile to unpark it: ");
                
            if (garage.UnPark(registerNumber))
                {
                    Console.WriteLine($"You have been successfully parked your vehicle. {registerNumber}");
                }
                else
                {
                    Console.WriteLine($"Unable to park vehicle: {registerNumber}");
                }
        }



        public void Exit()
        {
            ui.Print("Exiting program");
            ui.Print("3...2.....1....");
            Environment.Exit(0);
        }
    }
}
