using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5
{
    public class ConsoleUI // : IUI
    {
        public string ReadString() => Console.ReadLine() ?? String.Empty;

        //public static uint ReadUInt()
        //{
        //    var input = ReadString();
        //    if (uint.TryParse(input, out uint result))
        //        return result;
        //    else
        //        throw new ArgumentException("Wrong input");
        //}

        public uint AskForUInt()
        {
            var input = ReadString();
            if (uint.TryParse(input, out uint result))
                return result;
            else
                throw new ArgumentException("Wrong number. Needs to be 'Uint'. ");;
        }

        public uint ReadUInt()
        {
            var input = ReadString();
            if (uint.TryParse(input, out uint result))
                return result;
            else
                throw new ArgumentException("Wrong input. Please try again. "); 

        }
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

        public void Print(string printedtext) => Console.WriteLine(printedtext);

        public void Sleep() => Thread.Sleep(3000);

        public void ColorRed() => Console.ForegroundColor = ConsoleColor.Red;


        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*******WELCOME TO THE GARAGE*******");
            Console.WriteLine("Type 'exit' to quit the program. ");
            Console.WriteLine("Type 'create' to generate a new garage. ");
            Console.WriteLine("Type 'list' to list all parked Vehicles ");
            Console.WriteLine("Type 'listtypes' to list different vehicles parked in the garage ");
            Console.WriteLine("Type 'park' in the console to park your Vehicle ");
            Console.WriteLine("Type 'unpark' to unpark your vehicle from the garage ");
            Console.WriteLine("Type 'search' to find the specific vehicle you are looking for ");
            Console.ResetColor();

        }
    }


}
