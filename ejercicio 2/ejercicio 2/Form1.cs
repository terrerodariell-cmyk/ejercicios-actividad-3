using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLongitud.Text, out int longitud) && longitud > 0)
            {
                string contraseña = GenerarContraseña(longitud, chkMayusculas.Checked, chkNumeros.Checked, chkEspeciales.Checked);

                txtResultado.Text = contraseña;  // Muestra la contraseña en el TextBox
                listBox1.Items.Add(contraseña);  // Agrega la contraseña al ListBox
            }
            else
            {
                MessageBox.Show("Ingrese una longitud válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private string GenerarContraseña(int longitud, bool incluirMayus, bool incluirNum, bool incluirEspeciales)
        {
            const string letrasMin = "abcdefghijklmnopqrstuvwxyz";
            const string letrasMay = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numeros = "0123456789";
            const string especiales = "!@#$%^&*()-_=+<>?";

            StringBuilder caracteres = new StringBuilder(letrasMin);

            if (incluirMayus) caracteres.Append(letrasMay);
            if (incluirNum) caracteres.Append(numeros);
            if (incluirEspeciales) caracteres.Append(especiales);

            if (caracteres.Length == 0)
                return "Debe seleccionar al menos un criterio";

            Random rand = new Random();
            return new string(Enumerable.Repeat(caracteres.ToString(), longitud)
                                       .Select(s => s[rand.Next(s.Length)]).ToArray());
        }
    }

}
