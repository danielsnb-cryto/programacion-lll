using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_personal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarMotos registrarMotos = new RegistrarMotos();
            registrarMotos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrarVentas registrarVentas = new RegistrarVentas();
            registrarVentas.Show();
        }
    }
}
