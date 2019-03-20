namespace CodeFirst2
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations; //Tablolarla ilgili k�s�tlar (anotey�in)
    using System.ComponentModel.DataAnnotations.Schema;//Schemalarla ilgili k�s�tlar
    using System.Data.Entity;
    using System.Collections.Generic;

    public class EgitmenOgrenci : DbContext
    {

   
        public EgitmenOgrenci()
            : base("name=EgitmenOgrenci")
        {
        }
        public virtual DbSet<Egitmen> Egitmenler { get; set; }
        
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        
    }
    [Table("Ogrenci")]
    public class Ogrenci
    {
        public Ogrenci()
        {
            this.egitmenler = new HashSet<Egitmen>();//Performans�n� art�r�yor.
        }
      
        [Key] //Key yazarsak primary key oldu�unu belirtiyoruz.
        public int ID { get; set; }
        //ID,Ad,Soyad kolonlar�n� olu�turdu
        public string Ad { get; set; }
        public string Soyad { get; set; }
        

        public virtual ICollection<Egitmen> egitmenler { get; set; }
        //Bire�ok ili�ki. Bir ��rencinin birden fazla e�itmeni olabilir.
    }
    [Table("Egitmen")]
    public class Egitmen
    {
        public Egitmen()
        {
            this.ogrenciler = new HashSet<Ogrenci>();//Performans�n� art�r�yor.
        }
        //Key yazarsak primary key oldu�unu belirtiyoruz.
        [Key]
        public int ID { get; set; }
        //ID,Ad,Soyad kolonlar�n� olu�turdu
        public string Ad { get; set; }
        public string Soyad { get; set; }
        

        public virtual ICollection<Ogrenci> ogrenciler { get; set; }
        //Bire�ok ili�ki. Bir e�itmenin birden fazla ��retmeni olabilir.

        //Genel anlamda �OKA�OK ili�ki
        //�ki tabloyu da ICollection ile yapt�k.
    }

}