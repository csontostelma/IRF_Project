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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 49);
            this.button1.TabIndex = 48;
            this.button1.Text = "Paraméterek törlése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(37, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 422);
            this.panel1.TabIndex = 49;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 49);
            this.button2.TabIndex = 50;
            this.button2.Text = "Új paraméter hozzáadása";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Paraméterekmódosítása
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "Paraméterekmódosítása";
            this.Text = "Újparaméter";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}