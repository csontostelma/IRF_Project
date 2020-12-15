namespace beadando_f9zw0q
{
    partial class Paraméterektörlése
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_torles = new System.Windows.Forms.Button();
            this.listBox_fazon = new System.Windows.Forms.ListBox();
            this.listBox_szín = new System.Windows.Forms.ListBox();
            this.listBox_típus = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_torles
            // 
            this.button_torles.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_torles.Location = new System.Drawing.Point(546, 279);
            this.button_torles.Name = "button_torles";
            this.button_torles.Size = new System.Drawing.Size(112, 55);
            this.button_torles.TabIndex = 1;
            this.button_torles.Text = "E74D";
            this.button_torles.UseVisualStyleBackColor = true;
            this.button_torles.Click += new System.EventHandler(this.button_torles_Click);
            // 
            // listBox_fazon
            // 
            this.listBox_fazon.FormattingEnabled = true;
            this.listBox_fazon.ItemHeight = 20;
            this.listBox_fazon.Location = new System.Drawing.Point(58, 57);
            this.listBox_fazon.Name = "listBox_fazon";
            this.listBox_fazon.Size = new System.Drawing.Size(150, 104);
            this.listBox_fazon.TabIndex = 2;
            // 
            // listBox_szín
            // 
            this.listBox_szín.FormattingEnabled = true;
            this.listBox_szín.ItemHeight = 20;
            this.listBox_szín.Location = new System.Drawing.Point(280, 57);
            this.listBox_szín.Name = "listBox_szín";
            this.listBox_szín.Size = new System.Drawing.Size(180, 104);
            this.listBox_szín.TabIndex = 5;
            // 
            // listBox_típus
            // 
            this.listBox_típus.FormattingEnabled = true;
            this.listBox_típus.ItemHeight = 20;
            this.listBox_típus.Location = new System.Drawing.Point(526, 57);
            this.listBox_típus.Name = "listBox_típus";
            this.listBox_típus.Size = new System.Drawing.Size(180, 144);
            this.listBox_típus.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(478, 227);
            this.dataGridView1.TabIndex = 6;
            // 
            // Paraméterektörlése
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox_szín);
            this.Controls.Add(this.listBox_típus);
            this.Controls.Add(this.listBox_fazon);
            this.Controls.Add(this.button_torles);
            this.Name = "Paraméterektörlése";
            this.Size = new System.Drawing.Size(727, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_torles;
        private System.Windows.Forms.ListBox listBox_fazon;
        private System.Windows.Forms.ListBox listBox_szín;
        private System.Windows.Forms.ListBox listBox_típus;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
