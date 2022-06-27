using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            //GetAll(productManager);
            Console.WriteLine("---------");
            foreach (var x in productManager.GetProductDetail())
            {
                Console.WriteLine(x.ProductId+" "+x.ProductName+" "+x.CategoryName+" "+x.UnitsInStock);
            }
            //Get(productManager);
            //GelAllByCategory(productManager);
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //var x = categoryManager.GetById(2);
            //Console.WriteLine(x.CategoryId+" "+x.CategoryName);
            //CategoryGetAll(categoryManager);

        }

        private static void CategoryGetAll(CategoryManager categoryManager)
        {
            foreach (var x in categoryManager.GetAll())
            {
                Console.WriteLine(x.CategoryId + " " + x.CategoryName);
            }
        }

        private static void GelAllByCategory(ProductManager productManager)
        {
            var a = productManager.GetAllByCategory(2);
            foreach (var x in a)
            {
                Console.WriteLine(x.ProductId + " " + x.CategoryId + " " + x.ProductName + " " + x.UnitPrice + " " + x.UnitsInStock);
            }
        }

        private static void Get(ProductManager productManager)
        {
            var x = productManager.Get(2);
            Console.WriteLine(x.ProductId + " " + x.CategoryId + " " + x.ProductName + " " + x.UnitPrice + " " + x.UnitsInStock);
        }

        private static void GetAll(ProductManager productManager)
        {
            foreach (var x in productManager.GetAll())
            {
                Console.WriteLine(x.ProductId + " " + x.CategoryId + " " + x.ProductName + " " + x.UnitPrice + " " + x.UnitsInStock);
            }
        }
    }
}
