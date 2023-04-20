using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Lasseries
    {
        public static void muestra(int n)
        {
            int fac = 1;
            string s1 = "Serie1:";
            string s2 = "Serie2:";

            for (int i = 2; i <= n; i++)
            {
                fac *= i;
                s1 += "," + fac.ToString();

                if (i <= n)
                {
                    int pt = (int)Math.Pow(2, i - 1);
                    s2 += pt.ToString() + ",";
                }
            }

            Console.WriteLine(s1);
            Console.WriteLine(s2.Substring(0, s2.Length - 1));
        }

    }
}
