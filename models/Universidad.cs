using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace models
{
    public class Universidad
    {
        public static List<Estudiante> Estudiantes = new List<Estudiante>();


        public static void Menu()
        {
            var estu = new Estudiante("val", "pp", new DateTime(1970, 1, 1),"ff","22","ff",false);
            Estudiantes.Add(estu);//asi se quema datos para agg
            var universidad = new Universidad();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine(@$"
                1. Agregar Estudiante
                2. Mostrar Estudiantes
                3. Eliminar Estudiante
                4. Actualizar Estudiante
                5. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":

                        universidad.AgregarEstudiante(universidad.PedirDatos());
                        Console.WriteLine("el estudiante fue agg con exito");
                        break;

                    case "2":
                        universidad.Mostrar(Estudiantes);
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el numero de id del estudiante que quiere eliminar");
                        string numIdEliminar = Console.ReadLine();
                        universidad.EliminarEstudiante(numIdEliminar, Estudiantes);
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el numero de id");
                        string numIdEditar = Console.ReadLine();
                        universidad.EditarEstudiante(numIdEditar, Estudiantes);
                        break;
                    case "5":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
        public Estudiante PedirDatos()
        {
            Console.WriteLine("Ingrese el nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tipo de id");
            string tipoId = Console.ReadLine();

            Console.WriteLine("Ingrese el numero de id");
            string numeroId = Console.ReadLine();
            Console.WriteLine("Ingresa el nombre de la carrera");
            string carrera = Console.ReadLine();
            Console.WriteLine("Estas matriculado? (true/false)");
            bool matriculado = bool.Parse(Console.ReadLine());

            return new Estudiante(nombre, apellido, fechaNacimiento, tipoId, numeroId, carrera, matriculado);
            //retorna una intancia de unestudiante 

        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void Mostrar(List<Estudiante> estudiantes)
        {
            foreach (var estudiante in estudiantes)
            {
                estudiante.MostrarDetalles(); // estudiante es porque es el iterados de la lista tipo Estudiante, aso se llama la clase
            }
        }

        public void EliminarEstudiante(string numId, List<Estudiante> estudiantes)
        {
            var estudianteElimianr = estudiantes.Find(e => e.NumId == numId);
            if (estudianteElimianr != null)
            {
                Console.WriteLine($"Estas seguro/a que deseas eliminar al estudiamte con nombre {estudianteElimianr.Nombre} {estudianteElimianr.Apellido} (si / no)");
                string respuesta = Console.ReadLine().ToLower();
                if (respuesta == "si")
                {
                    estudiantes.Remove(estudianteElimianr);
                }
                else
                {
                    Console.WriteLine("esta bien, chao");
                }
            }
            else
            {
                Console.WriteLine($"EL estudiante con numero de id {numId} no se encontró ");
            }
        }

        public void EditarEstudiante(string numId, List<Estudiante> estudiantes)
        {
            var estudianteEditar = estudiantes.Find(e => e.NumId == numId);
            if (estudianteEditar != null)
            {
                Console.WriteLine(@"Que deseas editar:
                1. Nombre
                2. Apellido
                3. Tipo de id
                4. Numero de id
                5. Carrera
                6. Estado de matriculacion");
                string editar = Console.ReadLine();

                switch (editar)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nuevo nombre");
                        estudianteEditar.Nombre = Console.ReadLine();
                        paularMenu();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el nuevo apellido");
                        estudianteEditar.Apellido = Console.ReadLine();
                        paularMenu();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el nuevo tipo de id");
                        estudianteEditar.TipoId = Console.ReadLine();
                        paularMenu();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el nuevo numero de id");
                        estudianteEditar.NumId = Console.ReadLine();
                        paularMenu();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese la nueva carrera");
                        estudianteEditar.Carrera = Console.ReadLine();
                        paularMenu();
                        break;
                    case "6":
                        Console.WriteLine("Estas seguro/a que deseas cambiar el estado de matriculacion (si / no)");
                        string respuesta = Console.ReadLine().ToLower();
                        if (respuesta == "si")
                        {
                            estudianteEditar.Matriculado = !estudianteEditar.Matriculado;
                        }
                        paularMenu();
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        paularMenu();
                        break;
                }

            }
        }

        public static void paularMenu(){
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();
            Console.ReadLine();
        }




    }
}