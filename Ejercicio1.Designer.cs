
namespace Ejercicioscap8y9
{
    partial class Ejercicio1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Productolabel = new System.Windows.Forms.Label();
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.Preciolabel = new System.Windows.Forms.Label();
            this.NomProductotextBox = new System.Windows.Forms.TextBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.Cerrarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Productolabel
            // 
            this.Productolabel.AutoSize = true;
            this.Productolabel.Location = new System.Drawing.Point(12, 29);
            this.Productolabel.Name = "Productolabel";
            this.Productolabel.Size = new System.Drawing.Size(122, 15);
            this.Productolabel.TabIndex = 0;
            this.Productolabel.Text = "Nombre del producto";
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(12, 71);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(55, 15);
            this.Cantidadlabel.TabIndex = 1;
            this.Cantidadlabel.Text = "Cantidad";
            // 
            // Preciolabel
            // 
            this.Preciolabel.AutoSize = true;
            this.Preciolabel.Location = new System.Drawing.Point(12, 109);
            this.Preciolabel.Name = "Preciolabel";
            this.Preciolabel.Size = new System.Drawing.Size(40, 15);
            this.Preciolabel.TabIndex = 2;
            this.Preciolabel.Text = "Precio";
            // 
            // NomProductotextBox
            // 
            this.NomProductotextBox.Location = new System.Drawing.Point(148, 26);
            this.NomProductotextBox.Name = "NomProductotextBox";
            this.NomProductotextBox.Size = new System.Drawing.Size(182, 23);
            this.NomProductotextBox.TabIndex = 3;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(148, 63);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(182, 23);
            this.CantidadtextBox.TabIndex = 4;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(148, 101);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(182, 23);
            this.PreciotextBox.TabIndex = 5;
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Location = new System.Drawing.Point(97, 150);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(81, 28);
            this.Aceptarbutton.TabIndex = 6;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.Location = new System.Drawing.Point(197, 150);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(81, 28);
            this.Limpiarbutton.TabIndex = 7;
            this.Limpiarbutton.Text = "Limpiar";
            this.Limpiarbutton.UseVisualStyleBackColor = true;
            this.Limpiarbutton.Click += new System.EventHandler(this.Limpiarbutton_Click);
            // 
            // Cerrarbutton
            // 
            this.Cerrarbutton.Location = new System.Drawing.Point(298, 150);
            this.Cerrarbutton.Name = "Cerrarbutton";
            this.Cerrarbutton.Size = new System.Drawing.Size(81, 28);
            this.Cerrarbutton.TabIndex = 8;
            this.Cerrarbutton.Text = "Cerrar";
            this.Cerrarbutton.UseVisualStyleBackColor = true;
            this.Cerrarbutton.Click += new System.EventHandler(this.Cerrarbutton_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(400, 209);
            this.Controls.Add(this.Cerrarbutton);
            this.Controls.Add(this.Limpiarbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.NomProductotextBox);
            this.Controls.Add(this.Preciolabel);
            this.Controls.Add(this.Cantidadlabel);
            this.Controls.Add(this.Productolabel);
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio1";
            this.Load += new System.EventHandler(this.Ejercicio1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Productolabel;
        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.Label Preciolabel;
        private System.Windows.Forms.TextBox NomProductotextBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Button Limpiarbutton;
        private System.Windows.Forms.Button Cerrarbutton;
    }
}