using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface3
{
    class Program
    {
        interface ICustomerDal
        {
            void Add();
            void Update();
            void Delete();
        }
        class SqlServerCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine("Sql Added!");
            }

            public void Delete()
            {
                Console.WriteLine("Sql Deleted!");
            }

            public void Update()
            {
                Console.WriteLine("Sql Updated!");
            }
        }
        class OracleCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine("Oracle Added!");
            }

            public void Delete()
            {
                Console.WriteLine("Oracle Deleted!");
            }

            public void Update()
            {
                Console.WriteLine("Oracle Updated!");
            }
        }
        class CustomerManager
        {
            public void Add(ICustomerDal customerDal)
            {
                customerDal.Add();
                customerDal.Delete();
                customerDal.Update();
            }
        }
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
            //dizi şeklinde yazacak olursak
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };
            foreach(ICustomerDal customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadKey();
        }
    }
}
