using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;
using beadando_f9zw0q.Adatbázis;

namespace beadando_f9zw0q
{
    public class Excelmenedzser
    {
        List<Rendelés> Rendeléslista = new List<Rendelés>();

        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB; // A létrehozott munkafüzet
        Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül

        public Excelmenedzser()
        {
            using (var context = new adatbazisEntities())
            {
                Rendeléslista = context.Rendelés.ToList();
                CreateExcel();
            }
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
            headerRange.RowHeight = 30;
            headerRange.Interior.Color = Color.LightCoral;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);

            Excel.Range tableRange = xlSheet.get_Range(GetCell(1, 1), GetCell(lastRowID, lastColumn));
            tableRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range firstColumn = xlSheet.get_Range(GetCell(2, 1), GetCell(lastRowID, 1));

            Excel.Range LastColumn = xlSheet.get_Range(GetCell(2, lastColumn), GetCell(lastRowID, lastColumn));
            LastColumn.Interior.Color = Color.LightSteelBlue;
            LastColumn.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            LastColumn.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;

            Excel.Range thirdColumn= xlSheet.get_Range(GetCell(2, 3), GetCell(lastRowID, 3));
            thirdColumn.Font.Italic = true;
            thirdColumn.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            thirdColumn.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;

            Excel.Range secondColumn= xlSheet.get_Range(GetCell(2, 2), GetCell(lastRowID, 2));
            secondColumn.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            secondColumn.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;

            Excel.Range fourthColumn= xlSheet.get_Range(GetCell(2, 4), GetCell(lastRowID, 4));
            fourthColumn.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fourthColumn.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;

            Excel.Range fifthColumn=xlSheet.get_Range(GetCell(2, 5), GetCell(lastRowID, 5));
            fifthColumn.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fifthColumn.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;


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

    }
}
