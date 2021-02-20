using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicioscap8y9
{
    public partial class Capitulo8 : Form
    {
        public Capitulo8()
        {
            InitializeComponent();
        }

        private void Ejercicio3button_Click(object sender, EventArgs e)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3();
            ejercicio3.Visible = true;
        }

        private void Ejercicio5button_Click(object sender, EventArgs e)
        {
            Ejercicio5 ejercicio5 = new Ejercicio5();
            ejercicio5.Visible = true;
        }
    }
}
