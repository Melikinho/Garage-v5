using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5
{
    public class ConsoleUI // : IUI
    {
        public string GetInt()
        {
            throw new NotImplementedException();
        }

        public string GetString()
        {
            throw new NotImplementedException();
        }

        public void PrintMessage(string message)
        {
            throw new NotImplementedException();
        }

        public static void Print(string printedtext) => Console.WriteLine(printedtext);

        public static void Sleep() => Thread.Sleep(3000);

        public static void ColorRed() => Console.ForegroundColor = ConsoleColor.Red;

        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*******WELCOME TO THE GARAGE*******");
            Console.WriteLine("Type 'exit' to quit the program. ");
            Console.WriteLine("Type 'list' to list all parked Vehicles ");
            Console.WriteLine("Type 'listtypes' to list different vehicles parked in the garage ");
            Console.WriteLine("Type 'park' in the console to park your Vehicle ");
            Console.WriteLine("Type 'unpark' to unpark your vehicle from the garage ");
            Console.WriteLine("Type 'search' to find the specific vehicle you are looking for ");
            Console.ResetColor();

        }

    }

   
}
