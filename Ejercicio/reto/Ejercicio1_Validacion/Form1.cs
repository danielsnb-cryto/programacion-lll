using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Validacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MensajeNombre.Visible = true;
            }
            else
            {
                MensajeNombre.Visible=false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                MensajeApellido.Visible = true;
            }
            else
            {
                MensajeApellido.Visible = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MensajeEmail.Visible = true;
            }
            else
            {
                MensajeEmail.Visible = false;
            }
        }

        private void txtIndentificacion_TextChanged(object sender, EventArgs e)
        {
            if (txtIndentificacion.Text == "")
            {
                MensajeCedula.Visible = true;
            }
            else
            {
                MensajeCedula.Visible = false;
            }
        }

        private void TipoTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoTrabajo.SelectedIndex == 0)
            {
                MensajeTipoTrabajo.Visible = true;
            }
            else
            {
                MensajeTipoTrabajo.Visible = false;
            }
        }

        private void BotonRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtEmail.Text == "" || txtIndentificacion.Text == "" || TipoTrabajo.SelectedIndex == 0)
            {
                MensajeRegistrar.Visible = true;

            }
            else
            {
                MensajeRegistrar.ForeColor = Color.DarkGreen;
                decimal Valor = SueldoBase.Value;
                decimal Total_ = Valor - (Valor * 0.10m);
                MensajeRegistrar.Text = "Empleado registrado, existosamente.";
                MessageBox.Show($"\n============== DATOS DEL EMPLEADO ============== \n\nNombre: {txtNombre.Text}\nApellido: {txtApellido.Text}\nEmail: {txtEmail.Text} \nCedula: {txtIndentificacion.Text}\nSueldo base: $ {Valor} \n------------------------------\nTotal ganancia (-10% Impuestos): $ {Total_}");
                
            }
        }
    }
}
