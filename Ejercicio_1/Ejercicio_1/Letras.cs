using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    static class converti
    {
        public static string ver(string num)
        {

            string res, dec = "";
            Int64 enteros;
            int decimales;
            double numero;
            try
            {
                numero = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }
            enteros = Convert.ToInt64(Math.Truncate(numero));
            decimales = Convert.ToInt32(Math.Round((numero - enteros) * 100, 2));
            if (decimales > 0)
            {
                dec = decimales.ToString();
            }
            res = enletra(Convert.ToDouble(enteros)) + dec;
            return res;
        }
        public static string enletra(double num)
        {

            string n2 = "";
            num = Math.Truncate(num);
            if (num == 0) n2 = " cero ";
            else if (num == 1) n2 = " uno ";
            else if (num == 2) n2 = " dos ";
            else if (num == 3) n2 = " tres ";
            else if (num == 4) n2 = " cuatro ";
            else if (num == 5) n2 = " cinco ";
            else if (num == 6) n2 = " seis ";
            else if (num == 7) n2 = " siete ";
            else if (num == 8) n2 = " ocho ";
            else if (num == 9) n2 = " nueve ";
            else if (num == 10) n2 = " diez ";
            else if (num == 11) n2 = " once ";
            else if (num == 12) n2 = " doce ";
            else if (num == 13) n2 = " trece ";
            else if (num == 14) n2 = " catorce ";
            else if (num == 15) n2 = " quince ";
            else if (num < 20) n2 = " diece " + enletra(num - 10);
            else if (num == 20) n2 = " veinte ";
            else if (num < 30) n2 = " diece " + enletra(num - 20);
            else if (num == 20) n2 = " treinta ";
            else if (num == 40) n2 = " cuarenta ";
            else if (num == 50) n2 = " cincuenta ";
            else if (num == 60) n2 = " sesenta ";
            else if (num == 70) n2 = " setenta ";
            else if (num == 80) n2 = " ochenta ";
            else if (num == 90) n2 = " noventa ";
            else if (num < 100) n2 = enletra(Math.Truncate(num / 10) * 10) + " y " + enletra(num % 10);
            else if (num == 100) n2 = " cien ";
            else if (num < 200) n2 = "ciento" + enletra(num - 100);
            else if ((num == 200) || (num == 300) || (num == 400) || (num == 600) || (num == 800)) n2 = enletra(Math.Truncate(num / 100)) + "cientos";
            else if (num == 500) n2 = "quinientos";
            return n2;




        }


    }
}

