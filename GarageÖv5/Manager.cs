using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5
{
    internal class Manager
    {
        private ConsoleUI ui;
        private Handler handler;

        public Manager()
        {
            ui = new ConsoleUI();
        }

        internal void Start()
        {
            //Show start meny to set garage capacity
            //Need to set Capacity
            var capacity = 10; //Ska komma från användaren!!!!! Tex ui.AskForInt eller från en Util se Employee projektet
            handler = new Handler(capacity);

            //Nu är garaget skapat med en korrelt storlek
            ShowMainMeny();
            
        }


        private void ShowMainMeny()
        {
            bool run = true;

            while (run)
            {
                ui.ShowMenu();

                string option = Console.ReadLine();

                // switch
                switch (option)
                {
                    case "exit":
                        ConsoleUI.Print("Exiting program");
                        ConsoleUI.Sleep();
                        Handler.Exit();
                        break;
                    case "list":
                        handler.SeedVehicles();
                        break;
                    case "listtypes":
                        break;
                    case "park":
                        break;
                    case "unpark":
                        break;
                    case "search":
                    default:
                        ConsoleUI.ColorRed();
                        ConsoleUI.Print("Wrong input. Pleaase re-consider your input again. ");
                        break;

                }


            }
        } 
    }
}
