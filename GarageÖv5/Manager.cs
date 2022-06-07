using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5
{
    internal class Manager
    {
        private readonly ConsoleUI ui;
        private Handler handler;

        public Manager()
        {
            ui = new ConsoleUI();
        }

        internal void Start()
        {
            ConsoleUI ui = new();

            //Show start meny to set garage capacity
            //Need to set Capacity
            uint capacity;
            ui.AskForUInt();
            //Ska komma från användaren!!!!! Tex ui.AskForInt eller från en Util se Employee projektet

            //Handler handler = new();
            handler = new Handler(10, ui);

            //Nu är garaget skapat med en korrelt storlek
            ShowMainMeny();
            
        }


        private void ShowMainMeny()
        {
            bool running = true;

            while (running)
            {
                string option;
                option = Console.ReadLine();

                switch (option)
                {
                    case "creategarage":
                        handler.CreateGarage();
                        break;

                    case "exit":
                        ui.Sleep();
                        handler.Exit();
                        break;
                    case "list":
                        handler.SeedVehicles();
                        break;
                    case "listtypes":
                        handler.ListTypesInVehicles();
                        break;
                    case "park":
                        handler.AddVehicle();
                        break;
                    case "unpark":
                        handler.DeleteVehicle();
                        break;
                    case "search":
                        //handler.SearchVehicles();
                        break;
                    case "print":
                        handler.ListAllVehicles();
                        break;
                    default:
                        ui.ColorRed();
                        ui.Print("Wrong input. Pleaase re-consider your input again. ");
                        break;

                }


            }
        } 
    }
}
