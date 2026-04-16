namespace Ejercicio2_Validacion
{
    partial class Form1
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
            this.rdbExento = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.NumStocMinima = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumStocMaxima = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbGeneral = new System.Windows.Forms.RadioButton();
            this.rdbReducido = new System.Windows.Forms.RadioButton();
            this.chEsPerecedero = new System.Windows.Forms.CheckBox();
            this.dtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumStocMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumStocMaxima)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbExento
            // 
            this.rdbExento.AutoSize = true;
            this.rdbExento.Location = new System.Drawing.Point(13, 21);
            this.rdbExento.Name = "rdbExento";
            this.rdbExento.Size = new System.Drawing.Size(58, 17);
            this.rdbExento.TabIndex = 0;
            this.rdbExento.TabStop = true;
            this.rdbExento.Text = "Exento";
            this.rdbExento.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del producto:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(138, 70);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(91, 20);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(138, 107);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(91, 20);
            this.txtCodigoProducto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código del producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(16, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria del producto:";
            // 
            // cbxCategoriaProducto
            // 
            this.cbxCategoriaProducto.FormattingEnabled = true;
            this.cbxCategoriaProducto.Items.AddRange(new object[] {
            "Electrónica",
            "Alimentos",
            "Ropa"});
            this.cbxCategoriaProducto.Location = new System.Drawing.Point(138, 146);
            this.cbxCategoriaProducto.Name = "cbxCategoriaProducto";
            this.cbxCategoriaProducto.Size = new System.Drawing.Size(91, 21);
            this.cbxCategoriaProducto.TabIndex = 7;
            // 
            // NumStocMinima
            // 
            this.NumStocMinima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumStocMinima.Location = new System.Drawing.Point(93, 186);
            this.NumStocMinima.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumStocMinima.Name = "NumStocMinima";
            this.NumStocMinima.Size = new System.Drawing.Size(91, 20);
            this.NumStocMinima.TabIndex = 8;
            this.NumStocMinima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumStocMinima.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(16, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stock minima:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(16, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stock maxima:";
            // 
            // NumStocMaxima
            // 
            this.NumStocMaxima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumStocMaxima.Location = new System.Drawing.Point(93, 222);
            this.NumStocMaxima.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumStocMaxima.Name = "NumStocMaxima";
            this.NumStocMaxima.Size = new System.Drawing.Size(91, 20);
            this.NumStocMaxima.TabIndex = 10;
            this.NumStocMaxima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumStocMaxima.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbReducido);
            this.groupBox1.Controls.Add(this.rdbGeneral);
            this.groupBox1.Controls.Add(this.rdbExento);
            this.groupBox1.Location = new System.Drawing.Point(260, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 77);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(IVA)";
            // 
            // rdbGeneral
            // 
            this.rdbGeneral.AutoSize = true;
            this.rdbGeneral.Location = new System.Drawing.Point(77, 21);
            this.rdbGeneral.Name = "rdbGeneral";
            this.rdbGeneral.Size = new System.Drawing.Size(62, 17);
            this.rdbGeneral.TabIndex = 1;
            this.rdbGeneral.TabStop = true;
            this.rdbGeneral.Text = "General";
            this.rdbGeneral.UseVisualStyleBackColor = true;
            // 
            // rdbReducido
            // 
            this.rdbReducido.AutoSize = true;
            this.rdbReducido.Location = new System.Drawing.Point(13, 46);
            this.rdbReducido.Name = "rdbReducido";
            this.rdbReducido.Size = new System.Drawing.Size(71, 17);
            this.rdbReducido.TabIndex = 2;
            this.rdbReducido.TabStop = true;
            this.rdbReducido.Text = "Reducido";
            this.rdbReducido.UseVisualStyleBackColor = true;
            // 
            // chEsPerecedero
            // 
            this.chEsPerecedero.AutoSize = true;
            this.chEsPerecedero.Location = new System.Drawing.Point(264, 156);
            this.chEsPerecedero.Name = "chEsPerecedero";
            this.chEsPerecedero.Size = new System.Drawing.Size(98, 17);
            this.chEsPerecedero.TabIndex = 13;
            this.chEsPerecedero.Text = "Es perecedero.";
            this.chEsPerecedero.UseVisualStyleBackColor = true;
            this.chEsPerecedero.CheckedChanged += new System.EventHandler(this.chEsPerecedero_CheckedChanged);
            // 
            // dtFechaVencimiento
            // 
            this.dtFechaVencimiento.Enabled = false;
            this.dtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaVencimiento.Location = new System.Drawing.Point(264, 202);
            this.dtFechaVencimiento.Name = "dtFechaVencimiento";
            this.dtFechaVencimiento.Size = new System.Drawing.Size(84, 20);
            this.dtFechaVencimiento.TabIndex = 14;
            this.dtFechaVencimiento.ValueChanged += new System.EventHandler(this.dtFechaVencimiento_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha de vencimiento:";
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarProducto.Location = new System.Drawing.Point(181, 269);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(116, 35);
            this.btnRegistrarProducto.TabIndex = 16;
            this.btnRegistrarProducto.Text = "Registrar Producto";
            this.btnRegistrarProducto.UseVisualStyleBackColor = false;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 316);
            this.Controls.Add(this.btnRegistrarProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFechaVencimiento);
            this.Controls.Add(this.chEsPerecedero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumStocMaxima);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumStocMinima);
            this.Controls.Add(this.cbxCategoriaProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumStocMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumStocMaxima)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbExento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCategoriaProducto;
        private System.Windows.Forms.NumericUpDown NumStocMinima;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumStocMaxima;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbReducido;
        private System.Windows.Forms.RadioButton rdbGeneral;
        private System.Windows.Forms.CheckBox chEsPerecedero;
        private System.Windows.Forms.DateTimePicker dtFechaVencimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrarProducto;
    }
}