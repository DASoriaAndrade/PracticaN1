using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Mascota_adoptada> listaMascotas = new List<Mascota_adoptada>();
            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_Mascota="Kira",
                edad=2,
                Raza="Pastor_Aleman",
                sexo="Hembra",
                Nombre_Dueño="Juan",
                Pago_Mascota=300
            });

            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Sasi",
                edad = 2,
                Raza = "Pastor_Ingles",
                sexo = "Hembra",
                Nombre_Dueño = "Gisel",
                Pago_Mascota = 500
            });

            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Niki",
                edad = 3,
                Raza = "Chihuaha",
                sexo = "Hembra",
                Nombre_Dueño = "Emely",
                Pago_Mascota = 350
            });

            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Cobo",
                edad = 2,
                Raza = "grandanez",
                sexo = "Macho",
                Nombre_Dueño = "Carlos",
                Pago_Mascota = 200
            });

            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Cacho",
                edad = 4,
                Raza = "Chapi",
                sexo = "Macho",
                Nombre_Dueño = "German",
                Pago_Mascota = 150
            });

            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Dalla",
                edad = 1,
                Raza = "Boxer",
                sexo = "Hembra",
                Nombre_Dueño = "Miguel",
                Pago_Mascota = 600
            });

            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Nacho",
                edad = 2,
                Raza = "PequinesAlbino",
                sexo = "Macho",
                Nombre_Dueño = "Andrea",
                Pago_Mascota = 400
            });

            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Lucas",
                edad = 5,
                Raza = "Pastor_Aleman",
                sexo = "Macho",
                Nombre_Dueño = "Maria",
                Pago_Mascota = 250
            });

            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Goldi",
                edad = 2,
                Raza = "Sanbernado",
                sexo = "Hembra",
                Nombre_Dueño = "Guisel",
                Pago_Mascota = 550
            });

            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_Mascota = "Nena",
                edad = 2,
                Raza = "Pequines",
                sexo = "Hembra",
                Nombre_Dueño = "Melany",
                Pago_Mascota = 250
            });
            mostrarlista(listaMascotas);
            Double PromMascota = getPromedio(listaMascotas);
            Console.WriteLine("\n--- Promedio: {0}", PromMascota.ToString("##.##"));
            Double PromPago = getPromedioDos(listaMascotas);
            Console.WriteLine("\n--- Promedio de pago: {0}", PromPago.ToString("##.##"));
            laraza(listaMascotas);
            Laedad(listaMascotas);
            
            Console.ReadKey();
            
            
        }

        private static void laraza(List<Mascota_adoptada> listaMascotas)
        {
            var raza = from Mascota in listaMascotas
                       where Mascota.Raza == "Chihuaha" && Mascota.sexo == "Hembra"
                       select Mascota;

            foreach (var Mascota in raza)
            {
                Console.WriteLine("\n---Las Mascotas de Raza Chihuaha y Hembras son :\n" + Mascota.Nombre_Mascota + " " + Mascota.Raza + " " + Mascota.edad + " " + Mascota.sexo);
            }
        }

        private static void Laedad(List<Mascota_adoptada> listaMascotas)
        {
            var edades = from Mascota in listaMascotas
                         where Mascota.edad < 2
                         select Mascota;

            foreach( var Mascota in  edades)
            {
                Console.WriteLine("\n---Las Mascotas con edad menor a 2 son :\n" + Mascota.Nombre_Mascota + " " + Mascota.Raza + " " + Mascota.edad + " " + Mascota.sexo);
            }
           
        }




        private static double getPromedioDos(List<Mascota_adoptada> listaMascotas)
        {
           double sum = listaMascotas.Sum(x => x.Pago_Mascota);
            int total = listaMascotas.Count;
            return (double)sum / total;
        }

        private static double getPromedio(List<Mascota_adoptada> listaMascotas)
        {
            decimal sum = listaMascotas.Sum(x => x.edad);
            int total = listaMascotas.Count;
            return (double) sum / total;    
        }



        private static void mostrarlista(List<Mascota_adoptada> listaMascotas)
        {
            Console.WriteLine("\n---LISTA DE MASCOTAS ADOPTADAS---\n");
            foreach (Mascota_adoptada item in listaMascotas)
            {
                Console.WriteLine(item.ToString());
            }
                
        }
    }
}
