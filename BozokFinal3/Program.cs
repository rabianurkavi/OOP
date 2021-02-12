using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BozokFinal3
{ /* Abstract (Soyut) bir Kisi sınıfı oluşturun bu sınıfın kurucusu olarak ad_soyad ve bolum bilgileri kurucu ile girilmek zorunda olsun. Müdür ve Satis sınıfları oluşturun bu iki sınıf da Kisi sınıfından miras alsın ve maaşları kendilerine göre
    hesaplansın. Müdür Kisi sınıfı içinde tanımlanan asgari ücretin 3 katını, satis personeli ise kurucu ile girilecek bonus kadar ekstra para alsın. Maaş değişkeni sadece okunabilir olsun. Maaş değişkeni dışarıdan değiştirilemesin.*/
    public abstract class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string BolumBilgileri { get; set; }
        public double AskeriUcret { get; set; }
        public Kisi(string ad ,string soyad,string Bolumbilgileri)
        {
            Ad = ad;
            Soyad = soyad;
            BolumBilgileri = Bolumbilgileri;
        }
        public abstract double MaasHesapla();
    }
    public class Mudur:Kisi
    {
        private double Maas;
        public Mudur(string ad,string soyad,string Bolumbilgileri) :base(ad,soyad,Bolumbilgileri)
        {

        }

        public override double MaasHesapla()
        {
            Maas = AskeriUcret * 3;
            return Maas;
        }
    }
    public class Satis:Kisi
    {
        public double SatisBonusu { get; set; }
        public Satis(string ad,string soyad,string Bolum,double satisbonusu):base(ad,soyad,Bolum)
        {
            SatisBonusu = satisbonusu;
        }

        public override double MaasHesapla()
        {
            return AskeriUcret + SatisBonusu;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mudur mudur = new Mudur("Rabia", "Kavi", "Yazılım Uzmanı");
            mudur.AskeriUcret = 4500;
            Console.WriteLine(mudur.MaasHesapla());
            Console.ReadLine();


        }
    }
}
