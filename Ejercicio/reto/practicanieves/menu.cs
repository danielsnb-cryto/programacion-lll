using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicanieves
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 segunda_pantalla = new Form1();
            segunda_pantalla.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 tercera_pantalla = new Form2();
            tercera_pantalla.Show();
        }
    }
}
