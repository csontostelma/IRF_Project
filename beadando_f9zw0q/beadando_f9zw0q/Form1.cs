using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando_f9zw0q
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_rendelés_Click(object sender, EventArgs e)
        {
            rendeles_ablak ra = new rendeles_ablak();
            panel1.Controls.Clear();
            panel1.Controls.Add(ra);
            ra.Dock=DockStyle.Fill;
        }

        private void button_eddigirendeles_Click(object sender, EventArgs e)
        {
            eddigirendelesek_ablak era = new eddigirendelesek_ablak();
            panel1.Controls.Clear();
            panel1.Controls.Add(era);
            era.Dock = DockStyle.Fill;
        }
    }
}
