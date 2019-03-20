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
    public partial class FormEgitmenler : Form
    {
        EgitmenOgrenci db = DBSingleTon.GetInstance();

        public FormEgitmenler()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Egitmen egt = new Egitmen();
            egt.Ad = txtAd.Text;
            egt.Soyad = txtSoyad.Text;
            db.Egitmenler.Add(egt);
            db.SaveChanges();
            Doldur();
        }

        private void FormEgitmenler_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {
            //List<Egitmen> egtliste= db.Egitmenler.ToList();
            //Egitmen entitysindeki bütün alanları almak için yukarıdaki kodu yazarız.



            //List<MyEntity> egtlistesi = db.Egitmenler.Select(x => new MyEntity
            //{
            //    Numara = x.ID,
            //    Ad = x.Ad,
            //    Soyad = x.Soyad
            //}).ToList();
            //

           
           var egtlistesi = db.Egitmenler.Select(x => new
            {
                x.ID,
                x.Ad,
                x.Soyad

            }).ToList();
            dataGridViewEgitmenler.DataSource = egtlistesi;
        }
    }
}
