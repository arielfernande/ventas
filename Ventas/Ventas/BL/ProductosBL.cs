using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ProductosBL
    {
        public BindingList <Productos> ListadeProductos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new BindingList<Productos>();
            CrearDatosdePrueba();
            
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptops");
            var categoria2 = new Categoria(2, "Accesorios");

            var producto1 = new Productos(1, "Laptop Lenovo", 20000, categoria1);
            var producto2 = new Productos(2, "Laptop Toshiba", 15000, categoria1);
            var producto3 = new Productos(3, "Teclado Acer", 500, categoria2);

            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);

        }

    }
}
