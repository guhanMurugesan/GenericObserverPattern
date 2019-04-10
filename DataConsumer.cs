using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericObservation
{
    class DataConsumer : IDataConsume
    {

        public DataConsumer()
        {

        }
        public void callback()
        {
            Console.WriteLine("call back recieved");
        }
    }
}
