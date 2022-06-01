using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖv5
{
    class Garage<T> : IGarage<T>
    {
        public Garage()
        {

        }
        public IEnumerator<T> GetEnumerator()
        {
            //ToDo
            yield break;
        }

    }
}
