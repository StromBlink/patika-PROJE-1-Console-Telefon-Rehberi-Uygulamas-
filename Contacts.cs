using System;
using System.Collections.Generic;
 

namespace TelefonRehberi
{
    class Contacts
    {
           string ad;
         string soyad;
        string telefonNumarasi;

        public  string Ad{get => ad;set => ad = value;}

        public string Soyad{  get => soyad; set => soyad = value; }
        public string TelefonNumarasi { get => telefonNumarasi; set => telefonNumarasi = value; }
        public Contacts(string isim, string soyad, string telefonNumarasi)
        {
            Ad = isim;
            Soyad = soyad;
            TelefonNumarasi = telefonNumarasi;
        }
        public Contacts()
        {
        }
    }

}
