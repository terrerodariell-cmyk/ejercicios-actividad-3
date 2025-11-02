using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_3
{
    public partial class Form1 : Form
    {
        private int tiempoRestante; // Tiempo total en segundos
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int minutos = (int)numMinutos.Value;
            int segundos = (int)numSegundos.Value;

            tiempoRestante = (minutos * 60) + segundos;

            if (tiempoRestante > 0)
            {
                timer1.Start();
                btnIniciar.Enabled = false;
                btnDetener.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese un tiempo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTiempo.Text = "00:00";
            btnIniciar.Enabled = true;
            btnDetener.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante--;

                int minutos = tiempoRestante / 60;
                int segundos = tiempoRestante % 60;

                lblTiempo.Text = $"{minutos:D2}:{segundos:D2}";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("¡Tiempo finalizado!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIniciar.Enabled = true;
                btnDetener.Enabled = false;
            }

        }
    }
}
