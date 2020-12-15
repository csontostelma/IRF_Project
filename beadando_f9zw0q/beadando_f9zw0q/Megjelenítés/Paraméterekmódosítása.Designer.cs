namespace beadando_f9zw0q
{
    partial class Paraméterekmódosítása
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
            this.button_torles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_hozzaadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_torles
            // 
            this.button_torles.Location = new System.Drawing.Point(552, 31);
            this.button_torles.Name = "button_torles";
            this.button_torles.Size = new System.Drawing.Size(232, 49);
            this.button_torles.TabIndex = 48;
            this.button_torles.Text = "Paraméterek törlése";
            this.button_torles.UseVisualStyleBackColor = true;
            this.button_torles.Click += new System.EventHandler(this.button_torles_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(37, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 422);
            this.panel1.TabIndex = 49;
            // 
            // button_hozzaadas
            // 
            this.button_hozzaadas.Location = new System.Drawing.Point(120, 31);
            this.button_hozzaadas.Name = "button_hozzaadas";
            this.button_hozzaadas.Size = new System.Drawing.Size(239, 49);
            this.button_hozzaadas.TabIndex = 50;
            this.button_hozzaadas.Text = "Új paraméter hozzáadása";
            this.button_hozzaadas.UseVisualStyleBackColor = true;
            this.button_hozzaadas.Click += new System.EventHandler(this.button_hozzaadas_Click);
            // 
            // Paraméterekmódosítása
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 578);
            this.Controls.Add(this.button_torles);
            this.Controls.Add(this.button_hozzaadas);
            this.Controls.Add(this.panel1);
            this.Name = "Paraméterekmódosítása";
            this.Text = "Újparaméter";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_torles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_hozzaadas;
    }
}