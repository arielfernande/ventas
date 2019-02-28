using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ciudad
            var ciudad1 = new Ciudad();
            ciudad1.Id = 1;
            ciudad1.Descripcion = "S.P.S";

            var ciudad2 = new Ciudad();
            ciudad2.Id = 1;
            ciudad2.Descripcion = "Progreso";

            //Clientes
            var cliente1 = new Clientes();
            cliente1.Id = 1;
            cliente1.Nombre = "Julano De Tal";
            cliente1.Telefono = 25554151;
            cliente1.Ciudad = ciudad1;

            Clientes cliente2 = new Clientes();
            cliente2.Id = 2;
            cliente2.Nombre = "Mengano De Tal";
            cliente2.Telefono = 25521504;
            cliente2.Ciudad = ciudad1;

            Clientes cliente3 = new Clientes();
            cliente3.Id = 2;
            cliente3.Nombre = "Julana de Tal";
            cliente3.Telefono = 33615394;
            cliente3.Ciudad = ciudad2;

            var listadeclientes = new List<Clientes>();
            listadeclientes.Add(cliente1);
            listadeclientes.Add(cliente2);
            listadeclientes.Add(cliente3);

            foreach (var c in listadeclientes)

                MessageBox.Show(c.Nombre + " " + c.Ciudad.Descripcion);
        }
    }
}
