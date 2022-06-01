﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5.VehicleSubClasses
{
    internal class Airplane : Vehicle
    {
        public int NumOfEngines
        {
            get; set;
        }
        public override string Name { get; } = "Airplane";

        public Airplane(string color, string licenseNumber, int amountWheels, int cylinderVolume, int numOfEngines) : base(color, licenseNumber, amountWheels, cylinderVolume)
        {
            NumOfEngines = numOfEngines;
        }

        public override string ToString()
        {
            return base.ToString() + $" Number Of Engines: {NumOfEngines}";
        }
    }
}
