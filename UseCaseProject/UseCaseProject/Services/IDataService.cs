using UseCaseProject.Models;

namespace UseCaseProject.Services
{
	public interface IDataService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="countries"></param>
		/// <returns></returns>
		IEnumerable<Country> FilterByName(string? name, IEnumerable<Country> countries);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="countries"></param>
		/// <returns></returns>
		IEnumerable<Country> FilterByPopulation(int? population, IEnumerable<Country> countries);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="countries"></param>
		/// <returns></returns>
		IEnumerable<Country> SortByName(string? order, IEnumerable<Country> countries);
	}
}
