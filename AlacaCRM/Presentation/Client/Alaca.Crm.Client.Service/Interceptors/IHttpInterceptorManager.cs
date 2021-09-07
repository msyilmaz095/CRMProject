using Alaca.Crm.Client.Service.Abstract;
using System.Threading.Tasks;
using Toolbelt.Blazor;

namespace Alaca.Crm.Client.Service.Interceptors
{
    public interface IHttpInterceptorManager : IManager
    {
        void RegisterEvent();

        Task InterceptBeforeHttpAsync(object sender, HttpClientInterceptorEventArgs e);

        void DisposeEvent();
    }
}