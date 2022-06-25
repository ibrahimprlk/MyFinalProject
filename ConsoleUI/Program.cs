using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var x in productManager.GetAll())
            {
                Console.WriteLine(x.ProductId+" "+x.CategoryId+" "+x.ProductName+" "+x.UnitPrice+" "+x.UnitsInStock);
            }
        }
    }
}
