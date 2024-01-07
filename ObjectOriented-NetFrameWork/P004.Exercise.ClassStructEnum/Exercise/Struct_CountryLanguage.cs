using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldNamespace
{
    public struct CountryLanguage
    {
        private string _firstLanguage;
        private string _secondLanguage;

        public string FirstLanguage {  get { return _firstLanguage; } set { _firstLanguage = value; } }
        public string SecondLanguage { get { return _secondLanguage; } set { _secondLanguage = value; } }
    }
}
