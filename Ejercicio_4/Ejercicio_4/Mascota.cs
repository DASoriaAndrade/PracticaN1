using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Mascota
    {
        public string Nombre_Mascota { get; set; }
        public int edad { get; set; }
        public string  Raza{ get; set; }
        public string sexo { get; set; }

        public virtual void Mostrar_Mascota() { }
    }
}
