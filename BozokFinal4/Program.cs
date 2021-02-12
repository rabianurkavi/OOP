using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BozokFinal4
{ /* Bir üçgende, iki kenarın toplam uzunluğu, üçüncü kenardan az olamaz. Ayrıca iki kenarın birbirinden farkının mutlak değeri, üçüncü kenardan büyük olmamalıdır. Bu bilgileri kullanarak, verilen üç kenar uzunluğuna göre bir üçgen çizilip 
    çizilmeyeceğini gösteren programı sınıf şeklinde yazınız. İstenen sınıf özellikleri:
    Yapıcı ile üç kenarı alın.
    Üçgenin çizilip çizilemeyeceğini bool bir fonksiyonla gösterin. (bool: true ya da false)*/
    public class Ucgen
    {
        public int IlkKenar;
        public int IkınciKenar;
        public int UcuncuKenar;
        public bool CizilirMi()
        {
            if(IlkKenar+IkınciKenar>=UcuncuKenar&&IkınciKenar+UcuncuKenar >=IlkKenar&& UcuncuKenar+IlkKenar>=IkınciKenar)
            {
                int mutlakdeger1 = Math.Abs(IlkKenar - IkınciKenar);
                int mutlakdeger2 = Math.Abs(IkınciKenar - UcuncuKenar);
                int mutlakdeger3 = Math.Abs(UcuncuKenar - IlkKenar);
                if(mutlakdeger1>=UcuncuKenar&&mutlakdeger2>=IlkKenar&&mutlakdeger3>=IkınciKenar)
                {
                    return false ;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen()
            {
                IkınciKenar = 40,
                IlkKenar = 25,
                UcuncuKenar = 32
            };
            Console.WriteLine(ucgen.CizilirMi());
            Console.ReadKey();

            
        }
    }
}
