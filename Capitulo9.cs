using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicioscap8y9
{
    public partial class Capitulo9 : Form
    {
        public Capitulo9()
        {
            InitializeComponent();
        }

        private void Ejercicio1button_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Visible = true;
        }
    }
}
