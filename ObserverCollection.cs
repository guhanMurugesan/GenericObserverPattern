using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericObservation
{
    class ObserverCollection:List<IDataConsume>,IDataConsume
    {

        public void callback()
        {
            foreach (var item in this)
            {
                item.callback();
            }
        }
    }
}
