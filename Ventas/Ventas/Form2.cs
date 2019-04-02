using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.ClasesBL;

namespace Ventas
{
    public partial class Form2 : Form
    {
      

        public Form2()
        {
            InitializeComponent();

            var ciudadBL = new CiudadBL();
            listadeCiudadBindingSource.DataSource = ciudadBL.ListadeCiudad;

            var clientesBL = new ClientesBL();
            listadeCiudadBindingSource.DataSource = ciudadBL.ListadeCiudad;
        }

    }
}
