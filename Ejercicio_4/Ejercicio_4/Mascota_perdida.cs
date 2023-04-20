using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Mascota_perdida:Mascota
    {
        public Mascota_perdida() { }
        public string Motivo{ get; set; }
        public DateTime Fecha_Perdida { get; set; }

        public override void Mostrar_Mascota()
        {
                       
        }

    }
}
