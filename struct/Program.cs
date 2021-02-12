using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    public class sinif
    {
        public int x;
    }
    public struct yapi
    {
        public int x;
    }
    public struct Book
    {
        public string Author;
        public string Title;
        public int BookId;
        public string Subject;
        public Book(string A,string t,int id,string subject)
        {//classlarda constructor üzerinde propertylerin hepsini belirtmesek de hata vermez ama struct da hata verir hepsini aşağıdaki gibi eşitlemeliyiz.
            Author = A;
            Title = t;
            BookId = id;
            Subject = subject;
           //hem parametre sayısı yukarda belirtilen propertler gibi olmalı hem de constructor içindeki değişkenlerin sayısı ve eşitlemesi
           //classlarda constructorda parametre sayısı veya içine yazdığımız şeyin çok önemi yoktur.
        }
        public int Toplam(int a,int b)
        {
            return a + b;
        }
        public void Yazdır()
        {
            Console.WriteLine(Author +" "+ Title+" "+ BookId+" "+ Subject);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Book book;
            //book.Author = "Sabahattin Ali";
            //book.Title = "Kürk Mantolu Modanna";
            //book.BookId = 3;
            //book.Subject = "Roman";
            //book.Yazdır();
            //Book b = new Book("J.K Rowling","Harry Potter Zümrüdüanka Yoldaşlığı",2,"Fantastik Roman");
            //b.Yazdır();
            sinif c1 = new sinif();
            c1.x = 10;
            sinif c2 = new sinif();
            c2 = c1;//bellek üzerine işlem yapılır class referans türüdür.
            Console.WriteLine("Class ve nesne üzerine olan işlemler: ");
            c1.x = 8;
            Console.WriteLine(c2.x.ToString());//çıktı 8
            c2.x = 7;
            c1.x = 10;
            Console.WriteLine(c1.x.ToString());//çıktı 10
            Console.WriteLine(c2.x.ToString());//çıktı 10
            yapi s1 = new yapi();
            s1.x = 12;
            yapi s2 = new yapi();
            s2 = s1;
            s1.x = 18;
            Console.WriteLine("Yapi ve nesne üzerine olan işlemler: ");
            Console.WriteLine(s2.x.ToString());//çıktı 12
            s1.x = 24;
            s2.x = 14;
            Console.WriteLine(s1.x.ToString());//çıktı 24
            Console.WriteLine(s2.x.ToString());//çıktı 14
             //c2=_c1 işleminde adres ataması yapılır. Bu aşamadan sonra _c1 üzerindeki her değişiklik
             // c2’ye yansır. Başka c1 ve c2 adresleri eşitlenmiştir.

            //s2 = s1 işleminde ise sadece değer ataması yapılmıştır. Her iki değişkenin çalışma adresi
            // halen birbirinden farklıdır.
            Console.ReadKey();
        }
    }
}
