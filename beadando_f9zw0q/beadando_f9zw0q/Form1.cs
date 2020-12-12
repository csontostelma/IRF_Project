using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace beadando_f9zw0q
{
    public partial class Form1 : Form
    {
        List<Rendelés> Rendeléslista = new List<Rendelés>();

        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB; // A létrehozott munkafüzet
        Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül

        public Form1()
        {
            InitializeComponent();
          
 
        }

        private void CreateExcel()
        {
            try
            {
                // Excel elindítása és az applikáció objektum betöltése
                xlApp = new Excel.Application();

                // Új munkafüzet
                xlWB = xlApp.Workbooks.Add(Missing.Value);

                // Új munkalap
                xlSheet = xlWB.ActiveSheet;

                // Tábla létrehozása
                CreateTable(); // Ennek megírása a következő feladatrészben következik

                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) // Hibakezelés a beépített hibaüzenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        private void CreateTable()
        {
            string[] headers = new string[]
            {
                "Ügyfél neve",
                "A ruhadarab fazonja",
                "A ruhadarab típusa",
                "A ruhadarab mérete",
                "A ruhadarab színe",
                "A ruhadarab ára (Ft)"
            };

            for (int i = 0; i < headers.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = headers[i];
            }

            object[,] values = new object[Rendeléslista.Count, headers.Length];

            int counter = 0;
            foreach (var f in Rendeléslista)
            {
                values[counter, 0] = f.Név;
                values[counter, 1] = f.Termék.Fazon.Nem;
                values[counter, 2] = f.Termék.Ruhadarab.Név;
                values[counter, 3] = Enum.GetName(typeof(Meret), f.Termék.Méret.Ruha_nagysaga);
                values[counter, 4] = f.Termék.Szín.Név;
                values[counter, 5] = f.Termék.Ruhadarab.Ár;
                counter++;

            }

            xlSheet.get_Range(GetCell(2, 1), GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;

            FormatTable();

        }


        private void FormatTable()
        {
            int lastRowID = xlSheet.UsedRange.Rows.Count;
            int lastColumn = xlSheet.UsedRange.Columns.Count;

            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, lastColumn));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.LightBlue;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range tableRange = xlSheet.get_Range(GetCell(1, 1), GetCell(lastRowID, lastColumn));
            tableRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range firstColumn = xlSheet.get_Range(GetCell(2, 1), GetCell(lastRowID, 1));
            firstColumn.Font.Bold = true;
            firstColumn.Interior.Color = Color.LightYellow;

            Excel.Range LastColumn = xlSheet.get_Range(GetCell(2, lastColumn), GetCell(lastRowID, lastColumn));
            LastColumn.Interior.Color = Color.LightGreen;
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
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

        private void button_rendeléstörlés_Click(object sender, EventArgs e)
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
        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            using (var context = new adatbazisEntities())
            {
                Rendeléslista = context.Rendelés.ToList();
                CreateExcel();
            }
            
        }
    }
}
