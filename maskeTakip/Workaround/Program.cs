using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Degiskenler();
            */

            SelamVer(isim: "Engin");
            SelamVer(isim: "Gorkem");
            SelamVer(isim: "Ahmet");
            SelamVer();
            int sonuc = Topla(6, 58);

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            /*
            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);
            */

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            ogrenciler=new string[4];
            ogrenciler[3] = "İlker";
            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = { "Bursa", "Antalya", "Diyarbakir" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
            foreach(string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            Console.ReadKey();
        }
        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba"+isim);
        }
        static int Topla(int sayi1=5,int sayi2 = 10)
        {
            int sonuc=sayi1+ sayi2;
            Console.WriteLine("Toplam: "+sonuc.ToString());
            return sonuc;
        }

        /*
        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Gorkem";
            string soyad = "Ceyhan";
            int dogumYili = 1999;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
        public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int dogumYili { get; set; }
            public long tcNo { get; set; }
        }
        */

    }
}
