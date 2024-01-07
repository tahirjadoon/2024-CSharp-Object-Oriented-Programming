using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldNamespace
{
    public abstract class World
    {
        private string _planetName;
        private Continent _continent;

        public string PlanetName { get { return _planetName; } set { _planetName = value; } }
        public Continent Continent { get { return _continent; } set { _continent = value; } }

    }
}
