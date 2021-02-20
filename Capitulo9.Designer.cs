
namespace Ejercicioscap8y9
{
    partial class Capitulo9
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
            this.label1 = new System.Windows.Forms.Label();
            this.Ejercicio1button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicios del capitulo 9";
            // 
            // Ejercicio1button
            // 
            this.Ejercicio1button.Location = new System.Drawing.Point(294, 100);
            this.Ejercicio1button.Name = "Ejercicio1button";
            this.Ejercicio1button.Size = new System.Drawing.Size(82, 32);
            this.Ejercicio1button.TabIndex = 1;
            this.Ejercicio1button.Text = "Ejercicio 1";
            this.Ejercicio1button.UseVisualStyleBackColor = true;
            this.Ejercicio1button.Click += new System.EventHandler(this.Ejercicio1button_Click);
            // 
            // Capitulo9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ejercicio1button);
            this.Controls.Add(this.label1);
            this.Name = "Capitulo9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capitulo9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ejercicio1button;
    }
}