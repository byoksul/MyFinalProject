﻿using Business.Concrete;
using DateAccess.Concrete.EntityFramework;
using DateAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager=new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(5)) 
            {
                Console.WriteLine(product.ProductName);

            }
        }
    }
}
