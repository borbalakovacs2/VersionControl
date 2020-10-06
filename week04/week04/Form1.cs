using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace week04
{
    public partial class Form1 : Form
    {
        private RealEstateEntities1 context = new RealEstateEntities1();
        private List<Flat> Flats;
        private Excel.Application xlApp;
        private Excel.Workbook xlWB;
        private Excel.Worksheet xlSheet;
        private string[] headers = new string[] {
            "Kód",
            "Eladó",
            "Oldal",
            "Kerület",
            "Lift",
            "Szobák száma",
            "Alapterület (m2)",
            "Ár (mFt)",
            "Négyzetméter ár (Ft/m2)"};


        public Form1()
        {
            InitializeComponent();
            LoadData();
            CreateExcel();
            CreateTable();
            FormatTable();
        }

        private void LoadData()
        {
            Flats = context.Flats.ToList();
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
                //  CreateTable(); // Ennek megírása a következő feladatrészben következik

                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
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
            for (int i = 0; i < headers.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = headers[i];
            }

            object[,] values = new object[Flats.Count, headers.Length];
            int counter = 0;
            foreach (var f in Flats)
            {
                values[counter, 0] = f.Code;
                values[counter, 1] = f.Vendor;
                values[counter, 2] = f.Side;
                values[counter, 3] = f.District;
                if (f.Elevator == true)
                {
                    values[counter, 4] = "Van";
                }
                else
                {
                    values[counter, 4] = "Nincs";
                }
                values[counter, 5] = f.NumberOfRooms;
                values[counter, 6] = f.FloorArea;
                values[counter, 7] = f.Price;
                values[counter, 8] = "=" + GetCell(counter + 2, 7) + "*" + GetCell(counter + 2, 8);
                counter++;
            }
            xlSheet.get_Range(
                GetCell(2, 1),
                GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;
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
        private void FormatTable()
        {
            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.LightBlue;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            int lastRowID = xlSheet.UsedRange.Rows.Count;
            int lastColumnID = xlSheet.UsedRange.Columns.Count;
            Excel.Range dataRange = xlSheet.get_Range(GetCell(2, 1), GetCell(lastRowID, lastColumnID));
            dataRange.Cells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            dataRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range firstColumn = xlSheet.get_Range(GetCell(2, 1), GetCell(lastRowID, 1));
            firstColumn.Font.Bold = true;
            firstColumn.Interior.Color = Color.LightYellow;

            Excel.Range lastColumn = xlSheet.get_Range(GetCell(2, lastColumnID), GetCell(lastRowID, lastColumnID));
            lastColumn.Interior.Color = Color.LightGreen;
            lastColumn.NumberFormat = "0.00";

        }
    }
}