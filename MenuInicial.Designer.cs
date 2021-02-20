
namespace Ejercicioscap8y9
{
    partial class MenuInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulolabel = new System.Windows.Forms.Label();
            this.Cap8button = new System.Windows.Forms.Button();
            this.Cap9button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.Location = new System.Drawing.Point(299, 26);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(168, 15);
            this.Titulolabel.TabIndex = 0;
            this.Titulolabel.Text = "Ejercicios de los capitulos 8 y 9";
            // 
            // Cap8button
            // 
            this.Cap8button.Location = new System.Drawing.Point(200, 95);
            this.Cap8button.Name = "Cap8button";
            this.Cap8button.Size = new System.Drawing.Size(105, 32);
            this.Cap8button.TabIndex = 1;
            this.Cap8button.Text = "Capitulo 8";
            this.Cap8button.UseVisualStyleBackColor = true;
            this.Cap8button.Click += new System.EventHandler(this.Cap8button_Click);
            // 
            // Cap9button
            // 
            this.Cap9button.Location = new System.Drawing.Point(358, 98);
            this.Cap9button.Name = "Cap9button";
            this.Cap9button.Size = new System.Drawing.Size(109, 29);
            this.Cap9button.TabIndex = 2;
            this.Cap9button.Text = "Capitulo 9";
            this.Cap9button.UseVisualStyleBackColor = true;
            this.Cap9button.Click += new System.EventHandler(this.Cap9button_Click);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cap9button);
            this.Controls.Add(this.Cap8button);
            this.Controls.Add(this.Titulolabel);
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.Button Cap8button;
        private System.Windows.Forms.Button Cap9button;
    }
}

