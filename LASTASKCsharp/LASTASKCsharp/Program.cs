namespace LASTASKCsharp;
class Program
{
    static void Main(string[] args)
    {
        Country country = new Country("United Kingdom",68751442);
        country.City.Add(new City("London",8982000));
        country.City.Add(new City("Birmingham",1149000));
        country.City.Add(new City("Manchester", 553230));
        country.City.Add(new City("Edinburgh",500000));
        country.City.Add(new City("Bristol",430000));

        foreach (var city in country.FindAllByPopulation(0,2000000))
        {
            Console.WriteLine($"City Name: {city.Name}, Population: {city.Population}");
        }

    }
}

