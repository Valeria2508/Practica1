using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace models
{
    public class Estudiante:Persona
    {
        public string Carrera {get; set;}
        public bool Matriculado {get; set;}

        public Estudiante(string nombre, string apellido, DateTime fechaNacimiento, string tipoId, string numId, string carrera, bool matriculado)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            TipoId = tipoId;
            NumId = numId;
            Carrera = carrera;
            Matriculado = matriculado;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Estudiante: {Nombre} {Apellido}");
            Console.WriteLine($"Tipo de Identificación: {TipoId}");
            Console.WriteLine($"Número de Identificación: {NumId}");
            Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Matriculado: {Matriculado}");
        }

        public override void Bienvenida()
        {
            Console.WriteLine($"Bienvenido/a {Nombre} al sistema de estudiantes!");
        }
    }
}