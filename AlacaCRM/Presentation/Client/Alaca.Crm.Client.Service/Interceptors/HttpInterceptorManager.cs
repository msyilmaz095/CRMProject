using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using Toolbelt.Blazor;
using Alaca.Crm.Client.Service.Abstract;

namespace Alaca.Crm.Client.Service.Interceptors
{
    public class HttpInterceptorManager : IHttpInterceptorManager
    {
        private readonly HttpClientInterceptor _interceptor;
        private readonly IAccountService _authenticationManager;
        private readonly NavigationManager _navigationManager;
        private readonly ISnackbar _snackBar;
        private readonly IStringLocalizer<HttpInterceptorManager> _localizer;

        public HttpInterceptorManager(
            HttpClientInterceptor interceptor,
            IAccountService authenticationManager,
            NavigationManager navigationManager,
            ISnackbar snackBar,
            IStringLocalizer<HttpInterceptorManager> localizer)
        {
            _interceptor = interceptor;
            _authenticationManager = authenticationManager;
            _navigationManager = navigationManager;
            _snackBar = snackBar;
            _localizer = localizer;
        }

        public void RegisterEvent() => _interceptor.BeforeSendAsync += InterceptBeforeHttpAsync;

        public async Task InterceptBeforeHttpAsync(object sender, HttpClientInterceptorEventArgs e)
        {
            var absPath = e.Request.RequestUri.AbsolutePath;
            Console.WriteLine(absPath);
            if (!absPath.Contains("token") && !absPath.Contains("accounts"))
            {
                try
                {
                    //_snackBar.Add(_localizer["Refreshed Token."], Severity.Success);
                    //var token = await _authenticationManager.Login("1","1");
                    //if (!string.IsNullOrEmpty(token))
                    //{
                    //    _snackBar.Add(_localizer["Refreshed Token."], Severity.Success);
                    //    e.Request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    //}
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    _snackBar.Add(_localizer["You are Logged Out."], Severity.Error);
                    _authenticationManager.Logout();
                    _navigationManager.NavigateTo("/");
                }
            }
        }

        public void DisposeEvent() => _interceptor.BeforeSendAsync -= InterceptBeforeHttpAsync;
    }
}