using Ventas.Clientes;

namespace Ventas.ClasesBL
{
    public class Clientes
    {
        private Ciudad ciudad1;
        private int v1;
        private string v2;
        private string v3;

        public Clientes(int v1, string v2, string v3, Ciudad ciudad1)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.ciudad1 = ciudad1;
        }
    }
}