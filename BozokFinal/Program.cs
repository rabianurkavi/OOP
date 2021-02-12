using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BozokFinal
{ /* Vize            %30
Ödev           %20  (Ödev sayısı döneme göre değişken yapıdadır)
Final           %50
Dersi ilk defa alan öğrenciler için; derse gelmenin ve yapılan uygulamalarda artı almak, ödev notunu belirli oranda etkileyecektir. Dersi alttan alan öğrenciler içinse ödev notunun sadece ödevlerin ortalamasından verileceği belirtilmiştir.
Bu bilgiler ışığı altında aşağıda kuralları belirtilen, başka sınıflar tarafından miras alınamayan sınıfı ve bu sınıfın bağlı olduğu (miras verdiği) interface’i oluşturun. (Sınıf adı: DersHesap, Interface Adı: IDersHesap)

Vize (double), Ödev (double bir dizi şeklinde), Final (double), Derse Geliş Saat(int), Uygulama Artısı Sayısı(int), Dersi Alttan Alan (bool) değerlerini constructor(yapıcı) ile alın.
Uygulama no90, 70, 100 
notlarını alan bir öğrencinin ortalaması 85’tir. Gelen dizideki ödevleri alıp ortalamasını hesaplayın. foreach döngüsü kullanılacaktır). Dersi ilk defa alan bir öğrencinin uygulama notu fonksiyonundan dönen değer ve ötu hesaplayan fonksiyonu yazın. (Fonksiyon Adı: UygulamaNotHesapla). Derse geliş değerini 0.5 ile, uygulama artısını 3 ile çarpıp uygulama notunu double şeklinde gönderin. Hata yakalama kullanarak herhangi bir hata oluşması
durumunda 0 dönderin. (Örneğin, 40 saat derse gelmiş ve 7 uygulama artısı almış bir öğrenci 40*0.5 + 7*3 = 41 puan kazanır.) Eğer, uygulama notu 100’den büyükse 100 değerini döndürün.
Ödev notunu hesaplayan double tipinde property’i yazın. (Property adı: OdevNotu) Eğer dersi alttan alan bir öğrenci ise sadece dizi şeklinde gelen ödevlere verilen puanların ortalamasını alın. (Örneğin, 4 ödev verilmişse 80, dev notunu 0.4 katsayısı
ile çarparak toplayın. (Yukarıdan 41 puan uygulama notu ve ödevden 85 alan bir öğrenci için 41 + 85 * 0.4 = 75 ödev notunu alır.) Eğer, ödev notu 100’den büyükse 100 değerini döndürün.
Başarı notunu hesaplayan property’i yazın. (Property Adı: BasariNot) Ödev notu özelliğini (property) ve contructordan alınan vize ve final değerlerini kullanıp yukarıdaki şarta göre hesaplayın.
Main bölümünde dersi alttan alan ve ilk defa alan öğrenci için nesneleri oluşturun ve başarı notunu ekrana yazdırın.*/
    public class DersHesap:IDersHesap
    {
        public double Vize;
        public double[] Dizi;
        public double Final;
        public int DerseGelisSaat;
        public int UygulamaArtısı;
        public bool AlttanAlan;
        public double OdevNotu { get; set; }
        public double BasariNotu { get; set; }
        public double OdevHesapla()
        {
            double toplam = 0;
            double ortalama;
            int i=0;
            foreach (double Dizim in Dizi)
            {

                toplam += Dizi[i];
                i++;

            }
            ortalama = toplam / i + 1;
            if (ortalama > 100)
            {
                ortalama = 100;
            }
            if (AlttanAlan == true)
            {
                OdevNotu = ortalama;
                return OdevNotu;
            }
            else 
            {
                OdevNotu = ortalama * 0.4 + UygulamaNotHesapla();
                return OdevNotu;
            }
        }
        public DersHesap(double vize,double [] dizi,double final,int gelissaat,bool alttana,int uygulama)
        {
            Vize = vize;
            Dizi = dizi;
            Final = final;
            DerseGelisSaat = gelissaat;
            AlttanAlan = alttana;
            UygulamaArtısı = uygulama;

        }
        public double BasariNotuHesapla()
        {
            BasariNotu = (Vize * 0.3) + (Final * 0.5) + (OdevHesapla() * 0.2);
            return BasariNotu;
        }
      
        public double UygulamaNotHesapla()
        {
            try
            {
                double uygulamanotu= ((double)DerseGelisSaat * 0.5) +(UygulamaArtısı * 3);
                if(uygulamanotu>100)
                {
                    uygulamanotu = 100;
                }
                return uygulamanotu;
            }
            catch(Exception)
            {
                return 0;
            }
        }
    }
    interface IDersHesap
    {
         double BasariNotu { get; set; }
         double OdevNotu { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DersHesap hesap = new DersHesap(70,new double [] { 45, 12, 8, 7 },80,4, true, 4);
            Console.WriteLine( hesap.BasariNotuHesapla());
            Console.ReadKey();
           
            
           
        }
    }
}
 