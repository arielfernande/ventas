using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ClientesBL
    {
        public BindingList <Cliente> ListadeClientes  { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new BindingList<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "SPS");
            var ciudad2 = new Ciudad(2, "Progreso");

            var cliente1 = new Cliente(1, "Fulana de tal", 33615394, ciudad1, "SPS");
            var cliente2 = new Cliente(2, "Mengano de tal", 98671423, ciudad2, "Progreso");

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
        }
    }
}
