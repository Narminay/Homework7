using System;
namespace LASTASKCsharp
{
	public class City
	{

		public string Name { get; set; }
		public double Population { get; set; }


		public City(string name, double population)
		{
			Name = name;
            Population = population;
		}
	}
}

