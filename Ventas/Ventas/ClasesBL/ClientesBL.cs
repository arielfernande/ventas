using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Clientes;

namespace Ventas.ClasesBL
{
    public class ClientesBL
    {
        public List<Clientes> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new List<Clientes>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "S.P.S");
            var ciudad2 = new Ciudad(2, "Progreso");

            var clientes1 = new Clientes(1, "Progreso", "bendek", ciudad1);
            var clientes2 = new Clientes(2, "Choloma", "cortes", ciudad1);
            var clientes3 = new Clientes(3, "SPS", "Rivera Hernandes", ciudad2);

            ListadeClientes.Add(clientes1);
            ListadeClientes.Add(clientes2);
            ListadeClientes.Add(clientes3);
        }
    }
}
