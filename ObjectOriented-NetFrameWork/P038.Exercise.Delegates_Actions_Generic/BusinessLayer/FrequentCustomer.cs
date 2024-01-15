using OOP.Core;
using P038.Exercise.Delegates_Actions_Generic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038.Exercise.Delegates_Actions_Generic.BusinessLayer
{
    public class FrequentCustomer : ICustomer<Products>
    {
        /// <summary>
        /// Process is the metod  which will be called by an anonymous later
        /// </summary>
        /// <param name="products"></param>
        public void Process(IList<Products> products)
        {
            ConsoleHelper.WriteLine("--Products Details--", ConsoleColor.Yellow);
            Console.WriteLine($"Product Count : {products.Count}");
            foreach (var item in products)
            {
                Console.WriteLine($"Name : {item.ProductName} Product Id : {item.ProductId}");
            }
            
        }

        /// <summary>
        /// Process is the metod  which will be called by an anonymous later
        /// </summary>
        /// <param name="product"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Process(Products product)
        {
            ConsoleHelper.WriteLine("--Product Details--", ConsoleColor.Green);
            Console.WriteLine($"Name : {product.ProductName} Product Id : {product.ProductId}");
        }
    }
}
