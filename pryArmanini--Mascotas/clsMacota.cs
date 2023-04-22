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

        public string AlimentarMascota()
        {
            return Tipo + " ha sido alimentado correctamente";
        }

        public string PasearMascota()
        {
            return "Has sacado a pasear a " + Tipo; 
        }

        public string JugarMascota()
        {
            return "Has jugado exitosamente con " + Tipo;
        }

        public string MimosMascota()
        {
            return "A " + Tipo + " le han encantado tus mimos";
        }

    }
}
