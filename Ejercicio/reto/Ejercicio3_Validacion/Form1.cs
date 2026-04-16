using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_Validacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularReserva_Click(object sender, EventArgs e)
        {
            //Validamos el nombre del cliente
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del cliente.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Imprimimos los datos de la reserva
            double PrecioNoche = 50;
            double total = 0;

            int numNoches = (dtpSalida.Value.Date - dtpEntrada.Value.Date).Days;
            total += numNoches * PrecioNoche;

            if (NumPersonas.Value == 2 || NumPersonas.Value == 3 || NumPersonas.Value == 4)
            {
                if (NumPersonas.Value == 2)
                {
                    total += 15;
                }
                else if (NumPersonas.Value == 3)
                {
                    total += 30;
                }
                else if (NumPersonas.Value == 4)
                {
                    total += 45;
                }
            }

            total += clbServicios.CheckedItems.Count * 10;


            //Imprmimos
            RichBoxResumen.Text = $"------ Detalles de reserva ------\nNombre del Cliento: {txtNombreCliente.Text}\n" +
                $"Fecha de Entrada: {dtpEntrada.Value.ToShortDateString()}\n" +
                $"Fecha de Salida: {dtpSalida.Value.ToShortDateString()}\n" +
                $"Número de Personas: {NumPersonas.Value}\n" +
                $"Servicios Adicionales: {string.Join(", ", clbServicios.CheckedItems.Cast<string>())}\n" +
                $"-----------------------\nTotal a Pagar: $ {total:C}";

        }

        //Validamos la fecha de entrada
        private void dtpEntrada_ValueChanged(object sender, EventArgs e)
        {
            dtpEntrada.Value = DateTime.Today;
        }

        private void dtpSalida_ValueChanged(object sender, EventArgs e)
        {
            if (dtpSalida.Value.Date <= dtpEntrada.Value.Date)
            {
                MessageBox.Show("La fecha de salida debe ser al menos un día posterior a la fecha de entrada.", "Fecha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpSalida.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
