﻿namespace beadando_f9zw0q
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
            this.button_kereses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridView_eddigirendeles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_eddigirendeles.Size = new System.Drawing.Size(748, 351);
            this.dataGridView_eddigirendeles.TabIndex = 0;
            this.dataGridView_eddigirendeles.SelectionChanged += new System.EventHandler(this.dataGridView_eddigirendeles_SelectionChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button_kereses
            // 
            this.button_kereses.Location = new System.Drawing.Point(199, 36);
            this.button_kereses.Name = "button_kereses";
            this.button_kereses.Size = new System.Drawing.Size(96, 36);
            this.button_kereses.TabIndex = 2;
            this.button_kereses.Text = "keresés";
            this.button_kereses.UseVisualStyleBackColor = true;
            this.button_kereses.Click += new System.EventHandler(this.button_kereses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruhadarabra szűrés:";
            // 
            // eddigirendelesek_ablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_kereses);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView_eddigirendeles);
            this.Name = "eddigirendelesek_ablak";
            this.Size = new System.Drawing.Size(802, 449);
            this.Load += new System.EventHandler(this.eddigirendelesek_ablak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_eddigirendeles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_eddigirendeles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_kereses;
        private System.Windows.Forms.Label label1;
    }
}
