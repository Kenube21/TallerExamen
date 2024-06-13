using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerExamen
{
    public class Cliente
    {
        public Cliente(int id, string nombre, string direccion, int telefono, string correo)
        {
            ID = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
    }
}
