using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicioscap8y9
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            NomProductotextBox.Clear();
            CantidadtextBox.Clear();
            PreciotextBox.Clear();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void Cerrarbutton_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio = new Ejercicio1();
            ejercicio.Visible = false;
        }

        public struct Productos
        {
            public double precio;
            public string Nombre_producto;
            public int Cantidad;

            public Productos(string nombre, int cant, double preci)
            {
                Nombre_producto = nombre;
                Cantidad = cant;
                precio = preci;
            }
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            string nombre = NomProductotextBox.Text;
            int cant = Convert.ToInt32(CantidadtextBox.Text);
            double preci = Convert.ToDouble(PreciotextBox.Text);

            Productos product = new Productos(nombre, cant, preci);

            MessageBox.Show("Guardado correctamente");
        }
    }
}
