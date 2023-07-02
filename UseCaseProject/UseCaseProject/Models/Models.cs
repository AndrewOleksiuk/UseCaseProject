namespace UseCaseProject.Models
{
	public class Country
	{
		public Name Name { get; set; } = new Name();

		public Translations Translations { get; set; } = new Translations();

		public List<string> Tld { get; set; } = new List<string>();

		public string Cca2 { get; set; } = string.Empty;

		public string Ccn3 { get; set; } = string.Empty;

		public string Cca3 { get; set; } = string.Empty;

		public string Cioc { get; set; } = string.Empty;

		public bool Independent { get; set; }

		public string Status { get; set; } = string.Empty;

		public bool UnMember { get; set; }

		public Currencies Currencies { get; set; } = new Currencies();

		public Idd Idd { get; set; } = new Idd();

		public List<string> Capital { get; set; } = new List<string>();

		public List<string> AltSpellings { get; set; } = new List<string>();

		public string Region { get; set; } = string.Empty;

		public string Subregion { get; set; } = string.Empty;

		public Dictionary<string, string> Languages { get; set; } = new Dictionary<string, string>();

		public List<double> Latlng { get; set; } = new List<double>();

		public bool Landlocked { get; set; }

		public List<string> Borders { get; set; } = new List<string>();

		public double Area { get; set; }

		public Demonyms Demonyms { get; set; } = new Demonyms();

		public string Flag { get; set; } = string.Empty;

		public Maps Maps { get; set; } = new Maps();

		public int Population { get; set; }

		public Dictionary<string, double> Gini { get; set; } = new Dictionary<string, double>();

		public string Fifa { get; set; } = string.Empty;

		public Car Car { get; set; } = new Car();

		public List<string> Timezones { get; set; } = new List<string>();

		public List<string> Continents { get; set; } = new List<string>();

		public Flags Flags { get; set; } = new Flags();

		public CoatOfArms CoatOfArms { get; set; } = new CoatOfArms();

		public string StartOfWeek { get; set; } = string.Empty;

		public CapitalInfo CapitalInfo { get; set; } = new CapitalInfo();

		public PostalCode PostalCode { get; set; } = new PostalCode();
	}

	public class Translations
	{
		public Dictionary<string, string> Ara { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Bre { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Ces { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Cym { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Deu { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Est { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Fin { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Fra { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Hrv { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Hun { get; set; }	= new Dictionary<string, string>();

		public Dictionary<string, string> Ita { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Jpn { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Kor { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Nld { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Per { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Pol { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Por { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Rus { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Slk { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Spa { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Srp { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Swe { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Tur { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Urd { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Zho { get; set; } = new Dictionary<string, string>();
	}

	public class NativeName
	{
		public Dictionary<string, string> Ara { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Common { get; set; } = new Dictionary<string, string>();
	}

	public class Idd
	{
		public string Root { get; set; } = string.Empty;

		public List<string> Suffixes { get; set; } = new List<string>();
	}

	public class Currencies
	{
		public Currency JOD { get; set; } = new Currency();
	}

	public class Currency
	{
		public string Name { get; set; } = string.Empty;

		public string Symbol { get; set; } = string.Empty;
	}

	public class CapitalInfo
	{
		public List<double> Latlng { get; set; } = new List<double>();
	}

	public class PostalCode
	{
		public string Format { get; set; } = string.Empty;

		public string Regex { get; set; } = string.Empty;
	}


	public class Name
	{
		public string Common { get; set; } = string.Empty;

		public string Official { get; set; } = string.Empty;

		public NativeName NativeName { get; set; } = new NativeName();
	}

	public class Demonyms
	{
		public Dictionary<string, string> Eng { get; set; } = new Dictionary<string, string>();

		public Dictionary<string, string> Fra { get; set; } = new Dictionary<string, string>();
	}

	public class Maps
	{
		public string GoogleMaps { get; set; } = string.Empty;

		public string OpenStreetMaps { get; set; } = string.Empty;
	}

	public class Car
	{
		public List<string> Signs { get; set; } = new List<string>();

		public string Side { get; set; } = string.Empty;
	}

	public class Flags
	{
		public string Png { get; set; } = string.Empty;

		public string Svg { get; set; } = string.Empty;

		public string Alt { get; set; } = string.Empty;
	}

	public class CoatOfArms
	{
		public string Png { get; set; } = string.Empty;
		public string Svg { get; set; } = string.Empty;
	}

}
