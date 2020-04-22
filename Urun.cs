using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
   public class Urun
    {
        public delegate void StokAzaldiEventHandler();
        public event StokAzaldiEventHandler StokAzaldi;
        /// <summary>
        /// /////////////////////////////////////////7
        /// </summary>
        ///İlk kısım:
        ///Private olarak fieldlerımızı tanımladıktan sonra private oldukları için get ve set(prop)larını açıyoruz.
        ///fakat stokMiktarı fieldının set ine ise  değeri 10dan küçük  ve boş ise StokAzaldi(); metodunu çağırmasını istiyoruz.
        
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _ad;
        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        private double _birimFiyat;
        public double BirimFiyat
        {
            get { return _birimFiyat; }
            set { _birimFiyat = value; }
        }
        private int _stokMiktari;
        public int StokMiktari
        {
            get { return _stokMiktari; }
            set
            {
                _stokMiktari = value;
                if (value < 10 && StokAzaldi != null)
                {
                    StokAzaldi();
                }




            }
        }
        ///İkinci Kısım:
        ///Urun adlı constructor umuzu dışardan aldığımız bu fieldlara atıyoruz ve ordaki vieldları da getini ve setini aldığımız fieldlara atıyoruz.
        public Urun(int id,string adi,double fiyati,int stokSayisi)
        {
            Id = id;
            Ad = adi;
            BirimFiyat = fiyati;
            StokMiktari = stokSayisi;
        }
        //Burda ise toString metodunu override(değiştirilebilir olarak tanımlıyoruz çünkü içine aldığı her değer değişeceği için override yapıyoruz.
        //ve buradaki ad fieldını ve buradaki stokmiktarı fieldini to stringe çevirip metodun içine bırakıyoruz.
        public override string ToString()
        {
            return this.Ad + " için stok miktarı" + this.StokMiktari.ToString();
        }




    }
}
