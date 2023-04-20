using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());
            Lasseries.muestra(num);
            Console.ReadKey();

        }

    }
}
