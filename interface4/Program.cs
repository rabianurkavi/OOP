using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface4
{
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface IGetSalary
    {
        void GetSalary();
    }
    public class Manager : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Yemek yeme işlemi tamamlandı.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş alındı");
        }

        public void Work()
        {
            Console.WriteLine("Çalışma tamamlandı.");
        }
    }
    public class Worker : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Yemek yeme işlemi tamamlandı.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş alındı");
        }

        public void Work()
        {
            Console.WriteLine("Çalışma tamamlandı.");
        }
    }
    public class Robot:IWorker
    {
        public void Work()
        {
            Console.WriteLine("Çalışma tamamlandı.");
        }
    }
    class Program
        
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
               new Worker(),
               new Robot(),
               new Manager()
            };
            foreach(IWorker worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
               new Worker(),              
               new Manager()
            };
            foreach (IEat eat in eats)
            {
                eat.Eat();
            }
            IGetSalary[] getSalary = new IGetSalary[2]
            {
                new Worker(),
                new Manager()
            };
            foreach(IGetSalary getSalarys in getSalary)
            {
                getSalarys.GetSalary();
            }
            Console.ReadKey();
        }
    }
}
