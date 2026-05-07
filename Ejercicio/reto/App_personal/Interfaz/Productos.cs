using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_personal.clases;

namespace App_personal
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            // Inicializar tabla al abrir el formulario
            Load += Productos_Load;
            // Nota: el botón "Limpiar" no existe con el nombre `button2` en el diseñador.
            // Si hay un botón para limpiar, conéctalo aquí usando el nombre correcto.
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            CargarProductosEnTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarProductosEnTabla();
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
                Producto nuevoProducto = new Producto
                {
                    Codigo = txtCodigo.Text,
                    Nombre = txtNombre.Text,
                    Categoria = cmbCategoria.Text, // Si usas un ComboBox
                    Precio = (double)txtPrecio.Value,
                    StockInicial = (int)numStockInicial.Value // Si usas un NumericUpDown
                };

                // 3. Llamar al método que creamos en la clase Datos
                App_personal.clases.Datos.GuardarProducto(nuevoProducto);

                // 4. Feedback al usuario y limpieza
                MessageBox.Show("¡Producto guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();

                // Actualizar la tabla para mostrar el nuevo producto
                CargarProductosEnTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método extra para mantener el "espacio negativo" y orden en tu UI
        private void LimpiarCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cmbCategoria.SelectedIndex = -1;
            txtPrecio.Value = 0;
            numStockInicial.Value = 0;
            txtCodigo.Focus();
        }

        private void CargarProductosEnTabla()
        {
            try
            {
                string ruta = ArchivoHelper.ObtenerRuta("productos.csv");
                if (!System.IO.File.Exists(ruta))
                {
                    // Archivo no existe aún; limpiar grid
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    return;
                }

                var lines = System.IO.File.ReadAllLines(ruta).Skip(1); // saltar cabecera
                DataTable dt = new DataTable();
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Categoria");
                dt.Columns.Add("Precio");
                dt.Columns.Add("StockInicial");

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(';');
                    // Evitar errores si la línea está mal formada
                    var row = dt.NewRow();
                    row["Codigo"] = parts.Length > 0 ? parts[0] : string.Empty;
                    row["Nombre"] = parts.Length > 1 ? parts[1] : string.Empty;
                    row["Categoria"] = parts.Length > 2 ? parts[2] : string.Empty;
                    row["Precio"] = parts.Length > 3 ? parts[3] : string.Empty;
                    row["StockInicial"] = parts.Length > 4 ? parts[4] : string.Empty;
                    dt.Rows.Add(row);
                }

                dataGridView1.DataSource = dt;
                // Ajustes visuales mínimos
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
