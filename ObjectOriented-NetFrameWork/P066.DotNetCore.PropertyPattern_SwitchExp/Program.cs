// See https://aka.ms/new-console-template for more information

var viennaAus = new City(Cities.Vienna, "Austria");
var parisFr = new City(Cities.Paris, "France");
var parisUS = new City(Cities.Paris, "US");

Console.WriteLine(CheckPrices(viennaAus));
Console.WriteLine(CheckPrices(parisFr));
Console.WriteLine(CheckPrices(parisUS));


static string CheckPrices(City location) =>
    location switch
    {
        { CityName: Cities.Warsaw } => "Reasonable",
        { CityName: Cities.Budapest } => "Reasonable",
        { CityName: Cities.Vienna } => "Above Average",
        { CityName: Cities.Paris, CountryName: "US" } => $"{location.CityName}, {location.CountryName} Reasonable",
        { CityName: Cities.Paris, CountryName: "France" } => "High",

        _ => "Invalid Input"
    };

public enum Cities
{
    Vienna,
    Berlin,
    Amsterdam,
    Madrid,
    Budapest,
    Paris,
    London,
    Warsaw,
    Prague,
    Melbourne
}

public class City
{
    private readonly Cities cityName;
    private readonly string countryName;

    public City(Cities city, string country)
    {
        cityName = city;
        countryName = country;
    }

    public Cities CityName => cityName;
    public string CountryName => countryName;

    
}
