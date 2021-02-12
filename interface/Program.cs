using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
   public interface IPerson
    {
        int ıd { get; set; }
        string firstananme { get  ; set; }
        string lastname { get; set; }

    }
   public class Manager : IPerson
    {
        public int ıd { get; set; }
        public string firstananme { get; set; }
        public string lastname { get; set; }
        public string adress { get; set; }
        public Manager(int s,string name,string lname,string adres)
        {
            ıd = s;
            firstananme = name;
            lastname = lname;
            adress = adres;
        }
    }
   public class Student:IPerson
    {
        public int ıd { get; set; }
        public string firstananme { get; set; }
        public string lastname { get; set; }
        public string Departman { get; set; }
        public void Dondur(int s,string name,string lname,string departman)
        {
            ıd = s;
            firstananme = name;
            lastname = lname;
            Departman = departman;
        }
    }
   public class Teacher:Student
    {
        public int salary { get; set; }
        public Teacher(int s,string name,string lname,string departman,int sal)
        {
            ıd = s;
            firstananme = name;
            lastname = lname;
            Departman = departman;
            salary = sal;
        }

    }
    public class SCHOLLDİRECTOR : Teacher
    {
        public SCHOLLDİRECTOR(int s, string name, string lname, string departman, int sal) : base(s, name, lname, departman, sal)
        {
            ıd = s;
            firstananme = name;
            lastname = lname;
            Departman = departman;
            salary = sal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            int ıd,salary;
            string name, lname, adres,departman;
            Console.WriteLine("Id Girin: ");
            ıd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name Girin: ");
            name = Console.ReadLine();
            Console.WriteLine("Last Name Girin: ");
            lname = Console.ReadLine();
            Console.WriteLine("Adress Girin: ");
            adres = Console.ReadLine();
            Manager mng = new Manager(ıd,name,lname,adres);
            Console.WriteLine(mng.ıd+" "+mng.firstananme+" "+mng.lastname+" "+mng.adress);
            Student student = new Student
            {
                ıd = 2,
                firstananme = "Büşra",
                lastname = "Kavi",
                Departman = "Elektronik Mühendisliği"
            };
            Console.WriteLine(student.ıd + " " + student.lastname + " " + student.firstananme + " " + student.Departman);
            Console.WriteLine("Id Girin: ");
            ıd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name Girin: ");
            name = Console.ReadLine();
            Console.WriteLine("Last Name Girin: ");
            lname = Console.ReadLine();
            Console.WriteLine("Adress Girin: ");
            adres = Console.ReadLine();
            Console.WriteLine("Departman girin: ");
            departman = Console.ReadLine();
            Console.WriteLine("Maaş Girin: ");
            salary = Convert.ToInt32(Console.ReadLine());
            Teacher teacher = new Teacher(ıd,name,lname,departman,salary);
            Console.WriteLine(teacher.ıd + " " + teacher.lastname + " " + teacher.firstananme + " " + teacher.Departman + " " + teacher.salary);
            Console.WriteLine("Id Girin: ");
            ıd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name Girin: ");
            name = Console.ReadLine();
            Console.WriteLine("Last Name Girin: ");
            lname = Console.ReadLine();          
            Console.WriteLine("Departman girin: ");
            departman = Console.ReadLine();
            Console.WriteLine("Maaş Girin: ");
            salary = Convert.ToInt32(Console.ReadLine());
            SCHOLLDİRECTOR sCHOLLDİRECTOR = new SCHOLLDİRECTOR(ıd,name,lname,departman,salary);
            Console.WriteLine(sCHOLLDİRECTOR.ıd + " " + sCHOLLDİRECTOR.firstananme + " " + sCHOLLDİRECTOR.lastname + " " + sCHOLLDİRECTOR.Departman + " " + sCHOLLDİRECTOR.salary);
            Console.ReadKey();
            //Console.WriteLine("Id Girin: ");
            //sCHOLLDİRECTOR.ıd = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Name Girin: ");
            //sCHOLLDİRECTOR.firstananme = Console.ReadLine();
            //Console.WriteLine("Last Name Girin: ");
            //sCHOLLDİRECTOR.lastname = Console.ReadLine();           
            //Console.WriteLine("Departman girin: ");
            //sCHOLLDİRECTOR.Departman= Console.ReadLine();
            //Console.WriteLine("Maaş Girin: ");
            //sCHOLLDİRECTOR.salary = Convert.ToInt32(Console.ReadLine());


         



        }
    }
}
