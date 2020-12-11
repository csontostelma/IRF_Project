using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace beadando_f9zw0q
{
    public partial class rendeles_ablak : UserControl
    {
        adatbazisEntities context = new adatbazisEntities();

        bool gombmegnyomva = false;

        public rendeles_ablak()
        {
            InitializeComponent();

            listBox_fazon.DataSource = context.Fazon.ToList();
            listBox_fazon.DisplayMember = "Nem";
            listBox_fazon.SelectedItem = null;

            listBox_méret.DataSource = context.Méret.ToList();
            listBox_méret.DisplayMember = "Név";
            listBox_méret.SelectedItem = null;

            listBox_szín.DataSource = context.Szín.ToList();
            listBox_szín.DisplayMember = "Név";
            listBox_szín.SelectedItem = null;

            listBox_tipus.DataSource = context.Ruhadarab.ToList();
            listBox_tipus.DisplayMember = "Név";
            listBox_tipus.SelectedItem = null;

            textBox_ár.Text = null;
        }

        private void textBox_nev_Validating(object sender, CancelEventArgs e)
        {
            string Név = @"^[A-Za-zÁ-ú]+ [A-Za-zÁ-ú]+$";

            Regex r = new Regex(Név);
            if (r.IsMatch(textBox_nev.Text))
            {
                textBox_nev.BackColor = Color.LightGreen;
                e.Cancel = false;
            }
            else
            {
                textBox_nev.BackColor = Color.Red;
                e.Cancel = true;
            }
        }

        private void textBox_nev_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void button_megrendel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan meg szeretné rendelni az alábbi terméket?", "Megerősítés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (gombmegnyomva == true)
                {
                    var fazon = (Fazon)listBox_fazon.SelectedItem;
                    var ruhadarab = (Ruhadarab)listBox_tipus.SelectedItem;
                    var méret = (Méret)listBox_méret.SelectedItem;
                    var szín = (Szín)listBox_szín.SelectedItem;

                    Termék t = new Termék();
                    t.FazonFK = fazon.FazonID;
                    t.RuhadarabFK = ruhadarab.RuhadarabID;
                    t.MéretFK = méret.MéretID;
                    t.SzínFK = szín.SzínID;
                    context.Termék.Add(t);
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                    Rendelés r = new Rendelés();
                    r.TermékFK = t.TermékID;
                    r.Név = textBox_nev.Text;
                    context.Rendelés.Add(r);
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void button_megrendel_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_nev.Clear();
            textBox_nev.BackColor = default;
            listBox_fazon.SelectedItem = default;
            listBox_tipus.SelectedItem = default;
            listBox_méret.SelectedItem = default;
            listBox_szín.SelectedItem = default;
            textBox_ár.Clear();
            textBox_nev.Enabled = true;

            MessageBox.Show("Rendelését rögzítettük!");
        }

        private void listBox_tipus_MouseClick(object sender, MouseEventArgs e)
        {
            var ruhadarab = (Ruhadarab)listBox_tipus.SelectedItem;
            textBox_ár.Text = ruhadarab.Ár.ToString();
        }

    }
}
