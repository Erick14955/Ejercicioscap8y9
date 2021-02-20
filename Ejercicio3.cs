using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicioscap8y9
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
            string hora = DateTime.Now.ToString("hh:mm:ss tt");
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            Horalabel.Text = hora;
            hora = DateTime.Now.AddSeconds(1).ToString(); 
            Fechalabel.Text = fecha;
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
        }
    }
}
