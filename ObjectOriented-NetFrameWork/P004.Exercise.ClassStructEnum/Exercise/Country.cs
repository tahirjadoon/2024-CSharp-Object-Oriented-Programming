using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldNamespace
{
    public class Country : World
    {
        private string _countryName;
        private string _capital;
        private Currency _currency;
        private CountryLanguage _countryLanguage;

        public Country()
        {
            CountryName = "Unknown";
            Capital = "Unknown";
        }

        public string CountryName { get { return _countryName; } set { _countryName = value; } }
        public string Capital { get { return _capital; } set { _capital = value; } }
        public Currency Currency { get { return _currency; } set { _currency = value; } }
        public CountryLanguage CountryLanguage { get { return _countryLanguage; } set { _countryLanguage = value; } }

        public void SayHi()
        {
            Console.WriteLine("Welcome there...");
        }

        public void SayHi(string country)
        {
            Console.WriteLine($"Welcome from {country}");
        }
    }
}
