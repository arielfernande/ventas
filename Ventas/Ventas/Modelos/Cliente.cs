using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    public class Cliente
    {
        public int      Id         { get; set; }
        public string   Nombre     { get; set; }
        public int      Telefono   { get; set; }
        public Ciudad   Ciudad     { get; set; }
        public int      CiudadId   { get; set; }//Sirve para el diseño del formulario(Combobox)
        public string   Direccion  { get; set; }

        public Cliente()
        {
            Ciudad = new Ciudad(1, "SPS");
            CiudadId = Ciudad.Id;

        }

        public Cliente(int id, string nombre, int telefono, Ciudad ciudad, string direccion)
        {
            Id        = id;
            Nombre    = nombre;
            Telefono  = telefono;
            Ciudad    = ciudad;
            Direccion = direccion;
            CiudadId  = ciudad.Id;


        

        }


    }
}
