using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaN;

namespace LibreriaUsoN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione un elemento: ");
            Console.WriteLine("1. Crear Lista: ");


            var response = Console.ReadLine();

            if (response == "1")
            {
                SampleCollection.ListCollection();
                Console.ReadKey();
            }
        }
    }
}
