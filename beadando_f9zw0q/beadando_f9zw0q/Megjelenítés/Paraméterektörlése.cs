using System;
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
    public partial class Paraméterektörlése : UserControl
    {
        public Paraméterektörlése()
        {
            InitializeComponent();

            terméklista = new List<Termek_adat>();
            Paraméterek_beolvasása();
            button_torles.Text = "\uE74D";

        }

        public List<Meret> meretlista
        {
            get
            {
                return Enum.GetValues(typeof(Meret)).Cast<Meret>().ToList();
            }
        }

        public List<Termek_adat> terméklista
        {
            get;set;
        }

        private void Paraméterek_beolvasása()
        {
            try
            {
                using (var context = new adatbazisEntities())
                {
                    context.Database.Connection.Open();

                    listBox_fazon.DataSource = context.Fazon.ToList();
                    listBox_fazon.DisplayMember = "Nem";
                    listBox_fazon.SelectedItem = null;

                    listBox_szín.DataSource = context.Szín.ToList();
                    listBox_szín.DisplayMember = "Név";
                    listBox_szín.SelectedItem = null;

                    listBox_típus.DataSource = context.Ruhadarab.ToList();
                    listBox_típus.DisplayMember = "Név";
                    listBox_típus.SelectedItem = null;

                    var termekek = from t in context.Termék
                                     join f in context.Fazon on t.FazonFK equals f.FazonID
                                     join r in context.Ruhadarab on t.RuhadarabFK equals r.RuhadarabID
                                     join s in context.Szín on t.SzínFK equals s.SzínID
                                     select new Termek_adat()
                                     {
                                         Fazon = t.Fazon.Nem,
                                         Ruhadarab = t.Ruhadarab.Név,
                                         Szín = t.Szín.Név,
                                     };

                    terméklista = termekek.ToList();
                    dataGridView1.DataSource = terméklista;
   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a paraméterek beolvasása közben: " + ex.Message);
            }
        }


        private void button_torles_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new adatbazisEntities())
                {
                    context.Database.Connection.Open();

                    string s = listBox_szín.GetItemText(listBox_szín.SelectedItem).ToString();
                    string f = listBox_fazon.GetItemText(listBox_fazon.SelectedItem).ToString();
                    string r = listBox_típus.GetItemText(listBox_típus.SelectedItem).ToString();

                    var termek = context.Termék.Where(a => a.Fazon.Nem == f || a.Szín.Név==s || a.Ruhadarab.Név==r).ToList();

                    if (termek.Count>0)
                    {
                        MessageBox.Show("Van ilyen paraméterekkel rendelkező termék, emiatt nem lehet törölni!");
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(s))
                        {
                            var szin = context.Szín.Where(a => a.Név==s).ToList();
                            context.Szín.Remove(szin[0]);
                        }
                        if (!string.IsNullOrEmpty(f))
                        {
                            var fazon = context.Fazon.Where(a => a.Nem == f).ToList();
                            context.Fazon.Remove(fazon[0]);
                        }
                        if (!string.IsNullOrEmpty(r))
                        {
                            var ruhadarab = context.Ruhadarab.Where(a => a.Név == r).ToList();
                            context.Ruhadarab.Remove(ruhadarab[0]);
                        }

                        context.SaveChanges();
                        MessageBox.Show("A paramétert töröltük!");
                    }

                    listBox_fazon.DataSource = context.Fazon.ToList();
                    listBox_szín.DataSource = context.Szín.ToList();
                    listBox_típus.DataSource = context.Ruhadarab.ToList();
                }

                listBox_típus.SelectedItem = null;
                listBox_szín.SelectedItem = null;
                listBox_fazon.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a paraméter törlése közben: " + ex.Message);
            }
        }
    }
}
