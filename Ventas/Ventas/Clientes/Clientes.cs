using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Clientes
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public Ciudad Ciudad { get; set; }
        public int CiudadId { get; set; }
        public string Direccion { get; set; }

        public Clientes(int id, string nombre, int telefono, Ciudad ciudad, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Ciudad = ciudad;
            Direccion = direccion;
            CiudadId = ciudad.Id;
        }
    }
}
