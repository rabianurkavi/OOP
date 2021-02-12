using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch
{
    public class TempIsZeroException:Exception
    {
        public TempIsZeroException(string message):base(message)// parametre alan yerin içini boş bırakırsak throw kısmındaki tempıszero hata veriyor.
        {

        }
    }
    public class Temperature
    {
        public int temperature = 0;
        public void ShowTemp()
        {
            if(temperature==0)
            {
                throw new TempIsZeroException("zero temperature/sıcaklık sıfır derece alarm");
            }
            else
            {
                Console.WriteLine($"{temperature}");
            }
        }
        public void IncreaseTemp(int t)
        {
            temperature += t;
        }
        public void DecreaseTemp(int t)
        {
            temperature -= t;
            ShowTemp();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            try
            {
                //temperature.IncreaseTemp(10);
                temperature.ShowTemp();
            }
            catch(TempIsZeroException e)
            {
                Console.WriteLine("Sıcaklık 0'a düştü lütfen arttırın. ");
                Console.WriteLine(e.Message);
            }
         //   int value = 700000000;
         //checked
         //{ 
         //   try
         //   {
         //       int square = value * value * value * value * value;
         //       Console.WriteLine("{0}^2= {1}", value, square);
         //   }
         //   catch(Exception ex)
         //   {
         //       Console.WriteLine(ex.Message);
         //       Console.WriteLine(ex.Source);
         //   }
         //}
        Console.ReadKey();
        }
    }
}
