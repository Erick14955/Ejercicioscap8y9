
namespace Ejercicioscap8y9
{
    partial class Ejercicio5
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
            this.label2 = new System.Windows.Forms.Label();
            this.Cadena1textBox = new System.Windows.Forms.TextBox();
            this.Cadena2textBox = new System.Windows.Forms.TextBox();
            this.Compararbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadena 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadena 2";
            // 
            // Cadena1textBox
            // 
            this.Cadena1textBox.Location = new System.Drawing.Point(117, 36);
            this.Cadena1textBox.Name = "Cadena1textBox";
            this.Cadena1textBox.Size = new System.Drawing.Size(223, 23);
            this.Cadena1textBox.TabIndex = 2;
            // 
            // Cadena2textBox
            // 
            this.Cadena2textBox.Location = new System.Drawing.Point(117, 87);
            this.Cadena2textBox.Name = "Cadena2textBox";
            this.Cadena2textBox.Size = new System.Drawing.Size(223, 23);
            this.Cadena2textBox.TabIndex = 3;
            // 
            // Compararbutton
            // 
            this.Compararbutton.Location = new System.Drawing.Point(117, 135);
            this.Compararbutton.Name = "Compararbutton";
            this.Compararbutton.Size = new System.Drawing.Size(117, 23);
            this.Compararbutton.TabIndex = 4;
            this.Compararbutton.Text = "Comparar";
            this.Compararbutton.UseVisualStyleBackColor = true;
            this.Compararbutton.Click += new System.EventHandler(this.Compararbutton_Click);
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(399, 196);
            this.Controls.Add(this.Compararbutton);
            this.Controls.Add(this.Cadena2textBox);
            this.Controls.Add(this.Cadena1textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cadena1textBox;
        private System.Windows.Forms.TextBox Cadena2textBox;
        private System.Windows.Forms.Button Compararbutton;
    }
}