using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            //burda ise dvd isminde yeni bir nesne oluşturuyoruz ve içine dışarıdan aldığımız fieldlerin değerlerini giriyoruz.
            Urun dvd = new Urun(10001, "DVD", 1.20, 0);
            //burda ise dvd nesnesinin stokazaldi metodunu çağırıp stokazaldıeventhandlerine dvd_stokazaldi diye ekleme yapıyoruz.
            dvd.StokAzaldi += new Urun.StokAzaldiEventHandler(dvd_StokAzaldi);
            while (true)
            {
                Console.WriteLine("1-Stok Girişi");
                Console.WriteLine("2-Stok Çıkışı");
                Console.WriteLine("3-İşlem İptali");
                Console.Write("Seçiminiz?(1-2-3): ");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("Stok Girişi Yapılacak Miktarı Giriniz:");
                    int miktar = Convert.ToInt32(Console.ReadLine());
                    dvd.StokMiktari += miktar;
                    Console.WriteLine(dvd.ToString());
                }
                if (secim == 2)
                {
                    try
                    {
                        Console.WriteLine("Stok Çıkışı Yapılacak Miktarı Giriniz:");
                        int miktar = Convert.ToInt32(Console.ReadLine());
                        dvd.StokMiktari -= miktar;
                        Console.WriteLine(dvd.ToString());

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("İnt 32 den fazla sayı girdiniz.{0}",ex);
                    }

                }
                else if (secim == 3)
                {
                    break;
                }

            }



        }
        static void dvd_StokAzaldi()
        {
            Console.WriteLine("Uyarı!!!Stoklarımız Kritik Seviyenin Altında!");
              
        }




    }
}
