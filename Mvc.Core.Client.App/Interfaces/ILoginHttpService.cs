using Mvc.Core.Client.App.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mvc.Core.Client.App.Interfaces
{
    public interface ILoginHttpService
    {
        Task<HttpResponseMessage> PostLoginUrlEncoded(Login model);
    }
}
