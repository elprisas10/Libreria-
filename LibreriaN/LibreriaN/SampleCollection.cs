using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaN
{
    public class SampleCollection
    {
        public static void ListCollection()
        {

            List<object> lst = new List<object>();


            var rs = "s";
            while (rs == "s")
            {
                Console.Write("Escriba el elemento a agregar en la lista: ");
                var element = Console.ReadLine();


                lst.Add(element);


                Console.Write("\nDesea agregar otro elemento? S/N ");
                rs = Console.ReadLine();
            }

            {

                Console.WriteLine("\n------------Elementos en la lista----------");
                for (int i = 0; i < lst.Count; i++)
                {
                    Console.WriteLine("Elemento {0}: {1}", i, lst[i]);
                }

            }
        }
    }
}

