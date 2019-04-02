using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Clientes;

namespace Ventas.ClasesBL
{
    public class CiudadBL
    {
        public List<Ciudad> ListadeCiudad { get; set; }

        public CiudadBL()
        {
            ListadeCiudad = new List<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "S.P.S");
            var ciudad2 = new Ciudad(2, "Progreso");


            ListadeCiudad.Add(ciudad1);
            ListadeCiudad.Add(ciudad2);
        }
    }
}

