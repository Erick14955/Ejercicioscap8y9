using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicioscap8y9
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void Cap8button_Click(object sender, EventArgs e)
        {
            Capitulo8 cap8 = new Capitulo8();
            cap8.Visible = true;
        }

        private void Cap9button_Click(object sender, EventArgs e)
        {
            Capitulo9 cap9 = new Capitulo9();
            cap9.Visible = true;
        }
    }
}
