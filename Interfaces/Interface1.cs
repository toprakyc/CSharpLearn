﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal  //dal=data access ledger; insert update delete (veri)işlemlerini dal sınıfında yapacağız.
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
        }
        public void Update(ICustomerDal customerDal)
        {
            customerDal.Update();
        }
        public void Delete(ICustomerDal customerDal)
        {
            customerDal.Delete();
        }
    }
}
