using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerExamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listaCLientes = new ListaClientes();
            bool enEjecucion = true;

            while (enEjecucion)
            {
                Console.WriteLine("Opciones");
                Console.WriteLine("1. Ver clientes");
                Console.WriteLine("2. Agregar cliente");
                Console.WriteLine("3. Editar cliente");
                Console.WriteLine("4. Eliminar cliente");
                Console.WriteLine("5. Salir");

                Console.Write("Opcion:");
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        listaCLientes.VerClientes();
                        break;
                    case "2":
                        listaCLientes.AgregarClientes();
                        break;
                    case "3":
                        listaCLientes.EditarCliente();
                        break;
                    case "4":
                        listaCLientes.EliminarCliente();
                        break;
                    case "5":
                        enEjecucion = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
    }
}
