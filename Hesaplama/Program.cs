using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesaplama
{//ctrl+k+d düzenleme yapar.
    public class Hesaplama
    {
        public string Veri1;
        public string Veri2;
        public Hesaplama(string veri1, string veri2)
        {

            Veri1 = veri1;
            Veri2 = veri2;
        }
        public int Toplama()
        {
            int sayi1, sayi2;
            if (!int.TryParse(Veri1, out sayi1) && int.TryParse(Veri2, out sayi2))
            {

                return -1;
            }
            else if (int.TryParse(Veri1, out sayi1) && !int.TryParse(Veri2, out sayi2))
            {

                return -2;
            }
            else if (!int.TryParse(Veri1, out sayi1) && !int.TryParse(Veri2, out sayi2))
            {

                return -3;
            }
            else if (int.TryParse(Veri1, out sayi1))
            {
                if (sayi1 < 0)
                {
                    return -4;
                }
            }
            else if (int.TryParse(Veri2, out sayi2))
            {
                if (sayi2 < 0)
                {
                    return -5;
                }
            }
            else if (int.TryParse(Veri1, out sayi1) && int.TryParse(Veri2, out sayi2))
            {
                if (sayi1 < 0 && sayi2 < 0)
                {
                    return -6;
                }
            }
            int.TryParse(Veri1, out sayi1);
            int.TryParse(Veri2, out sayi2);
            return sayi1 + sayi2;

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Hesaplama hesaplama = new Hesaplama("10", "20");
            Console.WriteLine(hesaplama.Toplama());
            Console.ReadKey();
        }
    }
}
