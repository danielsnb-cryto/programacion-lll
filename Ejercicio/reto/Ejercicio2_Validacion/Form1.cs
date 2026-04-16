using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_Validacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtFechaVencimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chEsPerecedero_CheckedChanged(object sender, EventArgs e)
        {
            if (chEsPerecedero.Checked)
            {
                dtFechaVencimiento.Enabled = true;
            }
            else
            {
                dtFechaVencimiento.Enabled = false;
            }
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            //Nombre Producto
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Codigo Producto
            if (txtCodigoProducto.Text == "")
            {
                MessageBox.Show("El código del producto es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!txtCodigoProducto.Text.StartsWith("PROD-"))
            {
                MessageBox.Show("El código del producto debe tener (PROD-) para ser valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Categoria Producto
            if (cbxCategoriaProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar una categoría para el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Fecha de vencimiento
            if (!chEsPerecedero.Checked)
            {
                dtFechaVencimiento.Enabled = false;
            }

            //Validar fecha de vencimiento para productos perecederos
            if (chEsPerecedero.Checked && dtFechaVencimiento.Value <= DateTime.Now)
            {
                MessageBox.Show("La fecha de vencimiento debe ser futura para productos perecederos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //IVA producto
            if (rdbExento.Checked == false && rdbReducido.Checked == false && rdbGeneral.Checked == false)
            {
                MessageBox.Show("Debes seleccionar al menos una de las IVA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Stock Minimo y Maximo
            if (NumStocMaxima.Value < NumStocMinima.Value)
            {
                MessageBox.Show("La cantidad máxima en stock debe ser mayor o igual a la cantidad mínima.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Registrar producto
            MessageBox.Show("Producto registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
