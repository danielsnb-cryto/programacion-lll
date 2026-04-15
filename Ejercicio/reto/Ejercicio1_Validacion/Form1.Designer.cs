namespace Ejercicio1_Validacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIndentificacion = new System.Windows.Forms.TextBox();
            this.TipoTrabajo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SueldoBase = new System.Windows.Forms.NumericUpDown();
            this.BotonRegistrar = new System.Windows.Forms.Button();
            this.MensajeNombre = new System.Windows.Forms.Label();
            this.MensajeApellido = new System.Windows.Forms.Label();
            this.MensajeEmail = new System.Windows.Forms.Label();
            this.MensajeCedula = new System.Windows.Forms.Label();
            this.MensajeTipoTrabajo = new System.Windows.Forms.Label();
            this.MensajeRegistrar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SueldoBase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MensajeRegistrar);
            this.groupBox1.Controls.Add(this.MensajeTipoTrabajo);
            this.groupBox1.Controls.Add(this.MensajeCedula);
            this.groupBox1.Controls.Add(this.MensajeEmail);
            this.groupBox1.Controls.Add(this.MensajeApellido);
            this.groupBox1.Controls.Add(this.MensajeNombre);
            this.groupBox1.Controls.Add(this.BotonRegistrar);
            this.groupBox1.Controls.Add(this.SueldoBase);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TipoTrabajo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIndentificacion);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(27, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistema de Registro: Empleados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del empleado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(14, 97);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(155, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido del empleado:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(174, 94);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(159, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(14, 154);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(140, 15);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email del empleado:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(174, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cedula del empleado:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIndentificacion
            // 
            this.txtIndentificacion.Location = new System.Drawing.Point(174, 205);
            this.txtIndentificacion.Name = "txtIndentificacion";
            this.txtIndentificacion.Size = new System.Drawing.Size(159, 20);
            this.txtIndentificacion.TabIndex = 6;
            this.txtIndentificacion.TextChanged += new System.EventHandler(this.txtIndentificacion_TextChanged);
            // 
            // TipoTrabajo
            // 
            this.TipoTrabajo.FormattingEnabled = true;
            this.TipoTrabajo.Items.AddRange(new object[] {
            "Ventas",
            "IT",
            "Recursos Humanos",
            "Contabilidad"});
            this.TipoTrabajo.Location = new System.Drawing.Point(460, 93);
            this.TipoTrabajo.Name = "TipoTrabajo";
            this.TipoTrabajo.Size = new System.Drawing.Size(121, 21);
            this.TipoTrabajo.TabIndex = 8;
            this.TipoTrabajo.SelectedIndexChanged += new System.EventHandler(this.TipoTrabajo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo de trabajo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sueldo base: $";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SueldoBase
            // 
            this.SueldoBase.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SueldoBase.Location = new System.Drawing.Point(460, 39);
            this.SueldoBase.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SueldoBase.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SueldoBase.Name = "SueldoBase";
            this.SueldoBase.Size = new System.Drawing.Size(120, 20);
            this.SueldoBase.TabIndex = 11;
            this.SueldoBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SueldoBase.ThousandsSeparator = true;
            this.SueldoBase.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // BotonRegistrar
            // 
            this.BotonRegistrar.Location = new System.Drawing.Point(377, 163);
            this.BotonRegistrar.Name = "BotonRegistrar";
            this.BotonRegistrar.Size = new System.Drawing.Size(162, 42);
            this.BotonRegistrar.TabIndex = 12;
            this.BotonRegistrar.Text = "Registrar Empleado.";
            this.BotonRegistrar.UseVisualStyleBackColor = true;
            this.BotonRegistrar.Click += new System.EventHandler(this.BotonRegistrar_Click);
            // 
            // MensajeNombre
            // 
            this.MensajeNombre.AutoSize = true;
            this.MensajeNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MensajeNombre.Location = new System.Drawing.Point(201, 62);
            this.MensajeNombre.Name = "MensajeNombre";
            this.MensajeNombre.Size = new System.Drawing.Size(115, 13);
            this.MensajeNombre.TabIndex = 13;
            this.MensajeNombre.Text = "Se necesita el nombre.";
            this.MensajeNombre.Visible = false;
            // 
            // MensajeApellido
            // 
            this.MensajeApellido.AutoSize = true;
            this.MensajeApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MensajeApellido.Location = new System.Drawing.Point(201, 117);
            this.MensajeApellido.Name = "MensajeApellido";
            this.MensajeApellido.Size = new System.Drawing.Size(117, 13);
            this.MensajeApellido.TabIndex = 14;
            this.MensajeApellido.Text = "Se necesita el Apellido.";
            this.MensajeApellido.Visible = false;
            // 
            // MensajeEmail
            // 
            this.MensajeEmail.AutoSize = true;
            this.MensajeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MensajeEmail.Location = new System.Drawing.Point(201, 178);
            this.MensajeEmail.Name = "MensajeEmail";
            this.MensajeEmail.Size = new System.Drawing.Size(130, 13);
            this.MensajeEmail.TabIndex = 15;
            this.MensajeEmail.Text = "Email invalido o requerido.";
            this.MensajeEmail.Visible = false;
            // 
            // MensajeCedula
            // 
            this.MensajeCedula.AutoSize = true;
            this.MensajeCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MensajeCedula.Location = new System.Drawing.Point(201, 228);
            this.MensajeCedula.Name = "MensajeCedula";
            this.MensajeCedula.Size = new System.Drawing.Size(112, 13);
            this.MensajeCedula.TabIndex = 16;
            this.MensajeCedula.Text = "Se necesita la cedula.";
            this.MensajeCedula.Visible = false;
            // 
            // MensajeTipoTrabajo
            // 
            this.MensajeTipoTrabajo.AutoSize = true;
            this.MensajeTipoTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MensajeTipoTrabajo.Location = new System.Drawing.Point(457, 117);
            this.MensajeTipoTrabajo.Name = "MensajeTipoTrabajo";
            this.MensajeTipoTrabajo.Size = new System.Drawing.Size(151, 13);
            this.MensajeTipoTrabajo.TabIndex = 17;
            this.MensajeTipoTrabajo.Text = "Se necesita un tipo de trabajo.";
            this.MensajeTipoTrabajo.Visible = false;
            // 
            // MensajeRegistrar
            // 
            this.MensajeRegistrar.AutoSize = true;
            this.MensajeRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MensajeRegistrar.Location = new System.Drawing.Point(374, 210);
            this.MensajeRegistrar.Name = "MensajeRegistrar";
            this.MensajeRegistrar.Size = new System.Drawing.Size(183, 13);
            this.MensajeRegistrar.TabIndex = 18;
            this.MensajeRegistrar.Text = "Por favor, rellena los campos primero.";
            this.MensajeRegistrar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SueldoBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TipoTrabajo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIndentificacion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown SueldoBase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BotonRegistrar;
        private System.Windows.Forms.Label MensajeTipoTrabajo;
        private System.Windows.Forms.Label MensajeCedula;
        private System.Windows.Forms.Label MensajeEmail;
        private System.Windows.Forms.Label MensajeApellido;
        private System.Windows.Forms.Label MensajeNombre;
        private System.Windows.Forms.Label MensajeRegistrar;
    }
}