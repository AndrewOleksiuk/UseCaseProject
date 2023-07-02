using Microsoft.AspNetCore.Mvc;
using UseCaseProject.HttpClients;
using UseCaseProject.Models;

namespace UseCaseProject.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class DataExtractionController : ControllerBase
	{
		private readonly ITypedHttpClient _httpClient;

		public DataExtractionController(ITypedHttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		[HttpGet]
		public async Task<IEnumerable<Country>> Get(string countryName = "", int? population = null, string field3 = "")
		{
			var countries = await _httpClient.GetAsync<IEnumerable<Country>>(new Uri("https://restcountries.com/v3.1/all"));

			return countries;
		}
	}
}