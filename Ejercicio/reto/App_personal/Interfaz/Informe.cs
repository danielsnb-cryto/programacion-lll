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

namespace App_personal.Interfaz
{
    public partial class Informe : Form
    {
        public Informe()
        {
            InitializeComponent();
            Load += Informe_Load;

            // Wire buttons (they were created in designer code)
            var btnFiltrar = this.Controls.Find("btnFiltrar", true).FirstOrDefault() as Button;
            var btnVerTodos = this.Controls.Find("btnVerTodos", true).FirstOrDefault() as Button;
            if (btnFiltrar != null) btnFiltrar.Click += BtnFiltrar_Click;
            if (btnVerTodos != null) btnVerTodos.Click += BtnVerTodos_Click;
        }

        private void Informe_Load(object sender, EventArgs e)
        {
            CargarProductosEnCombo();
            CargarMovimientos();
            CargarStock();
            ActualizarContadores();
        }

        private void CargarProductosEnCombo()
        {
            var cmb = this.Controls.Find("cmbFiltroProducto", true).FirstOrDefault() as ComboBox;
            if (cmb == null) return;
            cmb.Items.Clear();
            cmb.Items.Add("-- Todos los productos --");
            var ruta = ArchivoHelper.ObtenerRuta("productos.csv");
            if (!System.IO.File.Exists(ruta))
            {
                cmb.SelectedIndex = 0;
                return;
            }

            var lines = System.IO.File.ReadAllLines(ruta).Skip(1);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(';');
                var codigo = parts.Length > 0 ? parts[0] : string.Empty;
                var nombre = parts.Length > 1 ? parts[1] : string.Empty;
                cmb.Items.Add($"{codigo} - {nombre}");
            }
            cmb.SelectedIndex = 0;
        }

