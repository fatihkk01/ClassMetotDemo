using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkle(ref ArrayList musteriler,Musteri musteri)
        {
            musteriler.Add(musteri);
        }

        public void MusteriSil(ref ArrayList musteriler,int id)
        {
        
            foreach(Musteri m in musteriler)
            {
                if (m.Id == id)
                {
                    musteriler.Remove(m);
                    break;
                }
            }
        }

        public void MusteriListele(ArrayList musteriler)
        {
            Console.WriteLine("----------MUSTERİLER----------");
            Console.WriteLine("------------------------------");
            foreach (Musteri m in musteriler)
            {
                Console.WriteLine("Id : " + m.Id);
                Console.WriteLine("Ad : " + m.Ad);
                Console.WriteLine("Soyad : " + m.Soyad); 
                Console.WriteLine("------------------------------");
            }
        }

    }
}
