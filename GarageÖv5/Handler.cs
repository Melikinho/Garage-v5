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
            Console.Clear();
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
                        var (BusColour, busRegistrationNumber, nrwheels, busCylinderVolume) = GetCommons("Bus");
                        vehicle = new Bus(BusColour, busRegistrationNumber, nrwheels, busCylinderVolume, BusSeats());

                        break;
                    case "Boat":
                        var (BoatColour, BoatRegistrationnumber, BoatNrWheels, BoatCylinderVolume) = GetCommons("Boat");
                        vehicle = new Boat(BoatColour, BoatRegistrationnumber, BoatNrWheels, BoatCylinderVolume, BoatLength());
                        double BoatLengthResult = BoatLength();
                        vehicle = new Boat(BoatColour, BoatRegistrationnumber, BoatNrWheels, BoatCylinderVolume, BoatLengthResult);
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
                        UInt32.TryParse(amountWheels, out UInt32 amountWheelsResult);

                        var cylinderVolume = ui.ReadString();
                        UInt32.TryParse(cylinderVolume, out UInt32 cylinderVolumeResult);

                        var TotEngines = ui.ReadString();
                        UInt32.TryParse(TotEngines, out uint TotEnginesResult);

                        vehicle = new Airplane(color, registerNumber, amountWheelsResult, cylinderVolumeResult, TotEnginesResult);
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

        private static uint BusSeats()
        {
            Console.WriteLine("Enter your total seats for your Bus: ");
            var BusSeats = Console.ReadLine();
            UInt32.TryParse(BusSeats, out UInt32 BusSeatsResult);
            return BusSeatsResult;
        }
        private static double BoatLength()
        {
            Console.WriteLine("Enter your Length for your Boat: ");
            var BoatLength = Console.ReadLine();
            double.TryParse(BoatLength, out double BoatLengthResult);
            return BoatLengthResult;
        }

        private (string busColor, string busRegistrationNumber, uint nrwheels, uint busCylinderVolume) GetCommons(string vehicleType)
        {
            ui.Print($"Please Enter your colour for your {vehicleType}: ");
            string BusColour = ReadInput();

            ui.Print($"Please enter your registration number for your {vehicleType}");
            string busRegistrationNumber = ReadInput();

            ui.Print($"Please, enter amount of wheels your {vehicleType} have ");
            string nrwheels = ReadInput();
            uint nrWheelsResult = ParseStringToUInt(nrwheels);

            ui.Print($"Please, enter amount of Cylinder volume the {vehicleType} has ");
            string busCylinderVolume = ReadInput();
            uint busCylinderVolumeResult = ParseStringToUInt(busCylinderVolume);

            //ui.Print($"Please, enter total amount of Seats the {vehicleType} has ");
            //string BusSeats = ReadInput();
            //uint BusSeatsResult = ParseStringToUInt(BusSeats);
            return (BusColour, busRegistrationNumber, nrWheelsResult, busCylinderVolumeResult);

        }

        private uint ParseStringToUInt(string nrwheels)
        {
            UInt32.TryParse(nrwheels, out uint nrWheelsResult);
            return nrWheelsResult;
        }

        private static string ReadInput()
        {
            return Console.ReadLine()!;
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
                ui.Print(" Invalid, Please try again ");
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


        //if..


        //var vehicle1 = new Car...
        //vehicle1.GetType().Name
        //if...


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
        public List<Vehicle> SearchVehicles(uint amountWheels, string colour = "", string vehicleType = "") //Amount ofwheel string?
        {
            IEnumerable<Vehicle> query = garage;
            ArgumentNullException.ThrowIfNull(colour);

            if (!string.IsNullOrWhiteSpace(colour))
            {
                query = query.Where(v => v.Color.ToLower() == colour.ToLower());
                foreach (var vehicle in query)
                {
                    Console.WriteLine("Before:" + garage.Count());
                    Console.WriteLine(vehicle.Color);
                }
            }
            else if (amountWheels > 1)//Ska vi söka eller inte?
            {
                query = query.Where(v => v.AmountWheels == amountWheels);

                foreach (var vehicle in query)
                {
                    Console.WriteLine(vehicle);
                }
            }
            else if (vehicleType == "Car")
            {
                query = query.Where(v => v.LicenseNumber == vehicleType);
                foreach (var vehicle in query)
                {
                    Console.WriteLine(vehicle);
                }
            }
            //if (!string.IsNullOrWhiteSpace(vehicleType))
            //{

            //    query = query.Where(v => v.Name == vehicleType.ToLower());
            //    foreach (var Name in query)
            //    {
            //        Console.WriteLine(Name);
            //    }

            //}
            return query.ToList();
        }

        public void ListTypesInVehicles()
        {
            ui.Print("Please, enter the desired type to print it: ");
            try
            {
                bool running = true;
                if (garage is null)
                    throw new InvalidOperationException("Garage has not been created. Please re-consider your input. ");
                string colour;
                string amountWheels;
                string vehicleType;
                ConsoleKey inputKey;
                    
                    ui.Print("1./ Colour");
                ui.AskForString(colour);

                    ui.Print("2./ Amount of Wheels");
                amountWheels = Console.ReadLine();
                    ui.Print("3./ Vehicle type");
                vehicleType = Console.ReadLine();
                ui.Print("/ press Enter to go back");
                
                string line = Console.ReadLine();
                if(line == "enter")
                {
                    return;
                }
                else
                {
                    ui.Print("Wrong input. Press Enter to return to main menu");
                }
                




                //Om man inte vill söka så skriver man något tecken tex - eller x eller nåt annat

                var result = SearchVehicles(colour, amountWheels, vehicleType);

                foreach(var vehicle in result)
                {
                    Console.WriteLine(vehicle.ToString());
                }
                
                inputKey = new ConsoleKey();

                //    switch (inputKey)

                //    {
                //        case ConsoleKey.D1:
                //            {
                //                ui.Print("Enter colour: ");
                //                colour = Console.ReadLine();
                //                break;
                //            }
                //        case ConsoleKey.D2:
                //            {
                //                ui.Print("Enter amount of wheels: ");
                //                amountWheels = Console.ReadLine();
                //                UInt32.TryParse(amountWheels, out uint amountWheelsResult);
                //                break;

                //            }
                //        case ConsoleKey.D3:
                //            {
                //                ui.Print("Enter Vehicle Type: ");
                //                vehicleType = Console.ReadLine();
                //                break;
                //            }
                //        case ConsoleKey.D4:
                //            {
                //            var query = garage.Where(v => v.Color == colour);

                //            query = query.Where(v => v.AmountWheels > 1);

                //            query = query.Where(v => v.CyliderVolume > 1);

                //            foreach(var item in query)
                //            {

                //            }

                //            break;
                //        }
                //        default:
                //            {
                //                ui.Print("Wrong input. Please re-consinder your input and try again. ");
                //                return;
                //            }
                //        while (inputKey != ConsoleKey.D4);
                //}
            }
            catch
            {
                throw new ArgumentException();


            }
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
