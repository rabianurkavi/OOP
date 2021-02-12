using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualkalıtım
{
    public class Personel
    {
        public string AdSoyad;
        protected decimal Maas;
        public Personel(string adsoyad,decimal maas)
        {
            AdSoyad = adsoyad;
            Maas = maas;
        }
        public virtual decimal MaasHesapla()
        {
            return Maas;
        }
        public string Goster()
        {
          return AdSoyad + " " + Maas + " ";
        }
        

    }
    public class Isci:Personel
    {
        public Isci(string adsoyad,decimal maas):base(adsoyad,maas)
        {

        }
    }
    public class SatisElemanı:Personel
    {
        decimal satisbonusu = 0;
        public SatisElemanı(string adsoyad,decimal maas,decimal bonus):base(adsoyad,maas)
        {
            satisbonusu = bonus;
        }
        public override decimal MaasHesapla()
        {
            return Maas + satisbonusu;
        }
       
    }
    public class Urun
    {
        public string İsim { get; set; }
        //private double KdvsizFiyat { get; set; }//private olunca diğer yerlerden çağırılmıyor bunun için aşağıdaki gibi tanımlayıp get setleyebiliriz
        //kapsülleme kullanmak istemiyorsak yukardakini public yapmamız da yeterli.
        private double KdvsizFiyat;
        public double Kdvsizfiyat
        {
            get { return KdvsizFiyat; }
            set { if (value < 0)
                    KdvsizFiyat = Math.Abs(value);
                    }

        }
        public Urun(string isim,double kdvsizfiyat)
        {
            İsim = isim;
            KdvsizFiyat = kdvsizfiyat;

        }
        public virtual double KdvHesapla()
        {
            return KdvsizFiyat * 1.18f;
        }
    }
    public class Tv : Urun
    {
        private string EkranBoyutu { get; set; }
        public bool UHDVarMi { get; set; }
        public Tv(string ekran, bool uhd, string isim, double kdvsizfiyat) : base(isim, kdvsizfiyat)
        {
            EkranBoyutu = ekran;
            UHDVarMi = uhd;

        }
        public override double KdvHesapla()
        {
            return Kdvsizfiyat * 1.4f;
        }
    }
    public class Mp3:Urun
    {
        private int SesGucu { get; set; }
        public bool Surround { get; set; }
        public Mp3(int Ses,bool s,string i,double kdvsizfiyat):base(i,kdvsizfiyat)
        {
            SesGucu = Ses;
            Surround = s;
        }
        public override double KdvHesapla()
        {
            return Kdvsizfiyat * 2f;
        }
    }
    public class EkleHesapla
    {
        public List<Urun> urunlistele = new List<Urun>();
        double toplamfiyat = 0;
       //urunlistele bu kısımda hiç bir metot çağıramaz.
        public void Listele()
        {
            //urunlisteyi listelemek için urun sınıfından nesne belirtip foreach ile urunlistele şeklinde yazdırmamız gerekir.
            
            foreach(Urun urun in urunlistele)
            {
                toplamfiyat += urun.KdvHesapla();
                Console.WriteLine("Ürün Adı: {0} Kdvsiz Fiyat: {1} Kdvli Fiyat: {2} ",urun.İsim, urun.Kdvsizfiyat, urun.KdvHesapla());
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Toplam fiyat: {0}", toplamfiyat);
        }
        public void UrunEkle(Urun urun)
        {
            urunlistele.Add(urun);
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            SatisElemanı satisElemanı = new SatisElemanı("Rabia Nur Kavi",8500,400);
            //Console.WriteLine("Adı Soyadı: {0} Maası: {1} ",satisElemanı.AdSoyad ,satisElemanı.MaasHesapla());
            Console.WriteLine(satisElemanı.Goster() + satisElemanı.MaasHesapla());//bu şekilde de yazılabilir.
            Personel personel = new Personel("Ayşe Çalışkan ",1500);
           Console.WriteLine(personel.Goster());
            Mp3 mp3 = new Mp3(20,true,"asda",1200);

            //EkleHesapla ekleHesapla = new EkleHesapla();
            //ekleHesapla.UrunEkle(new Urun("Test ürünü", 2500));
            //ekleHesapla.UrunEkle(new Mp3(120, true, "pioneer", 1200));
            //ekleHesapla.UrunEkle(new Tv("2500x1250", true, "Vestel", 2450));
            //ekleHesapla.Listele();
            Console.ReadKey();
        }
    }
}
