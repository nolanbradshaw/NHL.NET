using System.Threading.Tasks;

namespace NHL.NET.Http.Interfaces
{
    public interface IRequester
    {
        /// <summary>
        /// Asyncronously deserializes the response json to an object.
        /// </summary>
        /// <typeparam name="T">Object to deserialize to</typeparam>
        /// <param name="uri">Uri to query</param>
        Task<T> GetRequestAsync<T>(string uri) where T : class;

        /// <summary>
        /// Asyncronously retrieves the response json as a string.
        /// </summary>
        /// <param name="uri">Uri to query</param>
        Task<string> GetRequestAsync(string uri);

        /// <summary>
        /// Deserializes the response json to an object.
        /// </summary>
        /// <typeparam name="T">Object to deserialize to</typeparam>
        /// <param name="uri">Uri to query</param>
        T GetRequest<T>(string uri) where T : class;

        /// <summary>
        /// Retrieves the response json as a string.
        /// </summary>
        /// <param name="uri">Uri to query</param>
        string GetRequest(string uri);
    }
}
