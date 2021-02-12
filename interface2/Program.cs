using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface2
{
    public abstract class Canlı
    {
        public abstract int Kromozom();
        public abstract string YasamYeri();
        public abstract string Tur();
        public abstract string Alem();
        public abstract string Sube();
        public abstract string Sinif();
        
    }
    interface IMemeli
    {
        string konusmatarzi();
        int ayaksayisi();
        string yemesekli();  
    }
    interface ISurungenler
    {
        string yemesekli();
        int ayaksayisi();
    }
    interface IBalıklar
    {
        
    }
    interface IKuslar
    {
        string yemesekli();
    }
    public class Kopek : Canlı, IMemeli
    {
        public override string Alem()
        {
            return "Hayvanlar Alemi";
        }

        public int ayaksayisi()
        {
            return 4;
        }

        public string konusmatarzi()
        {
            return "havlama";
        }

        public override int Kromozom()
        {
            return 78;
        }

        public override string Sinif()
        {
            return "Memeliler";
        }

        public override string Sube()
        {
            return "Omurgalılar";
        }

        public override string Tur()
        {
            return "Köpek";
        }

        public override string YasamYeri()
        {
            return "Suyu oksijeni olan her yerde ";
        }

        public string yemesekli()
        {
            return "Etçil";
        }
       
    }
    public class MuhabbetKusu : Canlı, IKuslar
    {
        public override string Alem()
        {
            return "Hayvanlar Alemi";
        }

        public override int Kromozom()
        {
            return 26;
        }

        public override string Sinif()
        {
            return "Kuşlar";
        }

        public override string Sube()
        {
            return "Omurgalılar";
        }

        public override string Tur()
        {
            return "Muhabbet Kuşu";
        }

        public override string YasamYeri()
        {
            return "Orman ";
        }

        public string yemesekli()
        {
            return "Etçil,otçul";
        }
    }
  
    public class Ekle
    {
        Kopek kopek = new Kopek();
        MuhabbetKusu muhabbetkusu = new MuhabbetKusu();
        List<Canlı> listele = new List<Canlı>();
        public void Listele(string y)
        {
            string yazi = y;
            if (yazi == "köpek")
            {
                foreach (Canlı canlı in listele)
                {
                    Console.WriteLine(canlı.Tur() + "\n" + "Kromozom Sayısı:" + canlı.Kromozom() + " " + "Alemi:" + canlı.Alem() + " " + "Sınıfı:" + canlı.Sinif() + " " + "Şubesi:" + canlı.Sube() + " " + "Yaşam Yeri:" + canlı.YasamYeri() + " " + "Ayak Sayısı:" + kopek.ayaksayisi());
                }
            }
            else if(yazi == "kus")
            {
                foreach (Canlı canlı in listele)
                {
                    Console.WriteLine(canlı.Tur() + "\n" + "Kromozom Sayısı:" + canlı.Kromozom() + " " + "Alemi:" + canlı.Alem() + " " + "Sınıfı:" + canlı.Sinif() + " " + "Şubesi:" + canlı.Sube() + " " + "Yaşam Yeri:" + canlı.YasamYeri() + " "+"Yeme Sekli:"+muhabbetkusu.yemesekli());
                }
            }
            else
            {
                Console.WriteLine("Yanlış giden bir şeyler var.");
            }
        }
        public void Ekleme(Canlı canlı)
        {
            listele.Add(canlı);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Ekle ekle = new Ekle();
            MuhabbetKusu kusu = new MuhabbetKusu();
            
            Kopek kopek = new Kopek();
            ekle.Ekleme(kopek);
            ekle.Ekleme(kusu);
            ekle.Listele("kus");
            ekle.Listele("köpek");

            Console.ReadKey();
        }
    }
}

