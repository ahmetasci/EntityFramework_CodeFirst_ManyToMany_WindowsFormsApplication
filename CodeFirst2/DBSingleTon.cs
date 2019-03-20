using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst2
{
    class DBSingleTon
    {
        //Veritabanına bağlantı tanımlıyoruz.
        private static EgitmenOgrenci db;
        public static EgitmenOgrenci GetInstance()
        {
            if (db==null)
            {
                db = new EgitmenOgrenci();
            }
            return db;
        }
    }
}
