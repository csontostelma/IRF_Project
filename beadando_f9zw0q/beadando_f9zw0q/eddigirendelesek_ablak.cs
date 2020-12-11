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
        adatbazisEntities context = new adatbazisEntities();
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
}
