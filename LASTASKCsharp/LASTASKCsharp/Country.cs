using System;
namespace LASTASKCsharp
{
	public class Country
	{
		public List<City> City = new List<City>();
		public string Name;
		public double TotalPopulation;

		public Country(string name,double totalp)
		{
			Name = name;
			TotalPopulation = totalp;
		}
		public List<City> FindAllByPopulation(double min, double max)
		{
            List<City> pp = City.FindAll(x => x.Population > min && x.Population < max);
			return pp;
		}
	}
}

