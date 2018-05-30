using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mvc.Core.Client.App.Interfaces
{
    public interface IHttpService
    {
        Task<HttpResponseMessage> GetAsync(string suffix, string token = "");
        Task<HttpResponseMessage> PostAsync<T>(T model, string suffix, string token = "");
        Task<HttpResponseMessage> PutAsync<T>(T model, string suffix, string token = "");
    }
}
