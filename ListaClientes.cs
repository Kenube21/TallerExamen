using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerExamen
{
    public class ListaClientes
    {
        private List<Cliente> _clientes = [];
        private int contador = 1;

        public void VerClientes()
        {
            if (_clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes");
            }
            else
            {
                foreach (var cliente in _clientes)
                {
                    Console.WriteLine($"ID: {cliente.ID} |" +
                                      $"Nombre: {cliente.Nombre}");
                }
            }
        }
        public void AgregarClientes()
        {
            Console.Write("Nombre: ");
            var nombre = Console.ReadLine();

            Console.Write("Direccion: ");
            var direccion = Console.ReadLine();

            Console.Write("Telefono: ");
            var telefono = Console.ReadLine();

            Console.Write("Correo: ");
            var correo = Console.ReadLine();

            var nuevoCliente = new Cliente(contador++, nombre, direccion, int.Parse(telefono), correo);

            _clientes.Add(nuevoCliente);

            Console.WriteLine("Cliente agregado.");
        }
        public void EditarCliente()
        {
            Console.Write("Ingrese el ID del cliente a editar: ");
            var id = int.Parse(Console.ReadLine());

            var cliente = _clientes.SingleOrDefault(c => c.ID == id);

            if (cliente == null)
            {
                Console.WriteLine("No se encontró el cliente.");
            }
            else
            {
                Console.Write("Nuevo nombre:");
                var nombre = Console.ReadLine();
                cliente.Nombre = nombre;

                Console.Write("Nueva direccion:");
                var direccion = Console.ReadLine();
                cliente.Direccion = direccion;

                Console.WriteLine("Nuevo telefono:");
                var telefono = Console.ReadLine();
                cliente.Telefono = int.Parse(telefono);

                Console.WriteLine("Nuevo correo:");
                var correo = Console.ReadLine();
                cliente.Correo = correo;

                Console.WriteLine("Se editó el usuario");
            }
        }
        public void EliminarCliente()
        {
            Console.Write("Ingrese el ID del cliente a eliminar: ");
            var id = int.Parse(Console.ReadLine());

            var cliente = _clientes.SingleOrDefault(c => c.ID == id);

            if (cliente == null)
            {
                Console.WriteLine("No se encontró el cliente.");
            }
            else
            {
                _clientes.Remove(cliente);
                Console.WriteLine("Se eliminó el usuario");
            }
        }
    }
}
