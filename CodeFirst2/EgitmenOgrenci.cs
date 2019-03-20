namespace CodeFirst2
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations; //Tablolarla ilgili kýsýtlar (anoteyþin)
    using System.ComponentModel.DataAnnotations.Schema;//Schemalarla ilgili kýsýtlar
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
            this.egitmenler = new HashSet<Egitmen>();//Performansýný artýrýyor.
        }
      
        [Key] //Key yazarsak primary key olduðunu belirtiyoruz.
        public int ID { get; set; }
        //ID,Ad,Soyad kolonlarýný oluþturdu
        public string Ad { get; set; }
        public string Soyad { get; set; }
        

        public virtual ICollection<Egitmen> egitmenler { get; set; }
        //Bireçok iliþki. Bir Öðrencinin birden fazla eðitmeni olabilir.
    }
    [Table("Egitmen")]
    public class Egitmen
    {
        public Egitmen()
        {
            this.ogrenciler = new HashSet<Ogrenci>();//Performansýný artýrýyor.
        }
        //Key yazarsak primary key olduðunu belirtiyoruz.
        [Key]
        public int ID { get; set; }
        //ID,Ad,Soyad kolonlarýný oluþturdu
        public string Ad { get; set; }
        public string Soyad { get; set; }
        

        public virtual ICollection<Ogrenci> ogrenciler { get; set; }
        //Bireçok iliþki. Bir eðitmenin birden fazla öðretmeni olabilir.

        //Genel anlamda ÇOKAÇOK iliþki
        //Ýki tabloyu da ICollection ile yaptýk.
    }

}