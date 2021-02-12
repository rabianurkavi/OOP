using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAV5
{
    public class Fatura:Kurucu
    {
        public decimal GetFatura(int miktar,decimal fiyat)
        {
            Miktar = miktar;
            Fiyat = fiyat;
            return (decimal)Miktar *(decimal) Fiyat;
            
        }
    }
    public class Kurucu
    {
        public decimal fiyat;
        public int miktar;
        public string ParcaNo { get; set; }
        public string Parca_Tarif { get; set; }
        public int Miktar
        {
            get { return miktar; }
            set {
                if (value < 0)
                    miktar = 1;
                else
                    miktar = value;
                 }
        }
        public decimal Fiyat
        {
            get { return fiyat; }
            set {
                if (value < 0)
                    fiyat = 1;
                else
                    fiyat = value;
                }
        }
        
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fatura fatura = new Fatura();
            
            Console.WriteLine("Fatura:  "+fatura.GetFatura(10, 20));
            Console.ReadKey();
        }
    }
}
