using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst2
{
    public partial class Formİliski : Form
    {
        EgitmenOgrenci db = DBSingleTon.GetInstance();
        public Formİliski()
        {
            InitializeComponent();
        }

        private void btnIlıskilendir_Click(object sender, EventArgs e)
        {   //***********************1.YOL*************************


            //Egitmen seciliEgitmen = cmbBxEgitmenler.SelectedItem as Egitmen;
            //var egitmen = db.Egitmenler.Find(seciliEgitmen.ID);
            //foreach (Ogrenci item in lstBxOgrenciler.SelectedItems)
            //{
            //    egitmen.ogrenciler.Add(item);
            //}
            //db.SaveChanges();

            //lstBxOgrenciler.SelectedItems.Clear();
            //dataGridViewİliski.DataSource = egitmen.ogrenciler.ToList();

            //**********************2.YOL******************************************
            int seciliEgitmenId = Convert.ToInt32(cmbBxEgitmenler.SelectedValue);
            Egitmen egitmen = db.Egitmenler.Find(seciliEgitmenId);

            foreach (MyEntry item in lstBxOgrenciler.SelectedItems)
            {
                Ogrenci ogrSelected = db.Ogrenciler.Find(item.OgrenciID);
                egitmen.ogrenciler.Add(ogrSelected);
            }

            db.SaveChanges();
            lstBxOgrenciler.SelectedItems.Clear();
            dataGridViewİliski.DataSource = egitmen.ogrenciler.ToList();


        }
        private void cmbDoldur()
        {
            var elist = db.Egitmenler.Select(x => new
            {
                x.ID,
                FullName = x.Ad + " " + x.Soyad,
            }).ToList();

            cmbBxEgitmenler.DisplayMember = "FullName";
            cmbBxEgitmenler.ValueMember = "ID";
            cmbBxEgitmenler.DataSource = elist;
        }
        private void LstBoxDoldur()
        {
            lstBxOgrenciler.DataSource = db.Ogrenciler.Select(x => new MyEntry
            {
                
                FullName = x.Ad + " " + x.Soyad,
                OgrenciID = x.ID,
            }).ToList();
            /*
           ctx.Ogrenciler.Select(x=> new ......
           {

           }).ToList();     şeklinde oluşturduğumuz lambda expression'ın ismi ve türü yok. Anonymous type. Buna isim ve tür vermek için 
           MyEntry yazdık ve bu Yukarıdaki MyEntity için Solution Explorerda MyEntry.cs isimli bir class oluşturduk.

           */
            lstBxOgrenciler.ValueMember = "OgrenciID";
            lstBxOgrenciler.DisplayMember = "FullName";
            
            lstBxOgrenciler.SelectionMode = SelectionMode.MultiExtended;//Ctrl ile birden fazla kayıt seçilebilir.    
        }
        private void Formİliski_Load(object sender, EventArgs e)
        {
            cmbDoldur();
            LstBoxDoldur();

           
            //***************************1.YOL İÇİN***************************
            //lstBxOgrenciler.DisplayMember = "Ad";
            ////lstBxOgrenciler.ValueMember = "ID";
            //lstBxOgrenciler.DataSource = db.Ogrenciler.ToList();
            //cmbBxEgitmenler.DisplayMember = "Ad";
            //cmbBxEgitmenler.DataSource = db.Egitmenler.ToList();
        }

        private void cmbBxEgitmenler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int seciliEgitmenId = Convert.ToInt32(cmbBxEgitmenler.SelectedValue);
            Egitmen egitmen = db.Egitmenler.Find(seciliEgitmenId);
            dataGridViewİliski.DataSource = egitmen.ogrenciler.ToList();


        }
    }
}
