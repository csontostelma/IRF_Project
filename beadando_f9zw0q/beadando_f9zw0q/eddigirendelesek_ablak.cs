using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando_f9zw0q
{
    public partial class eddigirendelesek_ablak : UserControl
    {
        
        public eddigirendelesek_ablak()
        {

            InitializeComponent();

        }

        private void eddigirendelesek_ablak_Load(object sender, EventArgs e)
        {
            Listázás();
        }

        private void Listázás()
        {
            using (var context = new adatbazisEntities())
            {
                context.Database.Connection.Open();

                var rendelések = from x in context.Rendelés
                                 select new
                                 {
                                     Név = x.Név,
                                     Ruhadarab_fazon = x.Termék.Fazon.Nem,
                                     Ruhadarab_tipus = x.Termék.Ruhadarab.Név,
                                     Ruhadarab_méret = x.Termék.Méret.Név,
                                     Ruhadarab_szín = x.Termék.Szín.Név,
                                     Ruhadarab_ár = x.Termék.Ruhadarab.Ár,
                                 };

                dataGridView_eddigirendeles.DataSource = rendelések.ToList();
            }
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kereses = textBox1.Text.ToString();

            using (var context = new adatbazisEntities())
            {
                context.Database.Connection.Open();

                var ruhadarab =context.Ruhadarab.FirstOrDefault(a => a.Név == kereses);
                var list = context.Termék.Select(a => a.RuhadarabFK == ruhadarab.RuhadarabID).ToList();


                var rendelések = from x in context.Rendelés join t in context.Termék on x.TermékFK equals t.TermékID
                                                            join f in context.Fazon on t.FazonFK equals f.FazonID
                                                            join m in context.Méret on t.MéretFK equals m.MéretID
                                                            join r in context.Ruhadarab on t.RuhadarabFK equals r.RuhadarabID
                                                            join s in context.Szín on t.SzínFK equals s.SzínID
                                 where(r.RuhadarabID==ruhadarab.RuhadarabID) 
                                 select new
                                 {
                                     Név = x.Név,
                                     Ruhadarab_fazon = x.Termék.Fazon.Nem,
                                     Ruhadarab_tipus = x.Termék.Ruhadarab.Név,
                                     Ruhadarab_méret = x.Termék.Méret.Név,
                                     Ruhadarab_szín = x.Termék.Szín.Név,
                                     Ruhadarab_ár = x.Termék.Ruhadarab.Ár,
                                 };

                dataGridView_eddigirendeles.DataSource = rendelések.ToList();
            }
        }
    }
}
