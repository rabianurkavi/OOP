using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ISIM
    {
        protected int a = 20;
    }
    public  class ThisBase
    { 
        protected double processingspeed = 6;
       

    }
    public  class ContructorOverloading:ThisBase
    {
        //yine aynı parametreyle hata verir.
        public double Process()
        {
            double s = this.processingspeed;
            return base.processingspeed - this.processingspeed;
        }
        protected double processingspeed = 0.5;
        public ContructorOverloading()
        {

        }
        public ContructorOverloading(int a,int b)
        {
            int y =(int)processingspeed;


        }
        public ContructorOverloading(int z,int x,int g)
        {

        }
    }
    public class B:ISIM
    {
        public new int a = 34;
        //protected bulunduğu class ve kalıtılmış class içinde kullanılıma açık diğer türlü korumalıdır.
        //internal aynı program içinde erişilebilir farklı program içinde erişilemez.
        internal int Metot()//internalde erişebilir protected da erişilemez.
        {
            return base.a; 
        }
    }
    class Program
    {
        public class islem
        {
            //function overloadig 
            public int topla(int x, int y)
            {
                return x + y;
            }
            public int topla(int x, int y, int z)
            {
                return x + y + z;
            }
            public int topla(int x)
            {
                int y = 2;
                return x / y;
            }
            //public int topla(int y)//aynı parametreyle hata verir.
            //{

            //}
        }

        static void Main(string[] args)
        {
            B gizli = new B();
            int b = gizli.a;
            Console.Write(gizli.Metot() + " \n");
            islem islem = new islem();
            islem.topla(3, 4, 5);
            Console.WriteLine(islem.topla(3, 4, 5));
            // ThisBase thisBase =ThisBase(); nesne üretemedik sebebini anlamadım.

            ContructorOverloading contructor = new ContructorOverloading();


            Console.WriteLine("toplam: {0}", contructor.Process());

            //int[] dizi = new int[5];
            
            //for(int i=0;i<dizi.Length;i++)
            //{
            //    dizi[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int top = 0;
            //int sayac = 0,sonuc;


            //foreach(int sayilar in dizi)
            //{
            //    if(sayilar%2==0)
            //    {
            //        sayac++;

            //        top += sayilar;
            //    }
            //}
            //sonuc = top / sayac;
            //Console.WriteLine("Sonuç : {0}", sonuc);
            
            Console.ReadKey();
        }
    
    }
}
