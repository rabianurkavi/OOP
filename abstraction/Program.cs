using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    class Rabia : MYCLASS
    {
        public override void Metot2()//GÖRÜLDÜĞÜ ÜZERE SADECE METOT2 Yİ EZMEK ZORUNDA KALDIK.ABSTRACT OLMAYAN BİR FONKSİYONU EZMEK ZORUNDA DEĞİLİZ.
        {
            Console.WriteLine("ABSTRACT CLASS İÇİNDE KALITIM SAĞLANAN VE EZİLMEK ZORUNDA OLAN ABSTRACT FONKSİYON ÇAĞIRILDI.");
        }

        public override void Metot3()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MYCLASS mYCLASS = new Rabia();// bu şekilde yazabiliyoruz.
            mYCLASS.Metot2();
            mYCLASS.Metot1();
          
            //MYCLASS yCLASS = new MYCLASS8(); abstract classtan nesne üretemiyoruz
            Ocak ocak = new Ocak();

            Console.WriteLine("OCAK AYI BİLGİLERİ \n Kaç gün: {0} \n Yılın kaçıncı ayı: {1} \n Günler kaç saat: {2} ", ocak.kacgundenolusur(), ocak.yılınkacinciayidir(), ocak.Gunlerkacsaattir());
            Console.ReadKey();
        }
    }
    /* ABSTRACT SINIFLARIN NORMAL SINIFLARDAN FARKI NEDİR?
     * Normal sınıflar içinde metot bildirimi yapılmazken abstract sınıflar içerisinde tıpkı arayüzler de olduğu gibi metot bildirimi yapılabilir.
     * Bildirimi yapılan metotlar abstract sınıftan türeyen sınıflar içerisinde tanımlanmak zorundadır.
     * Normal sınıflardan nesne oluşturulabilirken abstractlarda nesne oluşturulamaz abstract kalıtım amaçlı geliştirilmiştir.
     */
    public abstract class MYCLASS : YOUCLASS//abstract class abstract classa inherit edilebilir.
    {
        public void Metot1()
        {
            Console.WriteLine("abstract class içinde abstract olmayan metot.");
        }
        //public abstract void Metot2()/abstract metotlar gövde oluşturamaz.
        //{

        //}
        public abstract void Metot2();
    }
    public abstract class YOUCLASS
    {
        public abstract void Metot3();
    }
    public class OURCLASS : MYCLASS//bir classa sadece bir tane class inherit edilebilir bu kısıtı kaldırmak için abstract class içinde abstract classı inherit edeceğiz.
    {

        public override void Metot2()
        {
            throw new NotImplementedException();
        }

        public override void Metot3()
        {
            throw new NotImplementedException();
        }

    }
    public interface Ay
    {
        int Gunlerkacsaattir();
        int kacgundenolusur();
        int yılınkacinciayidir();
    }
    public class Ocak : Ay
    {
        public int Gunlerkacsaattir()
        {
            return 24;
        }

        public int kacgundenolusur()
        {
            return 31;
        }

        public int yılınkacinciayidir()
        {
            return 1;
        }
    }
    public class Şubat : Ay
    {
        public int Gunlerkacsaattir()//görüldüğü üzere 24 hep sabittir.Bunun yerine gelin abstractta deneyelim
        {
            return 24;
        }

        public int kacgundenolusur()
        {
            return 28;
        }

        public int yılınkacinciayidir()
        {
            return 2;
        }
    }
    // Bu şekilde daha kolay bir kullanım yapmış olduk.
    public abstract class Month
    {
        public int GunlerKacSaattir()
        {
            return 24;
        }
        public virtual int KacGundenOlusur()
        {
            return 31;
        }
        public abstract int YilinKacinciAyidir();
    }
    public class January : Month
    {
        public override int YilinKacinciAyidir()
        {
            return 1;
        }
        //public override int KacGundenOlusur()//zaten 31 gün olduğu için tekrar yazmamıza gerek yoktur.
        //{
        //    return 31;
        //}
    }
    public class February:Month
    {
        public override int YilinKacinciAyidir()
        {
            return 2;
        }
        public override int KacGundenOlusur()
        {
            return 28;
        }
    }
}
