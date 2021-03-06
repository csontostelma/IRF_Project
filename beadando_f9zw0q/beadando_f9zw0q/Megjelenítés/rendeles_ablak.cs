﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using beadando_f9zw0q.Adatbázis;

namespace beadando_f9zw0q
{
    public partial class rendeles_ablak : UserControl
    {
        public List<Meret> meretlista
        {
            get
            {
                return Enum.GetValues(typeof(Meret)).Cast<Meret>().ToList();
            }
        }

        public rendeles_ablak()
        {
            InitializeComponent();

            Adatok_beolvasasa();

            Mintaseged();
        }

        private void Mintaseged()
        {
            label_minta.Text = "\uEC87";
            label_minta3.Text = "\uE74E";
        }

        private void Adatok_beolvasasa()
        {
            try
            {
                using (var context = new adatbazisEntities())
                {
                    context.Database.Connection.Open();

                    listBox_fazon.DataSource = context.Fazon.ToList();
                    listBox_fazon.DisplayMember = "Nem";
                    listBox_fazon.SelectedItem = null;

                    comboBox_meret.DataSource = meretlista;
                    comboBox_meret.DisplayMember = "Ruha_nagysaga";
                    comboBox_meret.SelectedItem = null;

                    listBox_szín.DataSource = context.Szín.ToList();
                    listBox_szín.DisplayMember = "Név";
                    listBox_szín.SelectedItem = null;

                    listBox_tipus.DataSource = context.Ruhadarab.ToList();
                    listBox_tipus.DisplayMember = "Név";
                    listBox_tipus.SelectedItem = null;

                    textBox_ár.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok beolvasása közben: " + ex.Message);
            }
        }

        private void textBox_nev_Validating(object sender, CancelEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a név validálása során: " + ex.Message);
            }
        }

        private void textBox_nev_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void button_megrendel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Biztosan meg szeretné rendelni az alábbi terméket?", "Megerősítés", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var fazon = (Fazon)listBox_fazon.SelectedItem;
                    var ruhadarab = (Ruhadarab)listBox_tipus.SelectedItem;
                    var méret = (int)comboBox_meret.SelectedItem;
                    var szín = (Szín)listBox_szín.SelectedItem;

                    Termék t = new Termék();
                    t.FazonFK = fazon.FazonID;
                    t.RuhadarabFK = ruhadarab.RuhadarabID;
                    t.MéretFK = méret;
                    t.SzínFK = szín.SzínID;

                    using (var context = new adatbazisEntities())
                    {
                        context.Database.Connection.Open();
                        
                            context.Termék.Add(t);
                            Rendelés r = new Rendelés();
                            r.TermékFK = t.TermékID;
                            r.RendelésID = context.Rendelés.Max(a => a.RendelésID) + 1;
                            r.Név = textBox_nev.Text;
                            context.Rendelés.Add(r);
                            context.SaveChanges();
                    }

                    textBox_nev.Text = null;
                    textBox_nev.BackColor = Color.White;
                    listBox_fazon.SelectedItem = null;
                    comboBox_meret.SelectedItem = null;
                    listBox_szín.SelectedItem = null;
                    listBox_tipus.SelectedItem = null;
                    textBox_ár.Text = null;

                    MessageBox.Show("Rendelését rögzítettük!");
                }
                else
                {
                    textBox_nev.Text = textBox_nev.Text;
                    listBox_fazon.SelectedItem = true;
                    listBox_tipus.SelectedItem = true;
                    listBox_szín.SelectedItem = true;
                    comboBox_meret.SelectedItem = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a rendelés mentése közben: " + ex.Message);
            }
                
        }

        private void listBox_tipus_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var ruhadarab = (Ruhadarab)listBox_tipus.SelectedItem;
                textBox_ár.Text = ruhadarab.Ár.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az ár megjelenítése közben: " + ex.Message);
            }
        }     
    }
}
