﻿using beadando_f9zw0q.Adatbázis;
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
    public partial class Paraméterekmódosítása : Form
    {
        public Paraméterekmódosítása()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Paraméterekozzáadása ph = new Paraméterekozzáadása();
            panel1.Controls.Clear();
            panel1.Controls.Add(ph);
            ph.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paraméterektörlése pt = new Paraméterektörlése();
            panel1.Controls.Clear();
            panel1.Controls.Add(pt);
            pt.Dock = DockStyle.Fill;
        }

    }
}
