using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace models
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TipoId { get; set; }
        public string NumId { get; set; }

        public virtual void Edad (){
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            Console.WriteLine($"el estudiante tiene {edad}  de edad");
        }

        public abstract void MostrarDetalles();

        public abstract void Bienvenida();

    }
}