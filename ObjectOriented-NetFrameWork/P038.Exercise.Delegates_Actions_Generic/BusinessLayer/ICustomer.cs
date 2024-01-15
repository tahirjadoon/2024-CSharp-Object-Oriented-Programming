using P038.Exercise.Delegates_Actions_Generic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038.Exercise.Delegates_Actions_Generic.BusinessLayer
{
    public interface ICustomer<T>
    {
        void Process(IList<T> products);

        void Process(T product);
    }
}
