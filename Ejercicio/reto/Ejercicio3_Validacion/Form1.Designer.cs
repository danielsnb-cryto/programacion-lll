namespace Ejercicio3_Validacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.NumPersonas = new System.Windows.Forms.NumericUpDown();
            this.clbServicios = new System.Windows.Forms.CheckedListBox();
            this.RichBoxResumen = new System.Windows.Forms.RichTextBox();
            this.btnCalcularReserva = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOTEL: MIL AMORES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(126, 97);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(110, 135);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(100, 20);
            this.dtpEntrada.TabIndex = 4;
            this.dtpEntrada.ValueChanged += new System.EventHandler(this.dtpEntrada_ValueChanged);
            // 
            // dtpSalida
            // 
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(110, 174);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(100, 20);
            this.dtpSalida.TabIndex = 5;
            this.dtpSalida.ValueChanged += new System.EventHandler(this.dtpSalida_ValueChanged);
            // 
            // NumPersonas
            // 
            this.NumPersonas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumPersonas.Location = new System.Drawing.Point(110, 212);
            this.NumPersonas.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumPersonas.Name = "NumPersonas";
            this.NumPersonas.Size = new System.Drawing.Size(100, 20);
            this.NumPersonas.TabIndex = 6;
            this.NumPersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // clbServicios
            // 
            this.clbServicios.CheckOnClick = true;
            this.clbServicios.FormattingEnabled = true;
            this.clbServicios.Items.AddRange(new object[] {
            "Wifi Premium",
            "Desayuno Buffet",
            "Estacionamiento",
            "Spa",
            "Aguardiente Antioqueño 500ml"});
            this.clbServicios.Location = new System.Drawing.Point(28, 283);
            this.clbServicios.Name = "clbServicios";
            this.clbServicios.Size = new System.Drawing.Size(175, 79);
            this.clbServicios.TabIndex = 7;
            // 
            // RichBoxResumen
            // 
            this.RichBoxResumen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RichBoxResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichBoxResumen.Location = new System.Drawing.Point(254, 97);
            this.RichBoxResumen.Name = "RichBoxResumen";
            this.RichBoxResumen.ReadOnly = true;
            this.RichBoxResumen.Size = new System.Drawing.Size(216, 194);
            this.RichBoxResumen.TabIndex = 8;
            this.RichBoxResumen.Text = "";
            // 
            // btnCalcularReserva
            // 
            this.btnCalcularReserva.Location = new System.Drawing.Point(280, 309);
            this.btnCalcularReserva.Name = "btnCalcularReserva";
            this.btnCalcularReserva.Size = new System.Drawing.Size(148, 30);
            this.btnCalcularReserva.TabIndex = 9;
            this.btnCalcularReserva.Text = "Calcular Reserva";
            this.btnCalcularReserva.UseVisualStyleBackColor = true;
            this.btnCalcularReserva.Click += new System.EventHandler(this.btnCalcularReserva_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha salida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Personas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Servicios para la habitación:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 392);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcularReserva);
            this.Controls.Add(this.RichBoxResumen);
            this.Controls.Add(this.clbServicios);
            this.Controls.Add(this.NumPersonas);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.NumericUpDown NumPersonas;
        private System.Windows.Forms.CheckedListBox clbServicios;
        private System.Windows.Forms.RichTextBox RichBoxResumen;
        private System.Windows.Forms.Button btnCalcularReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}