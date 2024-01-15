using P038.Exercise.Delegates_Actions_Generic.BusinessLayer;
using P038.Exercise.Delegates_Actions_Generic.Models;
using P038.Exercise.Delegates_Actions_Generic.ServiceCallManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038.Exercise.Delegates_Actions_Generic
{
    internal class Program
    {
        /// <summary>
        /// Encapsulates a method that has a single parameter and does not return a value. 
        /// </summary>
        /// <typeparam name="T">The type of the parameter of the method that this delegate encapsulates</typeparam>
        /// <param name="obj">The parameter of the method that this delegate encapsulates</param>
        //public delegate void Action<in T>(T obj);

        static void Main(string[] args)
        {
            IList<Products> products = new List<Products>();
            var product1 = new Products { ProductName = "Rice", ProductId = 1 };
            products.Add(product1);

            var product2 = new Products { ProductName = "Lentils", ProductId = 2 };
            products.Add(product2);

            var product3 = new Products { ProductName = "Onions", ProductId = 3 };
            products.Add(product3);

            //Process all products
            ServiceCaller.Invoke<FrequentCustomer>(x => x.Process(products));

            //Process each product
            ServiceCaller.Invoke<FrequentCustomer>(x => x.Process(product1));
            ServiceCaller.Invoke<FrequentCustomer>(x => x.Process(product2));
            ServiceCaller.Invoke<FrequentCustomer>(x => x.Process(product3));

        }
    }
}
