﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using beadando_f9zw0q.Adatbázis;

namespace beadando_f9zw0q
{
    public partial class Paraméterekozzáadása : UserControl
    {
        public Paraméterekozzáadása()
        {
            InitializeComponent();

            Új_paraméter();
        }

        private void Új_paraméter()
        {
            try
            {
                using (var context = new adatbazisEntities())
                {
                    context.Database.Connection.Open();

                    comboBox_fazon.DataSource = context.Fazon.ToList();
                    comboBox_fazon.DisplayMember = "Nem";
                    comboBox_ruhadarab.DataSource = context.Ruhadarab.ToList();
                    comboBox_ruhadarab.DisplayMember = "Név";
                    comboBox_szin.DataSource = context.Szín.ToList();
                    comboBox_szin.DisplayMember = "Név";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hiba történt a paraméterek betöltése közben: " + ex.Message);
            }

        }

        private void button_ujfazon_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new adatbazisEntities())
                {
                    context.Database.Connection.Open();

                    Fazon f = new Fazon();
                    f.Nem = textBox_fazon.Text;
                    textBox_fazon.Clear();
                    context.Fazon.Add(f);

                    context.SaveChanges();

                    Új_paraméter();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hiba történt az új fazon paraméter felvétele közben: " + ex.Message);
            }

        }

        private void button_ujruhadarab_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new adatbazisEntities())
                {
                    context.Database.Connection.Open();

                    Ruhadarab r = new Ruhadarab();
                    r.Név = textBox_ruhadarab.Text;
                    r.Ár = Convert.ToInt32(textBox_ár.Text);
                    textBox_ruhadarab.Clear();
                    textBox_ár.Clear();
                    context.Ruhadarab.Add(r);

                    context.SaveChanges();

                    Új_paraméter();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hiba történt az új ruhadarab paraméter felvétele közben: " + ex.Message);
            }
        }
    
        private void button_ujszin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new adatbazisEntities())
                {
                    context.Database.Connection.Open();

                    Szín sz = new Szín();
                    sz.Név = textBox_szin.Text;
                    textBox_szin.Clear();
                    context.Szín.Add(sz);

                    context.SaveChanges();

                    Új_paraméter();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az új szín paraméter felvétele közben: " + ex.Message);
            }
           
        }
    }
}