﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BL;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var productosBL = new ProductosBL();
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;

            var CategoriasBL = new CategoriasBL();
            listadeCategoriasBindingSource.DataSource = CategoriasBL.ListadeCategorias;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
