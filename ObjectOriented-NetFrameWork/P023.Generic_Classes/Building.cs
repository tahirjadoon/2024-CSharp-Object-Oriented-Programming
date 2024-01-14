using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P023.Generic_Classes
{
    public class Building<T>
    {
        public string Name { get; set; }

        public string City { get; set; }

        public T Height { get; set; }

        public T Weight { get; set; }
    }
}
