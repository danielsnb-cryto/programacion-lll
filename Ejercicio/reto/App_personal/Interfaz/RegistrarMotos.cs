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
    public partial class RegistrarMotos : Form
    {
        public RegistrarMotos()
        {
            InitializeComponent();
            Load += RegistrarMotos_Load;
            button2.Click += button2_Click; // Registrar Entrada
            
        }

        private void RegistrarMotos_Load(object sender, EventArgs e)
        {
            CargarProductosEnCombo();
            CargarEntradasEnTabla();
        }

        private void CargarProductosEnCombo()
        {
            try
            {
                var ruta = App_personal.clases.ArchivoHelper.ObtenerRuta("productos.csv");
                if (!System.IO.File.Exists(ruta)) return;
                var lines = System.IO.File.ReadAllLines(ruta).Skip(1);
                cmbCodigoProducto.Items.Clear();
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(';');
                    var codigo = parts.Length > 0 ? parts[0] : string.Empty;
                    var nombre = parts.Length > 1 ? parts[1] : string.Empty;
                    cmbCodigoProducto.Items.Add($"{codigo} - {nombre}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando productos: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarEntradasEnTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCodigoProducto.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var seleccionado = cmbCodigoProducto.SelectedItem.ToString();
                var codigo = seleccionado.Split(new[] { '-' }, 2)[0].Trim();

                var m = new App_personal.clases.Movimiento
                {
                    Fecha = dateTimePicker1.Value,
                    Codigo = codigo,
                    Cantidad = (int)numCantidad.Value,
                    Observacion = textBox1.Text
                };

                // Guardar movimiento en entradas.csv para cálculo de stock
                App_personal.clases.Datos.RegistrarMovimiento("entradas.csv", m);

                // Guardar detalle de motos registradas
                var line = $"{m.Fecha:dd/MM/yyyy};{m.Codigo};{m.Cantidad};{m.Observacion}";
                App_personal.clases.ArchivoHelper.EscribirLinea("motos_registradas.csv", line);

                MessageBox.Show("Entrada registrada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEntradasEnTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registrando entrada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEntradasEnTabla()
        {
            try
            {
                var ruta = App_personal.clases.ArchivoHelper.ObtenerRuta("motos_registradas.csv");
                if (!System.IO.File.Exists(ruta))
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    return;
                }

                var lines = System.IO.File.ReadAllLines(ruta).Skip(1);
                DataTable dt = new DataTable();
                dt.Columns.Add("Fecha");
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("Observacion");

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(';');
                    var row = dt.NewRow();
                    row["Fecha"] = parts.Length > 0 ? parts[0] : string.Empty;
                    row["Codigo"] = parts.Length > 1 ? parts[1] : string.Empty;
                    row["Cantidad"] = parts.Length > 2 ? parts[2] : string.Empty;
                    row["Observacion"] = parts.Length > 3 ? parts[3] : string.Empty;
                    dt.Rows.Add(row);
                }

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;

                // Pintar cantidades como +n en verde
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    var cell = r.Cells[2];
                    var val = cell.Value?.ToString() ?? "0";
                    cell.Value = "+" + val;
                    cell.Style.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar entradas: " + ex.Message);
            }
        }
    }
}
