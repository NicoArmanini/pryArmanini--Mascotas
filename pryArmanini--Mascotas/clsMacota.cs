using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryArmanini__Mascotas
{
    public class clsMacota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Tipo { get; set; }

        public string ListaAnimales { get; set; }
        public string AlimentarMascota()
        {
            return Nombre + " ha sido alimentado correctamente";
        }



    }
}
