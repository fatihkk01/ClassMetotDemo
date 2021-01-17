using System;
using System.Collections;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri m1 = new Musteri();
            m1.Id = 1;
            m1.Ad = "Hakan";
            m1.Soyad = "Akpınar";

            Musteri m2 = new Musteri();
            m2.Id = 2;
            m2.Ad = "Ali";
            m2.Soyad = "Yıldırım";

            Musteri m3 = new Musteri();
            m3.Id = 3;
            m3.Ad = "Kemal";
            m3.Soyad = "Arslan";

            Musteri m4 = new Musteri();
            m4.Id = 4;
            m4.Ad = "Mehmet";
            m4.Soyad = "Poyraz";


            ArrayList musteriler = new ArrayList();

            musteriler.Add(m1);
            musteriler.Add(m2);
            musteriler.Add(m3);

            

            //LİSTELEME
            musteriManager.MusteriListele(musteriler);

            //EKLEME
            musteriManager.MusteriEkle(ref musteriler, m4);

            musteriManager.MusteriListele(musteriler);

            //SİLME
            musteriManager.MusteriSil(ref musteriler, 1);

            musteriManager.MusteriListele(musteriler);





        }
    }
}
