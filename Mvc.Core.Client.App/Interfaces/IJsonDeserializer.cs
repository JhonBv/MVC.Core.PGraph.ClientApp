using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mvc.Core.Client.App.Interfaces
{
    public interface IJsonDeserializer
    {
        Task<bool> PostAsync(HttpResponseMessage response);
        Task<T> GetModelAsync<T>(HttpResponseMessage response) where T : class;
        Task<IEnumerable<T>> GetCollectionAsync<T>(HttpResponseMessage response) where T : class;
        string GetContent();
    }
}
