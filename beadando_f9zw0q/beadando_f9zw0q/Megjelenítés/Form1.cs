using beadando_f9zw0q.Adatbázis;
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

            Mintaseged();
        }

        private void Mintaseged()
        {
            label_minta1.Text = "\uE719";
            button_rendeléstörlés.Text = "\uE74D";
        }

        private void button_rendelés_Click(object sender, EventArgs e)
        {

            try
            {
                rendeles_ablak ra = new rendeles_ablak();
                panel1.Controls.Clear();
                panel1.Controls.Add(ra);
                ra.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a rendelés funkció betöltése közben: " + ex.Message);
            }

        }

        private void button_eddigirendeles_Click(object sender, EventArgs e)
        {
            try
            {
                eddigirendelesek_ablak era = new eddigirendelesek_ablak();
                panel1.Controls.Clear();
                panel1.Controls.Add(era);
                era.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az eddigi rendelésekek funkció betöltése közben: " + ex.Message);
            }
          
        }

        private void button_rendeléstörlés_Click(object sender, EventArgs e)
        {

            try
            {
                using (var context = new adatbazisEntities())
                {
                    context.Database.Connection.Open();

                    List<Rendelés> ideiglenes = new List<Rendelés>();

                    List<Rendelés> talatok = context.Rendelés.Where(a => a.Név == segedosztaly.nev && a.Termék.Ruhadarab.Név == segedosztaly.ruha).ToList();


                    foreach (var item in talatok)
                    {
                        var torlendo = context.Rendelés.Remove(item);
                    }

                    context.SaveChanges();
                }

                MessageBox.Show("A rendelést töröltük, töltse újra az eddigi rendeléseket!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a rendelés törlése közben: " + ex.Message);
            }
        
        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            try
            {
                Excelmenedzser m = new Excelmenedzser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a excel generálása közben: " + ex.Message);
            }
        }

        private void button_modositas_Click(object sender, EventArgs e)
        {
            try
            {
                Paraméterekmódosítása úp = new Paraméterekmódosítása();
                úp.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hiba történt a paraméterek módosítása ablak betöltése közben: " + ex.Message);
            }
            
        }
    }
}
