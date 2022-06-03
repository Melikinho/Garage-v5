using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var car = new Car("Black", "RGN498", 4, 6, Car.FuelType.electric);
            //var bus = new Bus("Yellow", "HMN123", 8, 8, 20);
            //var motorcycle = new Motorcycle("Red", "KLM876", 2, 4, 1.1);
            //var airplane = new Airplane("White", "JHK123", 8, 16, 4);
            //var boat = new Boat("White", "AGM823", 0, 12, 2);

            //Console.WriteLine(car);
            //Console.WriteLine("***************************************************");
            //Console.WriteLine(boat);
            //Console.WriteLine("***************************************************");
            //Console.WriteLine(airplane);
            //Console.WriteLine("***************************************************");
            //Console.WriteLine(bus);
            //Console.WriteLine("***************************************************");
            //Console.WriteLine(motorcycle);  
            var manager = new Manager();
            manager.Start();

        }


    }

}
