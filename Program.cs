using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericObservation
{
    class Program
    {
        static void Main(string[] args)
        {
            DataProvider p = new DataProvider();
            p.AddObserver(new DataConsumer());
            p.Notify();
            Console.ReadLine();
        }
    }
}
