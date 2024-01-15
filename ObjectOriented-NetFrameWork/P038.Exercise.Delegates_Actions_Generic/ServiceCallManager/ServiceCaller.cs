using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038.Exercise.Delegates_Actions_Generic.ServiceCallManager
{
    public static class ServiceCaller
    {
        /// <summary>
        /// Invoke is the method which takes Action<TService> type argument,
        /// in .Net Action delegate's return type is void.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        public static void Invoke<T>(Action<T> action)
        {
            Type typ = typeof(T);
            T instance = (T)Activator.CreateInstance(typ);
            action(instance);
        }

        //above is just like specifying
        /// <summary>
        /// Encapsulates a method that has a single parameter and does not return a value. 
        /// </summary>
        /// <typeparam name="T">The type of the parameter of the method that this delegate encapsulates</typeparam>
        /// <param name="obj">The parameter of the method that this delegate encapsulates</param>
        //public delegate void MyMethod<in T>(T obj);
    }
}
