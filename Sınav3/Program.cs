using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınav3
{//constructor mainde direk çağırılır.Oluşturulan nesneyi ilk kullanıma hazırlar.
    public class Daire
    {
        public double Yaricap;
        public double cap;
        public Daire(double yaricap)
        {
            Yaricap = yaricap;
        }
        public double Cevresi()
        {
            
            cap = Yaricap * 2;
            return cap * 3.14;
        }
        public virtual double Alan()
        {
            
            return Yaricap * Yaricap * 3.14f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Daire daire = new Daire(4);
            Console.WriteLine("Çevresi:{0}" ,daire.Cevresi());
            Console.WriteLine("Alanı:: {0}",daire.Alan());
            Console.ReadKey();
        }
    }
}
