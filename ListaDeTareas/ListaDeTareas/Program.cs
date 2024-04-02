using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTareas
{
    class Program
    {
        static List<string> tareas = new List<string>();
        static void Main(string[] args)
        {
            bool menu = true;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("PROGRAMA DE LISTA DE TAREAS");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            while (menu)
            {
                Console.WriteLine("\n Menu De Tareas:");
                Console.WriteLine("1. Mostrar Tareas");
                Console.WriteLine("2. Agregar Tarea");
                Console.WriteLine("3. Eliminar Tarea");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        VerTareas();
                        break;
                    case "2":
                        AgregarTarea();
                        break;
                    case "3":
                        BorrarTareas();
                        break;
                    case "4":
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("LA OPCION ELEGIDA NO ES VALIDA");
                        break;
                }
            }
        }

        static void VerTareas()
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No Tenemos ninguna tarea por realizar.");
            }
            else
            {
                Console.WriteLine("Tareas por realizar:");
                for (int contador = 0; contador < tareas.Count; contador++)
                {
                    Console.WriteLine($"{contador + 1}. {tareas[contador]}");
                }
            }
        }

        static void AgregarTarea()
        {
            Console.Write("Ingrese la tarea a realizar: ");
            string tareaNueva = Console.ReadLine();
            tareas.Add(tareaNueva);
            Console.WriteLine("La tarea ha sido agregada correctamente.");
        }

        static void BorrarTareas()
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine(" No hay ninguna tarea para ser eliminada.");
            }
            else
            {
                VerTareas();
                Console.Write("Seleccione el número de la tarea que desea eliminar: ");
                int tareaPorEliminar;
                if (int.TryParse(Console.ReadLine(), out tareaPorEliminar))
                {
                    if (tareaPorEliminar > 0 && tareaPorEliminar <= tareas.Count)
                    {
                        tareas.RemoveAt(tareaPorEliminar - 1);
                        Console.WriteLine("Tarea eliminada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Número de tarea no válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Número de tarea no válido.");
                }
            }
        }
    }
}
