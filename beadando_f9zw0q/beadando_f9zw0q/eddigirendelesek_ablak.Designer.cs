namespace beadando_f9zw0q
{
    partial class eddigirendelesek_ablak
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
            this.dataGridView_eddigirendeles = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_eddigirendeles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_eddigirendeles
            // 
            this.dataGridView_eddigirendeles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_eddigirendeles.Location = new System.Drawing.Point(22, 78);
            this.dataGridView_eddigirendeles.Name = "dataGridView_eddigirendeles";
            this.dataGridView_eddigirendeles.RowHeadersWidth = 62;
            this.dataGridView_eddigirendeles.RowTemplate.Height = 28;
            this.dataGridView_eddigirendeles.Size = new System.Drawing.Size(630, 272);
            this.dataGridView_eddigirendeles.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 26);
            this.textBox1.TabIndex = 1;
            // 
            // eddigirendelesek_ablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView_eddigirendeles);
            this.Name = "eddigirendelesek_ablak";
            this.Size = new System.Drawing.Size(684, 376);
            this.Load += new System.EventHandler(this.eddigirendelesek_ablak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_eddigirendeles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_eddigirendeles;
        private System.Windows.Forms.TextBox textBox1;
    }
}
