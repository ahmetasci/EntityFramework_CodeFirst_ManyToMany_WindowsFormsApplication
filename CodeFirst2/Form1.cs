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
    /*
    Code First ile Visual üzerinde SQL Veritabanı ve tablolar oluşturduk.
    Form1'de Menustripteki isimlendirmelere göre ilgili form ekranlarına atacak.
    FormOgrenci ekranında öğrencileri için girilen ad ve soyad bilgilerini dataGridviewda gösterip veritabanındaki Ogrenci tablosuna,
    FormEgitmen ekranında eğitmenler için girilen ad ve soyad bilgilerini dataGridViewda gösterip veritabanındaki Egitmen tablosuna atacak.
    Formİliski ekranında listboxtan seçilen öğrencilerle, comboBoxtan seçilen eğitmeni ilişkilendir butonuna basınca ilişkilendirip, 
    dataGridViewda gösterip veritabanındaki OgrenciEgitmen tablosuna ekleyecek.
    Daha sonra migration alacağız.

        Migration: Mevcut ile geliştirilmiş database'i kıyaslar, farkları bulur.Farkları barındıran düzenleme kodlarını oluşturur.

    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void öĞRENCİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOgrenciler frmogrenci = new FormOgrenciler();
            frmogrenci.Show();
          
        }

        private void eĞİTMENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEgitmenler frmegitmen = new FormEgitmenler();
            frmegitmen.Show();
        }

        private void öĞRENCİEĞİTMENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formİliski frmiliski = new Formİliski();
            frmiliski.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
    }
}
