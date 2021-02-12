using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizefinalhesapla
{
    interface Vize
    {
        int VizeOdev { get; set; }
        int VizeSinav { get; set; }
        double VizeHesapla();

    }
    interface Final
    {
        int FinalOdev { get; set; }
        int FinalSinav { get; set; }
        double FinalHesapla();


    }
    public class Ogrenci : Final, Vize
    {
        public int FinalOdev { get; set; }
        public int FinalSinav { get; set; }
        public int VizeOdev { get; set; }
        public int VizeSinav { get; set; }
        public Ogrenci(int fo, int fs, int vo, int vs)
        {
            FinalOdev = fo;
            FinalSinav = fs;
            VizeOdev = vo;
            VizeSinav = vs;
        }

        public double FinalHesapla()
        {
            return (FinalOdev * 0.4) + (FinalSinav * 0.6);
        }

        public double VizeHesapla()
        {
            return (VizeOdev * 0.4) + (VizeSinav * 0.6);
        }
        public void Hesapla()
        {
            double sonuc = FinalHesapla() * 0.6 + VizeHesapla() * 0.4;
            Console.WriteLine("öĞRENCİ NOT ORTALAMASI: {0} ", sonuc);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci(55, 44, 88, 74);
            ogrenci.Hesapla();
            Console.ReadLine();
        }
    }
}
