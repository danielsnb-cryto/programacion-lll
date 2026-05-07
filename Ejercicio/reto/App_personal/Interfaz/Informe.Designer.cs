namespace App_personal.Interfaz
{
    partial class Informe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "Informe";

            // Main layout
            var mainLayout = new System.Windows.Forms.TableLayoutPanel();
            mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));

            // Left top: Movimientos
            var grpMov = new System.Windows.Forms.GroupBox();
            grpMov.Text = "Movimientos de productos";
            grpMov.Dock = System.Windows.Forms.DockStyle.Fill;
            var dgvMovimientos = new System.Windows.Forms.DataGridView();
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            grpMov.Controls.Add(dgvMovimientos);

            // Left bottom: Stock por producto
            var grpStock = new System.Windows.Forms.GroupBox();
            grpStock.Text = "Stock actual por Producto";
            grpStock.Dock = System.Windows.Forms.DockStyle.Fill;
            var dgvStock = new System.Windows.Forms.DataGridView();
            dgvStock.Name = "dgvStock";
            dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            grpStock.Controls.Add(dgvStock);

            // Right panel: filtros y estadisticas
            var rightPanel = new System.Windows.Forms.Panel();
            rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;

            var lblProducto = new System.Windows.Forms.Label();
            lblProducto.Text = "Producto:";
            lblProducto.Location = new System.Drawing.Point(10, 10);
            rightPanel.Controls.Add(lblProducto);

            var cmbProducto = new System.Windows.Forms.ComboBox();
            cmbProducto.Name = "cmbFiltroProducto";
            cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbProducto.Location = new System.Drawing.Point(10, 30);
            cmbProducto.Width = 260;
            rightPanel.Controls.Add(cmbProducto);

            var lblTipo = new System.Windows.Forms.Label();
            lblTipo.Text = "Tipo de movimiento:";
            lblTipo.Location = new System.Drawing.Point(10, 65);
            rightPanel.Controls.Add(lblTipo);

            var cmbTipo = new System.Windows.Forms.ComboBox();
            cmbTipo.Name = "cmbFiltroTipo";
            cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTipo.Items.AddRange(new object[] { "Todos", "Entrada", "Salida" });
            cmbTipo.Location = new System.Drawing.Point(10, 85);
            cmbTipo.Width = 260;
            rightPanel.Controls.Add(cmbTipo);

            var btnFiltrar = new System.Windows.Forms.Button();
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Text = "Filtrar busqueda";
            btnFiltrar.Location = new System.Drawing.Point(10, 120);
            btnFiltrar.Width = 120;
            rightPanel.Controls.Add(btnFiltrar);

            var btnVerTodos = new System.Windows.Forms.Button();
            btnVerTodos.Name = "btnVerTodos";
            btnVerTodos.Text = "Ver todos";
            btnVerTodos.Location = new System.Drawing.Point(150, 120);
            btnVerTodos.Width = 120;
            rightPanel.Controls.Add(btnVerTodos);

            // Stats boxes
            var lblDetalles = new System.Windows.Forms.Label();
            lblDetalles.Text = "Detalles de movimientos";
            lblDetalles.Location = new System.Drawing.Point(10, 160);
            lblDetalles.Font = new System.Drawing.Font(lblDetalles.Font, System.Drawing.FontStyle.Bold);
            rightPanel.Controls.Add(lblDetalles);

            var pnlEntradas = new System.Windows.Forms.Panel();
            pnlEntradas.Location = new System.Drawing.Point(10, 190);
            pnlEntradas.Size = new System.Drawing.Size(80, 80);
            pnlEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            var lblEntradas = new System.Windows.Forms.Label();
            lblEntradas.Name = "lblEntradas";
            lblEntradas.Text = "+0";
            lblEntradas.Font = new System.Drawing.Font(lblEntradas.Font.FontFamily, 20);
            lblEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            lblEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pnlEntradas.Controls.Add(lblEntradas);
            rightPanel.Controls.Add(pnlEntradas);

            var pnlSalidas = new System.Windows.Forms.Panel();
            pnlSalidas.Location = new System.Drawing.Point(100, 190);
            pnlSalidas.Size = new System.Drawing.Size(80, 80);
            pnlSalidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            var lblSalidas = new System.Windows.Forms.Label();
            lblSalidas.Name = "lblSalidas";
            lblSalidas.Text = "-0";
            lblSalidas.Font = new System.Drawing.Font(lblSalidas.Font.FontFamily, 20);
            lblSalidas.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pnlSalidas.Controls.Add(lblSalidas);
            rightPanel.Controls.Add(pnlSalidas);

            var pnlStockBajo = new System.Windows.Forms.Panel();
            pnlStockBajo.Location = new System.Drawing.Point(190, 190);
            pnlStockBajo.Size = new System.Drawing.Size(80, 80);
            pnlStockBajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            var lblStockBajo = new System.Windows.Forms.Label();
            lblStockBajo.Name = "lblStockBajo";
            lblStockBajo.Text = "0";
            lblStockBajo.Font = new System.Drawing.Font(lblStockBajo.Font.FontFamily, 20);
            lblStockBajo.Dock = System.Windows.Forms.DockStyle.Fill;
            lblStockBajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pnlStockBajo.Controls.Add(lblStockBajo);
            rightPanel.Controls.Add(pnlStockBajo);

            // Footer counts
            var lblProductosCount = new System.Windows.Forms.Label();
            lblProductosCount.Name = "lblProductosCount";
            lblProductosCount.Text = "0 productos";
            lblProductosCount.Location = new System.Drawing.Point(10, 290);
            rightPanel.Controls.Add(lblProductosCount);

            var lblMovimientosCount = new System.Windows.Forms.Label();
            lblMovimientosCount.Name = "lblMovimientosCount";
            lblMovimientosCount.Text = "0 movimientos";
            lblMovimientosCount.Location = new System.Drawing.Point(10, 310);
            rightPanel.Controls.Add(lblMovimientosCount);

            // Add to layout
            mainLayout.Controls.Add(grpMov, 0, 0);
            mainLayout.SetColumnSpan(grpMov, 1);
            mainLayout.Controls.Add(rightPanel, 1, 0);
            mainLayout.SetRowSpan(rightPanel, 2);
            mainLayout.Controls.Add(grpStock, 0, 1);

            this.Controls.Add(mainLayout);
        }

        #endregion
    }
}