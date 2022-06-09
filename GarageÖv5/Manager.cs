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
            ui.Print("How long is your garage?");
            var size = ui.AskForUInt();
            //Ska komma från användaren!!!!! Tex ui.AskForInt eller från en Util se Employee projektet

            //Handler handler = new();
            handler = new Handler(size, ui);

            //Nu är garaget skapat med en korrelt storlek

            ShowMainMeny();
            
        }
        private void ShowMainMeny()
        {
            bool running = true;

            while (running!)
            {
                ui.ShowMenu();
                string option;
                option = ui.ReadString();
                UInt32.TryParse(option, out uint result);

                switch (option)
                {
                    case "0":
                        handler.Exit();
                        ui.Sleep();
                        break;
                    case "1":
                        handler.CreateGarage();
                        break;
                    case "2":
                        handler.SeedVehicles();
                        handler.ListAllVehicles();
                        break;
                    case "3":
                        handler.ListTypesInVehicles();
                        break;
                    case "4":
                        handler.AddVehicle();
                        break;
                    case "5":
                        handler.DeleteVehicle();
                        break;
                    case "6":
                        handler.ListTypesInVehicles();
                        break;
                    default:
                        ui.ColorRed();
                        ui.Print("Wrong input. Pleaase re-consider your input again. ");
                        Console.ResetColor();
                        break;

                }


            }
        } 
    }
}
