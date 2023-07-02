using UseCaseProject.Models;

namespace UseCaseProject.Services
{
	public class DataService : IDataService
	{
		public IEnumerable<Country> FilterByName(string? nameFilter, IEnumerable<Country> countries)
		{
			if (string.IsNullOrWhiteSpace(nameFilter))
			{
				return countries;
			}

			return countries.Where(c => c.Name.Common.ToLower().Contains(nameFilter.ToLower()));
		}

		public IEnumerable<Country> FilterByPopulation(int? population, IEnumerable<Country> countries)
		{
			if (population == null)
			{
				return countries;
			}

			population = population * 1000000;

			return countries.Where(c => c.Population < population);
		}

		public IEnumerable<Country> SortByName(string? order, IEnumerable<Country> countries)
		{
			if (order == "ascend")
			{
				return countries.OrderBy(c => c.Name.Common);
			}
			else if (order == "descend")
			{
				return countries.OrderByDescending(c => c.Name.Common);
			}

			return countries;
		}

		public IEnumerable<Country> TakeFirstNth(int? numberOfRecords, IEnumerable<Country> countries)
		{
			if (numberOfRecords == null)
			{
				return countries;
			}

			return countries.Take(numberOfRecords.Value);
		}
	}
}