        private Dictionary<string, string> LeerMapaProductos()
        {
            var mapa = new Dictionary<string, string>();
            var ruta = ArchivoHelper.ObtenerRuta("productos.csv");
            if (!System.IO.File.Exists(ruta)) return mapa;
            var lines = System.IO.File.ReadAllLines(ruta).Skip(1);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(';');
                var codigo = parts.Length > 0 ? parts[0] : string.Empty;
                var nombre = parts.Length > 1 ? parts[1] : string.Empty;
                mapa[codigo] = nombre;
            }
            return mapa;
        }

        private void CargarMovimientos(string filtroCodigo = null, string filtroTipo = null)
        {
            var dgv = this.Controls.Find("dgvMovimientos", true).FirstOrDefault() as DataGridView;
            if (dgv == null) return;
            var mapa = LeerMapaProductos();

            DataTable dt = new DataTable();
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Stock");

            // Leer entradas
            var rutaEntradas = ArchivoHelper.ObtenerRuta("entradas.csv");
            if (System.IO.File.Exists(rutaEntradas))
            {
                var lines = System.IO.File.ReadAllLines(rutaEntradas).Skip(1);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(';');
                    var fecha = parts.Length > 0 ? parts[0] : string.Empty;
                    var codigo = parts.Length > 1 ? parts[1] : string.Empty;
                    var cantidad = parts.Length > 2 ? parts[2] : "0";
                    var obs = parts.Length > 3 ? parts[3] : string.Empty;

                    if (!string.IsNullOrEmpty(filtroCodigo) && filtroCodigo != codigo) continue;
                    if (!string.IsNullOrEmpty(filtroTipo) && filtroTipo != "Entrada") continue;

                    var stockActual = Datos.ObtenerStockActual(codigo);
                    var row = dt.NewRow();
                    row["Fecha"] = fecha;
                    row["Tipo"] = "Entrada";
                    row["Codigo"] = codigo;
                    row["Producto"] = mapa.ContainsKey(codigo) ? mapa[codigo] : "";
                    row["Cantidad"] = "+" + cantidad;
                    row["Stock"] = stockActual.ToString();
                    dt.Rows.Add(row);
                }
            }

            // Leer salidas
            var rutaSalidas = ArchivoHelper.ObtenerRuta("salidas.csv");
            if (System.IO.File.Exists(rutaSalidas))
            {
                var lines = System.IO.File.ReadAllLines(rutaSalidas).Skip(1);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(';');
                    var fecha = parts.Length > 0 ? parts[0] : string.Empty;
                    var codigo = parts.Length > 1 ? parts[1] : string.Empty;
                    var cantidad = parts.Length > 2 ? parts[2] : "0";
                    var obs = parts.Length > 3 ? parts[3] : string.Empty;

                    if (!string.IsNullOrEmpty(filtroCodigo) && filtroCodigo != codigo) continue;
                    if (!string.IsNullOrEmpty(filtroTipo) && filtroTipo != "Salida") continue;

                    var stockActual = Datos.ObtenerStockActual(codigo);
                    var row = dt.NewRow();
                    row["Fecha"] = fecha;
                    row["Tipo"] = "Salida";
                    row["Codigo"] = codigo;
                    row["Producto"] = mapa.ContainsKey(codigo) ? mapa[codigo] : "";
                    row["Cantidad"] = "-" + cantidad;
                    row["Stock"] = stockActual.ToString();
                    dt.Rows.Add(row);
                }
            }

            dgv.DataSource = dt;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;

            // Apply color formatting
            foreach (DataGridViewRow r in dgv.Rows)
            {
                var tipo = r.Cells[1].Value?.ToString();
                var cantCell = r.Cells[4];
                if (tipo == "Entrada")
                {
                    r.Cells[1].Style.ForeColor = Color.Green;
                    cantCell.Style.ForeColor = Color.Green;
                }
                else if (tipo == "Salida")
                {
                    r.Cells[1].Style.ForeColor = Color.Red;
                    cantCell.Style.ForeColor = Color.Red;
                }
            }
        }

        private void CargarStock()
        {
            var dgv = this.Controls.Find("dgvStock", true).FirstOrDefault() as DataGridView;
            if (dgv == null) return;

            var rutaProductos = ArchivoHelper.ObtenerRuta("productos.csv");
            var rutaEntradas = ArchivoHelper.ObtenerRuta("entradas.csv");
            var rutaSalidas = ArchivoHelper.ObtenerRuta("salidas.csv");

            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("StockIni");
            dt.Columns.Add("Entradas");
            dt.Columns.Add("Salidas");
            dt.Columns.Add("StockActual");

            if (!System.IO.File.Exists(rutaProductos))
            {
                dgv.DataSource = dt;
                return;
            }

            var prodLines = System.IO.File.ReadAllLines(rutaProductos).Skip(1);
            foreach (var p in prodLines)
            {
                if (string.IsNullOrWhiteSpace(p)) continue;
                var parts = p.Split(';');
                var codigo = parts.Length > 0 ? parts[0] : string.Empty;
                var nombre = parts.Length > 1 ? parts[1] : string.Empty;
                var stockIni = parts.Length > 4 ? parts[4] : "0";

                int entradas = 0;
                if (System.IO.File.Exists(rutaEntradas))
                {
                    var linesE = System.IO.File.ReadAllLines(rutaEntradas).Skip(1);
                    foreach (var l in linesE)
                    {
                        if (string.IsNullOrWhiteSpace(l)) continue;
                        var ps = l.Split(';');
                        if (ps.Length > 1 && ps[1] == codigo) entradas += int.Parse(ps[2]);
                    }
                }

                int salidas = 0;
                if (System.IO.File.Exists(rutaSalidas))
                {
                    var linesS = System.IO.File.ReadAllLines(rutaSalidas).Skip(1);
                    foreach (var l in linesS)
                    {
                        if (string.IsNullOrWhiteSpace(l)) continue;
                        var ps = l.Split(';');
                        if (ps.Length > 1 && ps[1] == codigo) salidas += int.Parse(ps[2]);
                    }
                }

                int stockActual = int.Parse(stockIni) + entradas - salidas;

                var row = dt.NewRow();
                row["Codigo"] = codigo;
                row["Nombre"] = nombre;
                row["StockIni"] = stockIni;
                row["Entradas"] = "+" + entradas.ToString();
                row["Salidas"] = "-" + salidas.ToString();
                row["StockActual"] = stockActual.ToString();
                dt.Rows.Add(row);
            }

            dgv.DataSource = dt;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;

            // color formatting
            foreach (DataGridViewRow r in dgv.Rows)
            {
                r.Cells[3].Style.ForeColor = Color.Green; // Entradas
                r.Cells[4].Style.ForeColor = Color.Red;   // Salidas
                int stock = int.Parse(r.Cells[5].Value.ToString());
                if (stock <= 2)
                {
                    r.Cells[5].Style.ForeColor = Color.Orange;
                }
            }
        }

        private void ActualizarContadores()
        {
            var lblE = this.Controls.Find("lblEntradas", true).FirstOrDefault() as Label;
            var lblS = this.Controls.Find("lblSalidas", true).FirstOrDefault() as Label;
            var lblSB = this.Controls.Find("lblStockBajo", true).FirstOrDefault() as Label;
            var lblProdCount = this.Controls.Find("lblProductosCount", true).FirstOrDefault() as Label;
            var lblMovCount = this.Controls.Find("lblMovimientosCount", true).FirstOrDefault() as Label;

            int totalEntradas = 0;
            int totalSalidas = 0;
            int productos = 0;
            int movimientos = 0;
            int stockBajo = 0;

            var rutaProd = ArchivoHelper.ObtenerRuta("productos.csv");
            if (System.IO.File.Exists(rutaProd))
            {
                var lines = System.IO.File.ReadAllLines(rutaProd).Skip(1);
                productos = lines.Count(l => !string.IsNullOrWhiteSpace(l));
            }

            var rutaEntradas = ArchivoHelper.ObtenerRuta("entradas.csv");
            if (System.IO.File.Exists(rutaEntradas))
            {
                var lines = System.IO.File.ReadAllLines(rutaEntradas).Skip(1);
                foreach (var l in lines)
                {
                    if (string.IsNullOrWhiteSpace(l)) continue;
                    var p = l.Split(';');
                    totalEntradas += int.Parse(p[2]);
                    movimientos++;
                }
            }

            var rutaSalidas = ArchivoHelper.ObtenerRuta("salidas.csv");
            if (System.IO.File.Exists(rutaSalidas))
            {
                var lines = System.IO.File.ReadAllLines(rutaSalidas).Skip(1);
                foreach (var l in lines)
                {
                    if (string.IsNullOrWhiteSpace(l)) continue;
                    var p = l.Split(';');
                    totalSalidas += int.Parse(p[2]);
                    movimientos++;
                }
            }

            // stock bajo: productos with stockActual <=2
            var rutaProductos = ArchivoHelper.ObtenerRuta("productos.csv");
            if (System.IO.File.Exists(rutaProductos))
            {
                var prodLines = System.IO.File.ReadAllLines(rutaProductos).Skip(1);
                foreach (var pl in prodLines)
                {
                    if (string.IsNullOrWhiteSpace(pl)) continue;
                    var parts = pl.Split(';');
                    var codigo = parts.Length > 0 ? parts[0] : string.Empty;
                    var stock = Datos.ObtenerStockActual(codigo);
                    if (stock <= 2) stockBajo++;
                }
            }

            if (lblE != null) lblE.Text = "+" + totalEntradas.ToString();
            if (lblS != null) lblS.Text = "-" + totalSalidas.ToString();
            if (lblSB != null) lblSB.Text = stockBajo.ToString();
            if (lblProdCount != null) lblProdCount.Text = productos + " productos";
            if (lblMovCount != null) lblMovCount.Text = movimientos + " movimientos";
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            var cmbProd = this.Controls.Find("cmbFiltroProducto", true).FirstOrDefault() as ComboBox;
            var cmbTipo = this.Controls.Find("cmbFiltroTipo", true).FirstOrDefault() as ComboBox;
            string codigo = null;
            string tipo = null;
            if (cmbProd != null && cmbProd.SelectedItem != null && cmbProd.SelectedItem.ToString() != "-- Todos los productos --")
            {
                codigo = cmbProd.SelectedItem.ToString().Split(new[] { '-' }, 2)[0].Trim();
            }
            if (cmbTipo != null && cmbTipo.SelectedItem != null && cmbTipo.SelectedItem.ToString() != "Todos")
            {
                tipo = cmbTipo.SelectedItem.ToString();
            }

            CargarMovimientos(codigo, tipo);
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            var cmbProd = this.Controls.Find("cmbFiltroProducto", true).FirstOrDefault() as ComboBox;
            var cmbTipo = this.Controls.Find("cmbFiltroTipo", true).FirstOrDefault() as ComboBox;
            if (cmbProd != null) cmbProd.SelectedIndex = 0;
            if (cmbTipo != null) cmbTipo.SelectedIndex = 0;
            CargarMovimientos();
        }
    }
}
