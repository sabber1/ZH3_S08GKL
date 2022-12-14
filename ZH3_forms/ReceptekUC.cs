using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3_forms.ReceptModels;

using Excel = Microsoft.Office.Interop.Excel;

namespace ZH3_forms
{
    public partial class ReceptekUC : UserControl
    {
        ReceptContext context = new ReceptContext();

        Excel.Application xlApp;
        Excel.Workbook xlWb;
        Excel.Worksheet xlWs;

        public ReceptekUC()
        {
            InitializeComponent();
            ListFogas();
            ListHozzavalok();
            Dock = DockStyle.Fill;
        }

        private void ListFogas()
        {
            var fogasok = from x in context.Fogasoks
                          where x.FogasNev.Contains(textBox1.Text)
                          select x;

            listBox1.DataSource = fogasok.ToList();
            listBox1.DisplayMember = "FogasNev";
        }

        private void ListHozzavalok()
        {
            Fogasok fogas = (Fogasok)listBox1.SelectedItem;

            var items = from x in context.Recepteks
                        where x.FogasId == fogas.FogasId
                        select new Hozzavalo
                        {
                            FogasId = x.FogasId,
                            ReceptId = x.ReceptId,
                            Név = x.Nyersanyag.NyersanyagNev,
                            Mennyiség4 = x.Mennyiseg4fo,
                            MennyisegiEgysegs = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                            EgysÁr = x.Nyersanyag.Egysegar
                        };

            hozzavaloBindingSource1.DataSource = items.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListFogas();
            ListHozzavalok();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListHozzavalok();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hozzavalo hozzavalo = (Hozzavalo)hozzavaloBindingSource1.Current;

            var toDelete = (from x in context.Recepteks
                            where x.ReceptId == hozzavalo.ReceptId
                            select x).FirstOrDefault();

            if (MessageBox.Show(
                "Biztosan törölni szeretnéd ezt a rekordor?", 
                "Törlés", 
                MessageBoxButtons.YesNo) 
                == DialogResult.No)
            {
                return;
            }

            try
            {
                context.Recepteks.Remove(toDelete);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ListHozzavalok();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                xlApp = new Excel.Application();
                xlWb = xlApp.Workbooks.Add(Missing.Value);
                xlWs = xlWb.ActiveSheet;

                GenerateExcel();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateExcel()
        {
            // Adatok 

            string[] fejlec = { "Név", "Mennyiság 4 főre", "Mennyiségi egység", "Ár" };

            Fogasok fogas = (Fogasok)listBox1.SelectedItem;

            var items = (from x in context.Recepteks
                        where x.FogasId == fogas.FogasId
                        select new Hozzavalo
                        {
                            FogasId = x.FogasId,
                            ReceptId = x.ReceptId,
                            Név = x.Nyersanyag.NyersanyagNev,
                            Mennyiség4 = x.Mennyiseg4fo,
                            MennyisegiEgysegs = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                            EgysÁr = x.Nyersanyag.Egysegar
                        }).ToList();

            // Adatok betölrése

            object[,] adatTomb = new object[items.Count(), fejlec.Count()];

            int sorokSzama = adatTomb.GetLength(0);
            int oszlopokSzama = adatTomb.GetLength(1);

            for (int i = 0; i < fejlec.Count(); i++)
            {
                xlWs.Cells[1, i + 1] = fejlec[i];
            }

            for (int i = 0; i < items.Count(); i++)
            {
                // adatTomb[i, 0] = items[i].FogasId;
                adatTomb[i, 0] = items[i].Név;
                adatTomb[i, 1] = items[i].Mennyiség4;
                adatTomb[i, 2] = items[i].MennyisegiEgysegs;
                adatTomb[i, 3] = items[i].EgysÁr;
            }

            Excel.Range adatRange = xlWs.get_Range("A2", Type.Missing).get_Resize(sorokSzama, oszlopokSzama);
            adatRange.Value2 = adatTomb;

            Excel.Range fejlecRange = xlWs.get_Range("A1", Type.Missing).get_Resize(1, oszlopokSzama);
            fejlecRange.Font.Bold = true;
            fejlecRange.Font.Size = 20;
            fejlecRange.Interior.Color = Color.CadetBlue;
            fejlecRange.EntireColumn.AutoFit();
            fejlecRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fejlecRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            fejlecRange.RowHeight = 30;
        }
    }
}
