
namespace Ejercicioscap8y9
{
    partial class Capitulo8
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
            this.Titulolabel = new System.Windows.Forms.Label();
            this.Ejercicio3button = new System.Windows.Forms.Button();
            this.Ejercicio5button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Titulolabel.Location = new System.Drawing.Point(195, 9);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(130, 15);
            this.Titulolabel.TabIndex = 0;
            this.Titulolabel.Text = "Ejercicios del capitulo 8";
            // 
            // Ejercicio3button
            // 
            this.Ejercicio3button.Location = new System.Drawing.Point(99, 54);
            this.Ejercicio3button.Name = "Ejercicio3button";
            this.Ejercicio3button.Size = new System.Drawing.Size(106, 30);
            this.Ejercicio3button.TabIndex = 1;
            this.Ejercicio3button.Text = "Ejercicio 3";
            this.Ejercicio3button.UseVisualStyleBackColor = true;
            this.Ejercicio3button.Click += new System.EventHandler(this.Ejercicio3button_Click);
            // 
            // Ejercicio5button
            // 
            this.Ejercicio5button.Location = new System.Drawing.Point(266, 54);
            this.Ejercicio5button.Name = "Ejercicio5button";
            this.Ejercicio5button.Size = new System.Drawing.Size(106, 30);
            this.Ejercicio5button.TabIndex = 2;
            this.Ejercicio5button.Text = "Ejercicio 5";
            this.Ejercicio5button.UseVisualStyleBackColor = true;
            this.Ejercicio5button.Click += new System.EventHandler(this.Ejercicio5button_Click);
            // 
            // Capitulo8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(492, 147);
            this.Controls.Add(this.Ejercicio5button);
            this.Controls.Add(this.Ejercicio3button);
            this.Controls.Add(this.Titulolabel);
            this.Name = "Capitulo8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capitulo8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.Button Ejercicio3button;
        private System.Windows.Forms.Button Ejercicio5button;
    }
}