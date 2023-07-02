namespace UseCaseProject.HttpClients
{
	public interface ITypedHttpClient
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="uri"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		Task<T> GetAsync<T>(Uri uri, CancellationToken? cancellationToken = null);
	}
}
