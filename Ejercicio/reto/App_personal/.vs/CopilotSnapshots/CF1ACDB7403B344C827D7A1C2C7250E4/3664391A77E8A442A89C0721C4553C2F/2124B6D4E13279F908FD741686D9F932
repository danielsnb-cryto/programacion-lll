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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar que los campos no estén vacíos (Importante para el orden)
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Por favor, completa los campos principales.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Crear la instancia del modelo con los datos de la interfaz
                // Asegúrate de que los nombres de los TextBox coincidan con los tuyos
                App_personal.clases.Producto nuevoProducto = new App_personal.clases.Producto
                {
                    Codigo = txtCodigo.Text,
                    Nombre = txtNombre.Text,
                    Categoria = cmbCategoria.Text, // Si usas un ComboBox
                    Precio = double.Parse(txtPrecio.Text), // Cuidado: debe ser un número válido
                    StockInicial = (int)numStockInicial.Value // Si usas un NumericUpDown
                };

                // 3. Llamar al método que creamos en la clase Datos
                App_personal.clases.Datos.GuardarProducto(nuevoProducto);

                // 4. Feedback al usuario y limpieza
                MessageBox.Show("¡Producto guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();

                // Opcional: Actualizar el DataGridView si tienes uno en la misma pantalla
                // CargarDatosEnTabla(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método extra para mantener el "espacio negativo" y orden en tu UI
        private void LimpiarCampos()
        { // Pone el cursor listo para el siguiente
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
