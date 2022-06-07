using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5
{
    class Garage<T> : IEnumerable<T> where T : Vehicle
    {

        private T[] vehicles;
        public Garage(uint capacity)
        {
            //Validate capacity!!!!
            vehicles = new T[capacity];
        }
        //Add metod

        //Remove metod

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in vehicles)
            {
                if ( item != null)
                    yield return item;

            }
            yield break;
        }
        internal bool AddVehicle(T newVehicle)
        {
            bool full = vehicles.All(v => v != null);
            if (full) return false;
            vehicles[vehicles.ToList().IndexOf(vehicles.First(v => v is null))] = newVehicle;
            return true;

        }

        public bool UnPark(string registerNumber)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].LicenseNumber == registerNumber)
                {
                    vehicles[i] = default(T);
                    return true;
                }
            }
            return false;
        }

        public bool Park(T vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is null)
                {
                    vehicles[i] = vehicle;
                    return true;

                }
            }
            return false;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
