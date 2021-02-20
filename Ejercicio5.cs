using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicioscap8y9
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void Compararbutton_Click(object sender, EventArgs e)
        {
            int comparacion;
            string cadena1, cadena2;
            cadena1 = Cadena1textBox.Text;
            cadena2 = Cadena2textBox.Text;

            comparacion = cadena1.CompareTo(cadena2);
            if(comparacion == 0)
            {
                MessageBox.Show("Ambas cadenas son iguales");
            }
            else
            {
                if(comparacion < 0)
                {
                    MessageBox.Show(cadena1 + " \n" + cadena2);
                }
                else
                {
                    MessageBox.Show(cadena2 + "\n" + cadena1);
                }
            }

        }
    }
}
