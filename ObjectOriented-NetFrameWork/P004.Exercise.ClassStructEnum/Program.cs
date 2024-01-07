using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldNamespace;

namespace P004.Exercise.ClassStructEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Country One
            Country countryOneInstance = new Country();

            CountryLanguage countryOneLanguage = new CountryLanguage
            {
                FirstLanguage = Language.Turkish.ToString(),
                SecondLanguage = Language.Arabic.ToString()
            };

            countryOneInstance.CountryLanguage = countryOneLanguage;
            countryOneInstance.PlanetName = "Earth";
            countryOneInstance.CountryName = "Turkey";
            countryOneInstance.Continent = Continent.Europe;
            countryOneInstance.Currency = Currency.KRW;

            countryOneInstance.SayHi(countryOneInstance.CountryName);
            countryOneInstance.SayHi();


            //Country two
            Country countryTwoIntance = new Country();

            CountryLanguage countryTwoLanguage = new CountryLanguage
            {
                FirstLanguage = Language.English.ToString(),
                SecondLanguage = Language.French.ToString()
            };

            countryTwoIntance.CountryLanguage = countryTwoLanguage;
            countryTwoIntance.PlanetName = "Earth";
            countryTwoIntance.CountryName = "Canada";
            countryTwoIntance.Continent = Continent.NorthAmerica;
            countryTwoIntance.Currency = Currency.CAD;

            countryTwoIntance.SayHi(countryTwoIntance.CountryName);
            countryTwoIntance.SayHi();
        }
    }
}
