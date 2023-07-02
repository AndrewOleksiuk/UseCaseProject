using UseCaseProject.Models;
using UseCaseProject.Services;

namespace UnitTests
{
	public class DataServiceTests
	{
		[Fact]
		public void FilterByName_NameIsNull_ShouldReturnFullList_Test()
		{
			var countries = CreateCountries();

			IDataService service = new DataService();

			var result = service.FilterByName(null, countries);

			Assert.NotNull(result);
			Assert.Equal(3, result.Count());
		}

		[Fact]
		public void FilterByName_NameIsEmpty_ShouldReturnFullList_Test()
		{
			var countries = CreateCountries();

			IDataService service = new DataService();

			var result = service.FilterByName("", countries);

			Assert.NotNull(result);
			Assert.Equal(3, result.Count());
		}

		[Fact]
		public void FilterByName_NameIsPassed_ShouldReturnFilteredList_Test()
		{
			var countries = CreateCountries();

			IDataService service = new DataService();

			var result = service.FilterByName("firs", countries).ToList();

			Assert.NotNull(result);
			Assert.Single(result);
			Assert.Equal("First", result[0].Name.Common);
		}

		[Fact]
		public void FilterByPopulation_PipolationIsNull_ShouldReturnFullList_Test()
		{
			var countries = CreateCountries();

			IDataService service = new DataService();

			var result = service.FilterByPopulation(null, countries);

			Assert.NotNull(result);
			Assert.Equal(3, result.Count());
		}

		[Fact]
		public void FilterByPopulation_PopulationIsPassed_ShouldReturnFilteredList_Test()
		{
			var countries = CreateCountries();

			IDataService service = new DataService();

			var result = service.FilterByPopulation(10, countries).ToList();

			Assert.NotNull(result);
			Assert.Single(result);
			Assert.Equal("Second", result[0].Name.Common);
			Assert.Equal(1000000, result[0].Population);
		}

		[Fact]
		public void SortByName_OrderIsNotPassed_ShouldReturnOriginalList_Test()
		{
			var countries = CreateCountries();

			IDataService service = new DataService();

			var result = service.SortByName(null, countries).ToList();

			Assert.NotNull(result);
			Assert.Equal(3, result.Count);
			Assert.Equal("First", result[0].Name.Common);
			Assert.Equal("Second", result[1].Name.Common);
			Assert.Equal("Third", result[2].Name.Common);
		}

		[Fact]
		public void SortByName_ASCOrderIsPassed_ShouldReturnASCOrderedList_Test()
		{
			var countries = CreateCountries();

			IDataService service = new DataService();

			var result = service.SortByName("ascend", countries);

			Assert.NotNull(result);
			Assert.Equal(3, result.Count());
			Assert.Equal(countries.OrderBy(c => c.Name.Common), result);
		}

		[Fact]
		public void SortByName_DESCOrderIsPassed_ShouldReturnDESCOrderedList_Test()
		{
			var countries = CreateCountries();

			IDataService service = new DataService();

			var result = service.SortByName("descend", countries);

			Assert.NotNull(result);
			Assert.Equal(3, result.Count());
			Assert.Equal(countries.OrderByDescending(c => c.Name.Common), result);
		}

		[Fact]
		public void TakeFirstNth_PageSizeIsNotPassed_ShouldReturnFullList_Test()
		{
			var countries = CreateCountries();

			IDataService service = new DataService();

			var result = service.TakeFirstNth(null, countries);

			Assert.NotNull(result);
			Assert.Equal(3, result.Count());
			Assert.Equal(countries, result);
		}

		[Fact]
		public void TakeFirstNth_PageSizeIsPassed_ShouldReturnPageSizeList_Test()
		{
			var countries = CreateCountries();

			IDataService service = new DataService();

			var result = service.TakeFirstNth(1, countries).ToList();

			Assert.NotNull(result);
			Assert.Single(result);
			Assert.Equal("First", result[0].Name.Common);
		}

		private static IEnumerable<Country> CreateCountries()
		{
			return new List<Country>
			{
				new Country()
				{
					Name = new Name()
					{
						Common = "First"
					},
					Population = 15000000
				},
				new Country()
				{
					Name = new Name()
					{
						Common = "Second"
					},
					Population = 1000000
				},
				new Country()
				{
					Name = new Name()
					{
						Common = "Third"
					},
					Population = 100000000
				}
			};
		}
	}
}