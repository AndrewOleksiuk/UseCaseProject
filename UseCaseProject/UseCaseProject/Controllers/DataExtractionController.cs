using Microsoft.AspNetCore.Mvc;
using UseCaseProject.HttpClients;
using UseCaseProject.Models;
using UseCaseProject.Services;

namespace UseCaseProject.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class DataExtractionController : ControllerBase
	{
		private readonly ITypedHttpClient _httpClient;
		private readonly IDataService _dataService;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="httpClient"></param>
		/// <param name="dataService"></param>
		public DataExtractionController(ITypedHttpClient httpClient, IDataService dataService)
		{
			_httpClient = httpClient;
			_dataService = dataService;
		}

		[HttpGet]
		public async Task<IEnumerable<Country>> Get(string? countryName = null, int? population = null, string? sortingOrder = null, int? pageSize = null)
		{
			var countries = await _httpClient.GetAsync<IEnumerable<Country>>(new Uri("https://restcountries.com/v3.1/all"));

			countries = _dataService.FilterByName(countryName, countries);
			countries = _dataService.FilterByPopulation(population, countries);
			countries = _dataService.SortByName(sortingOrder, countries);
			countries = _dataService.TakeFirstNth(pageSize, countries);

			return countries;
		}
	}
}