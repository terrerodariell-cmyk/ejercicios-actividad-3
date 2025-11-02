using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Llenar ComboBox con unidades de longitud
            comboBoxEntrada.Items.AddRange(new string[] { "Metros", "Centímetros", "Pulgadas" });
            comboBoxSalida.Items.AddRange(new string[] { "Metros", "Centímetros", "Pulgadas" });
            comboBoxEntrada.SelectedIndex = 0; // Por defecto "Metros"
            comboBoxSalida.SelectedIndex = 0;  // Por defecto "Metros"
        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double valorEntrada;

            // Verificar si el valor ingresado es un número
            if (double.TryParse(txtValor.Text, out valorEntrada))
            {
                double resultado = ConvertirUnidades(valorEntrada, comboBoxEntrada.SelectedItem.ToString(), comboBoxSalida.SelectedItem.ToString());
                txtResultado.Text = resultado.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double ConvertirUnidades(double valor, string unidadEntrada, string unidadSalida)
        {
            // Convertir todo a metros primero y luego convertir a la unidad de salida
            double valorEnMetros = 0;

            // Convertir valor a metros
            if (unidadEntrada == "Metros")
                valorEnMetros = valor;
            else if (unidadEntrada == "Centímetros")
                valorEnMetros = valor / 100;
            else if (unidadEntrada == "Pulgadas")
                valorEnMetros = valor * 0.0254;

            // Convertir de metros a la unidad de salida
            if (unidadSalida == "Metros")
                return valorEnMetros;
            else if (unidadSalida == "Centímetros")
                return valorEnMetros * 100;
            else if (unidadSalida == "Pulgadas")
                return valorEnMetros / 0.0254;

            return valor;
        }

        private void comboBoxEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSalida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
