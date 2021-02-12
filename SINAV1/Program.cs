using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAV1
{   /*"Sahis " adında bir AdSoyad Maas ve Gorev türünden bilgileri tutan bir class yaratın.Bu sınıfın özelliklerini kullanan aşağıda maddelenmiş
    sınıfları oluşturu.
    -Müdür maası hesaplanırken normal maaşın iki katı olarak hesaplansın.
    -Satış Elemanı maaşı hesaplanırken maaaşa istenen oranda bonus eklensin.
    -Bekci maası direkt sahis maasi kullanılarak hesaplanabilsin.
    -tüm classlarda görev adında mecbur girilmesi gereken bir yordam tanımlayın.
    */

    public abstract class Sahis
    {
        public string AdSoyad { get; set; }
        public int Maas { get; set; }
        public abstract string Görev();
        public virtual double MaasHesapla(int maas)
        {
            Maas = maas;
            return Maas;
        }
      
    }
    public class SatisElamanı : Sahis
    {
        public int satisbonusu { get; set; }
        public override double MaasHesapla(int maas)
        {
            return maas + satisbonusu;
        }
        public override string Görev()
        {
            throw new NotImplementedException();
        }
    }
    public class Müdür:Sahis
    {
        public override string Görev()
        {
            throw new NotImplementedException();
        }

        public override double MaasHesapla(int maas)
        {
            Maas = maas;
            return Maas * 2;
        }
      
    }
    public class Bekci : Sahis
    {
        public override string Görev()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Müdür müdür = new Müdür();         
            Bekci bekci = new Bekci();
            bekci.MaasHesapla(1500);
            Console.WriteLine(bekci.MaasHesapla(1500));
            Console.WriteLine(müdür.MaasHesapla(1500));

            Console.ReadKey();
        }
    }
}
