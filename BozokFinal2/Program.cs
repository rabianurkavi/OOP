using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BozokFinal2
{
    /* EmlakSatisKisi ve ToplantiKisi isimli sınıflarını oluşturun. Bu sınıflar kullanılarak yaratılan nesnelerin kullanabileceği SatisGorusmesi() isimli metodu oluşturun. Ayrıca SatisYap() isimli bir metotu tanımlayıp nesnelerin içindeki
     * alanların aldığı değerleri görüntüleyin(fields). SatisPersonel isimli abstract bir sınıf yazın bu sınıf içinde ad ve soyad alanları ile bu alanlara yazılan verilerin sadece görülmesini  sağlayan property(özellikleri) tanımlayın.
     * Yapıcı kanalıyla ad soyad bilgisinin alınmasını zorunlu kılın.  Bir metot yazın bu metotun miras alan tüm sınıflarca kullanılmasını zorunlu kılın. Bu metot ad ve soyadın bir boşluk ile yanyana görüntülenmesini ve miras alan sınıflarda
     * ne kadar toplam satış yapıldığı ve ne kadar komisyon alındığı bilgisini görünleyecektir.  
      Aşağıdaki işlemleri gerçekleştirecek sınıfları oluşturun.  

a.       EmlakSatisKisi : SatisPersonel ve ToplantiKisi:SatisPersonel sınıflarını oluşturun. EmlakSatisKisi sınıfı içinde o kişinin ne kadar toplam satış yaptığını ve bu satışlardan ne kadar komisyon aldığını tutan alanları (field) oluşturun.
Bu sınıfın içinde default constructor’u (varsayılan yapıcıyı) ezecek static bir yapıcı yazın ve komisyon oranını 2 olarak belirleyin.  Emlak satışı yapan personelin kazandığı komisyon = satiş bedeli * komisyon oranı / 100 şeklindedir. 
Nesneler oluşturuldukları anda toplam satış ve toplam komisyon miktarları 0 olmalıdır. ToplantiKisi sınıfından türetile nesnelerde satılan kurabiye miktarlarının tutulduğu alanlar yaratıldıkları anda 0 değerini almalıdır. Ayrıca bu alan için 
property aracılığı ile satılan kurabiye miktarı sadece görüntülenebilmelidir.

b.       Isatis isimli bir interface oluşturup SatisGorusmesi() ve SatisYap() isimli metotları bu interface e dahil edin. Yukarıda tanımlanan iki sınıf içinde SatisGorusmesi() isimli metotu kullanarak bir iki satırlık işe yarayacak  ifadeleri
görüntüleyin.

c.       EmlakSatisKisi sınıfı SatisYap() metodu ile bir ev için satis bedelini almaktadır. Bu sınıftan bir nesne türetildiğinde bir satış işlemi yaparsa toplam satış miktarı burada alınan degerle toplanmalıdır. ToplantiKisi isimli sınıfda 
SatisYap() metodu içine kaç kutu kurabiye satıldığına dair miktar almaktadır.  Bu metot içinde alınan miktar toplam satılan kurabiye miktarına eklenmelidir.*/
    public class EmlakSatisKisi:SatisPersonel,ISatis
    {
        private int ToplamSatis;
        private int KomisyonTutar;
        private int KomisyonOranı = 2;
        public EmlakSatisKisi(string ad,string soyad):base(ad,soyad)
        {
            KomisyonTutar = (SatisBedeli * KomisyonOranı) / 100;

        }

        public int SatisBedeli { get ; set; }

        public string SatisGorusmesi()
        {
            return "Satıs Gorusmesi Yapildi";
        }

        public int SatisYap()
        {
            return SatisBedeli + ToplamSatis;
        }
    }
    public class ToplantiKisi:SatisPersonel,ISatis
    {
        private int KurabiyeMiktari;
        public int ToplamSatilanKurabiyeMiktari { get; set; }

        public int Kurabiye
        {
            get { return KurabiyeMiktari; }
            set { KurabiyeMiktari = value; }
        }

        public int SatisBedeli { get ; set; }

        public ToplantiKisi(string ad,string soyadi,int KurabiyeMiktarı):base(ad,soyadi)
        {
            Kurabiye = KurabiyeMiktarı;
        }

        public string SatisGorusmesi()
        {
            return "Toplantı icin satis gorusmesi";
        }

        public int SatisYap()
        {
            return KurabiyeMiktari + ToplamSatilanKurabiyeMiktari;
        }
    }
    interface ISatis
    {
        int SatisBedeli { get; set; }
        string SatisGorusmesi();
        int SatisYap();
        
    }
    public abstract class SatisPersonel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public SatisPersonel(string ad,string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }

    }
       
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
