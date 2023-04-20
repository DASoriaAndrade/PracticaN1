using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Mascota_adoptada:Mascota
    {
        public Mascota_adoptada() { }   

        public string Nombre_Dueño { get; set; }
        public double Pago_Mascota { get; set; }    
        public DateTime Adopcion { get; set; }
        public override void Mostrar_Mascota()
        {

        }
    }
}
