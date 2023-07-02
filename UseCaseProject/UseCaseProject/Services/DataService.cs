using UseCaseProject.Models;

namespace UseCaseProject.Services
{
	public class DataService: IDataService
	{
		public IEnumerable<Country> FilterByName(string nameFilter, IEnumerable<Country> countries)
		{
			if (string.IsNullOrWhiteSpace(nameFilter))
			{
				return countries;
			}

			return countries.Where(c => c.Name.Common.ToLower().Contains(nameFilter.ToLower()));
		}
	}
}
