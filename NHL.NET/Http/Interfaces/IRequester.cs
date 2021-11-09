using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NHL.NET.Http.Interfaces
{
    public interface IRequester
    {
        Task<T> GetRequestAsync<T>(string uri) where T : class;
        T GetRequest<T>(string uri) where T : class;
    }
}
