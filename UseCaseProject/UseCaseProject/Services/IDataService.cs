using UseCaseProject.Models;

namespace UseCaseProject.Services
{
	public interface IDataService
	{
		IEnumerable<Country> FilterByName(string name, IEnumerable<Country> countries);
	}
}
