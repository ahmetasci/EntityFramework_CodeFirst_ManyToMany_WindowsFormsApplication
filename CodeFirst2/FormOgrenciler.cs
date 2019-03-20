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
    public partial class FormOgrenciler : Form
    {
        EgitmenOgrenci db = DBSingleTon.GetInstance();
        public FormOgrenciler()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Ad = txtAd.Text;
            ogr.Soyad = txtSoyad.Text;
            db.Ogrenciler.Add(ogr);
            db.SaveChanges();
            Doldur();
        }
        private void Doldur()
        {
            dataGridViewOgrenciler.DataSource = db.Ogrenciler.Select(x => new
            {
                x.ID,
                x.Ad,
                x.Soyad

            }).ToList();
        }

        private void FormOgrenciler_Load(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
