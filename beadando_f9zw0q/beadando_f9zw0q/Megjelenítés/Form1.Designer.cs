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
            this.label_minta1 = new System.Windows.Forms.Label();
            this.label_minta2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_rendelés
            // 
            this.button_rendelés.Location = new System.Drawing.Point(38, 89);
            this.button_rendelés.Name = "button_rendelés";
            this.button_rendelés.Size = new System.Drawing.Size(134, 54);
            this.button_rendelés.TabIndex = 0;
            this.button_rendelés.Text = "Rendelés";
            this.button_rendelés.UseVisualStyleBackColor = true;
            this.button_rendelés.Click += new System.EventHandler(this.button_rendelés_Click);
            // 
            // button_rendeléstörlés
            // 
            this.button_rendeléstörlés.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rendeléstörlés.ForeColor = System.Drawing.Color.Red;
            this.button_rendeléstörlés.Location = new System.Drawing.Point(38, 467);
            this.button_rendeléstörlés.Name = "button_rendeléstörlés";
            this.button_rendeléstörlés.Size = new System.Drawing.Size(134, 45);
            this.button_rendeléstörlés.TabIndex = 1;
            this.button_rendeléstörlés.Text = "E74D";
            this.button_rendeléstörlés.UseVisualStyleBackColor = true;
            this.button_rendeléstörlés.Click += new System.EventHandler(this.button_rendeléstörlés_Click);
            // 
            // button_eddigirendeles
            // 
            this.button_eddigirendeles.Location = new System.Drawing.Point(38, 168);
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
            this.button_excel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_excel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_excel.Location = new System.Drawing.Point(38, 243);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(134, 56);
            this.button_excel.TabIndex = 4;
            this.button_excel.Text = "Excel generálás";
            this.button_excel.UseVisualStyleBackColor = false;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // label_minta1
            // 
            this.label_minta1.AutoSize = true;
            this.label_minta1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_minta1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_minta1.Location = new System.Drawing.Point(122, 20);
            this.label_minta1.Name = "label_minta1";
            this.label_minta1.Size = new System.Drawing.Size(62, 28);
            this.label_minta1.TabIndex = 5;
            this.label_minta1.Text = "E719";
            // 
            // label_minta2
            // 
            this.label_minta2.AutoSize = true;
            this.label_minta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_minta2.Location = new System.Drawing.Point(44, 444);
            this.label_minta2.Name = "label_minta2";
            this.label_minta2.Size = new System.Drawing.Size(128, 20);
            this.label_minta2.TabIndex = 6;
            this.label_minta2.Text = "Rendelés törlés: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Webshop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_minta2);
            this.Controls.Add(this.label_minta1);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_eddigirendeles);
            this.Controls.Add(this.button_rendeléstörlés);
            this.Controls.Add(this.button_rendelés);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_rendelés;
        private System.Windows.Forms.Button button_rendeléstörlés;
        private System.Windows.Forms.Button button_eddigirendeles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.Label label_minta1;
        private System.Windows.Forms.Label label_minta2;
        private System.Windows.Forms.Label label1;
    }
}

