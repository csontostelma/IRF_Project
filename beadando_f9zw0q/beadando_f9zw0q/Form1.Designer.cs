namespace beadando_f9zw0q
{
    partial class Form1
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
            this.button_rendelés = new System.Windows.Forms.Button();
            this.button_rendeléstörlés = new System.Windows.Forms.Button();
            this.button_eddigirendeles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_excel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_rendelés
            // 
            this.button_rendelés.Location = new System.Drawing.Point(38, 134);
            this.button_rendelés.Name = "button_rendelés";
            this.button_rendelés.Size = new System.Drawing.Size(134, 54);
            this.button_rendelés.TabIndex = 0;
            this.button_rendelés.Text = "Rendelés";
            this.button_rendelés.UseVisualStyleBackColor = true;
            this.button_rendelés.Click += new System.EventHandler(this.button_rendelés_Click);
            // 
            // button_rendeléstörlés
            // 
            this.button_rendeléstörlés.Location = new System.Drawing.Point(38, 336);
            this.button_rendeléstörlés.Name = "button_rendeléstörlés";
            this.button_rendeléstörlés.Size = new System.Drawing.Size(134, 54);
            this.button_rendeléstörlés.TabIndex = 1;
            this.button_rendeléstörlés.Text = "Rendelés törlés";
            this.button_rendeléstörlés.UseVisualStyleBackColor = true;
            this.button_rendeléstörlés.Click += new System.EventHandler(this.button_rendeléstörlés_Click);
            // 
            // button_eddigirendeles
            // 
            this.button_eddigirendeles.Location = new System.Drawing.Point(38, 240);
            this.button_eddigirendeles.Name = "button_eddigirendeles";
            this.button_eddigirendeles.Size = new System.Drawing.Size(134, 54);
            this.button_eddigirendeles.TabIndex = 2;
            this.button_eddigirendeles.Text = "Eddigi rendelések";
            this.button_eddigirendeles.UseVisualStyleBackColor = true;
            this.button_eddigirendeles.Click += new System.EventHandler(this.button_eddigirendeles_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(194, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 450);
            this.panel1.TabIndex = 3;
            // 
            // button_excel
            // 
            this.button_excel.Location = new System.Drawing.Point(38, 423);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(134, 54);
            this.button_excel.TabIndex = 4;
            this.button_excel.Text = "Excel generálás";
            this.button_excel.UseVisualStyleBackColor = true;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 545);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_eddigirendeles);
            this.Controls.Add(this.button_rendeléstörlés);
            this.Controls.Add(this.button_rendelés);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_rendelés;
        private System.Windows.Forms.Button button_rendeléstörlés;
        private System.Windows.Forms.Button button_eddigirendeles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_excel;
    }
}

