using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınav4
{
    public class Daire
    {
        public double Yaricap { get; set; }
        public double Pi = 3.14;
        public Daire(double yaricap)
        {
            Yaricap = yaricap;
        }
        public  double Cevresi()
        {
            return (Yaricap + Yaricap) * 2;
        }
        public virtual double Alani()
        {
            return Pi * Yaricap * Yaricap;
        }

    }
    public class Kure:Daire
    {
        public Kure(double yaricap):base(yaricap)
        {

        }
        public override double Alani()
        {
            return 4 * Pi * Yaricap * Yaricap;
        }
        public double Hacim()
        {
            return 4 / 3 * Pi * Yaricap * Yaricap * Yaricap;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Daire c = new Daire(5);
            Console.WriteLine(c.Cevresi());
            Console.WriteLine(c.Alani());
            Kure k = new Kure(5);
            Console.WriteLine(k.Cevresi());
            Console.WriteLine(k.Alani());
            Console.WriteLine(k.Hacim());
            Console.ReadKey();

        }
    }
}
