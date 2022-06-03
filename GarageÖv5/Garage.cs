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
        internal void Add(T vehicle)
        {
            var myList = new List<T>();
            myList.Add(vehicle);
        }

        internal void Remove(T vehicle)
        {
            var myList = new List<T>();
            myList.Remove(vehicle);

        }

        internal void Park(T vehicle)
        {


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
