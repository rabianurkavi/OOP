using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınav2
{
    /*Bir Şahıs sınıfı oluşturun.Bu sınıfa bağlı ekrana Öğretmen ve Öğrenci iki sınıf oluşturun.Sınıfın Özellikleri: 
     * Şahıs ve diğerleri: Ad Soyad cinsiyet bilgileri içersin.
     * "BilgiGoster" adı altında bir yordam sınıfın hangi sınıf olduğunu ve sınıfa ait ad,soyad,cinsiyet bilgilerini göstersin.Bu yordam kesinlikle girilmesi sorumlu bir yordam olsun
     * Öğretmen ve Öğrenci için yapıcı tanımlansın.
     */
    public abstract class Sahis
    {
       
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public Sahis(string ad,string soyad,string cinsiyet)
        {
            
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
        }
        public abstract void BilgiGöster( );
        
    }
    public class Ogretmen : Sahis
    {
        public override void BilgiGöster()
        {
            string bilgi = "";
            bilgi += Ad + " " + Soyad + " " + Cinsiyet + " " + this.GetType().Name;
            Console.WriteLine(bilgi);
        }
        public Ogretmen( string ad, string soyad, string cinsiyet):base(ad,soyad,cinsiyet)
        {
            
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
        }
    }
    public class Ogrenci : Sahis
    {
        public override void BilgiGöster()
        {
            string bilgi = "";
            bilgi += Ad + " " + Soyad + " " + Cinsiyet + " " + this.GetType().Name;
            Console.WriteLine(bilgi);
        }
        public Ogrenci( string ad, string soyad, string cinsiyet) : base( ad, soyad, cinsiyet)
        {
            
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Ogrenci ogrenci = new Ogrenci("Rabia", "Kavi", "Kadın");
            ogrenci.BilgiGöster();
           

            Console.ReadLine();
        }
    }
}
