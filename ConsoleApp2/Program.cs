
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TarihBilgisi
    {
        private DateTime tarih;
        public string Gecerlitarih
        {
            set { tarih = Convert.ToDateTime(value); }
        }


        private double GunOlaraktarihFarki(DateTime farkAlinacaktarih)
        {
            return (farkAlinacaktarih - tarih).TotalDays;
        }
        // Yukarıda yapılan işlemi incelediğimizde Gecerlitarih isimli property’e atılan değer dönüştürülerek DateTime tipindeki tarih isimli değişkene atılmaktadır. GunOlaraktarihFarki isimli metod parametre olarak almış olduğu farkAlinacaktarih isimli değişkenden tarih isimli değişkeni çıkarmaktadır. Kullanılan TotalDays özelliği çıkarılan iki tarih arasındaki farkı gün olarak hesaplamaktadır.

        public string GunFarki(string Yenitarih)
        {
            return GunOlaraktarihFarki(Convert.ToDateTime(Yenitarih)).ToString() + " gün fark var";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TarihBilgisi tarih = new TarihBilgisi();

            Console.WriteLine(tarih.GunFarki("01.01.2020"));
            Console.ReadLine();

        }
    }
}
