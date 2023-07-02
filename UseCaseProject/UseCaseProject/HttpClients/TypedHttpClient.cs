using System.Net.Mime;
using Newtonsoft.Json;

namespace UseCaseProject.HttpClients
{
	public class TypedHttpClient : ITypedHttpClient
	{
		private readonly HttpClient _httpClient;

		/// <summary>
		/// Initializes a new instance of the <see cref="TypedHttpClient"/> class.
		/// </summary>
		/// <param name="httpClient">The http client</param>
		public TypedHttpClient(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		/// <inheritdoc/>
		public async Task<T> GetAsync<T>(Uri uri, CancellationToken? cancellationToken = null)
		{
			using var httpRequest = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = uri
			};
			httpRequest.Headers.Add("Accept", MediaTypeNames.Application.Json);

			var response = await _httpClient.SendAsync(httpRequest, cancellationToken ?? CancellationToken.None);

			if (response.StatusCode == System.Net.HttpStatusCode.NotFound
					|| response.StatusCode == System.Net.HttpStatusCode.NoContent)
			{
				return default!;
			}

			var content = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<T>(content)!;
		}
	}
}
