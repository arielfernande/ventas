using System;
using System.Windows.Forms;
using Ventas.BL;

namespace Ventas
{
    public partial class Menu : Form
    {
        ProductosBL    _productosBL;
        CategoriasBL   _categoriasBL;
        ClientesBL     _clientesBL;
        CiudadBL       _ciudadBL;


        public Menu()
        {
            InitializeComponent();

            _productosBL  = new ProductosBL ();
            _categoriasBL = new CategoriasBL();
            _clientesBL   = new ClientesBL  ();
            _ciudadBL     = new CiudadBL    ();   
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new Form1();
            formProductos.MdiParent = this;
            formProductos.CargarDatos(_productosBL, _categoriasBL);

            formProductos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new Form2();
            formClientes.MdiParent = this;

            formClientes.cargarDatos(_clientesBL, _ciudadBL);


            formClientes.Show();
        }
    }
}
