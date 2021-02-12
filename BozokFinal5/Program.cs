using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BozokFinal5
{
    public class Hesap
    {
        private decimal bakiye;
        public Hesap(decimal bakiye_)
        {
            bakiye = bakiye_;
        }
        public decimal Bakiye
        {
            set
            {
                if (value > 0)
                    bakiye = value;
                else if (value == 0)
                    bakiye = 0;
            }
            get
            {
                return bakiye;
            }
        }


        public bool ParaCek(decimal cekilecek_miktar)
        {
            if ((bakiye - cekilecek_miktar) > 0)
            {
                Console.WriteLine("Para çekme işlemi başarılı!");
                return true;
            }
            else
            {
                Console.WriteLine("İşlem gerçekleştirilemedi, yetersiz bakiye!");
                return false;
            }
        }

        public bool ParaYatir(decimal yatirilacak_miktar)
        {
            try
            {
                bakiye += yatirilacak_miktar;
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }

    public class MevduatHesabi : Hesap
    {
        private decimal karorani;
        public MevduatHesabi(decimal bakiye, decimal karorani_) : base(bakiye)
        {
            karorani = karorani_;
        }

        public decimal KarOrani
        {
            set
            {
                if (karorani < 1)
                    karorani = 1;
                else if (karorani > 2)
                    karorani = 2;
            }
            get
            {
                return karorani;
            }
        }

        public decimal FaizHesapla()
        {
            decimal kar;
            kar = Bakiye * karorani;
            return kar;

        }
    }

    public class CekHesabi : Hesap
    {
        decimal islemucreti;
        public CekHesabi(decimal bakiye, decimal islemucreti_) : base(bakiye)
        {
            islemucreti = islemucreti_;
        }
        private void IslemUcretiKes()
        {
            Bakiye = Bakiye - islemucreti;
        }
        public bool ParaCek(decimal cekilecek_miktar_)
        {
            if (Bakiye > (cekilecek_miktar_ + islemucreti))
            {
                Bakiye -= cekilecek_miktar_;
                IslemUcretiKes();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public decimal ParaYatir(decimal yatirilacak_miktar_)
        {
            if (yatirilacak_miktar_ > islemucreti)
            {
                Bakiye += yatirilacak_miktar_;
                IslemUcretiKes();
                
            }
            return Bakiye;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            CekHesabi cek = new CekHesabi(100,250);
           Console.WriteLine( cek.ParaCek(120));
            cek.ParaYatir(200);
            cek.ParaCek(10);
            Console.ReadKey();


        }
    }
}
