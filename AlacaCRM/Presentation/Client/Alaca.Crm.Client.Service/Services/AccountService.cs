
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Alaca.Crm.Client.Service.Abstract;
using Alaca.Core.Utilities.Result;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Service.Extensions;
using Microsoft.AspNetCore.Components;
using Alaca.Core.Entities;
using Newtonsoft.Json;
using System.Text;
using System.Net;
using System.Security.Claims;
using System.Collections.Generic;
using System;
using Alaca.Crm.Client.Service.Helpers;
using Microsoft.AspNetCore.Components.Authorization;
using Alaca.Core.Utilities.Security.Jwt;
using Alaca.Crm.Client.Service.Authentication;
using Alaca.Core.Utilities.Constants;
using System.Net.Http.Headers;
using Microsoft.Extensions.Localization;

namespace Alaca.Crm.Client.Service.Services
{
    public class AccountService : IAccountService
    {
        HttpClient _httpClient;
        NavigationManager _navigationManager;
        IConfigurationService _configurationService;
        IUserRoleService _userRoleService;
        ILocalStorageService _localStorageService;
        AuthenticationStateProvider _authenticationStateProvider;
        IStringLocalizer<AuthenticationManager> _localizer;

        public AccountService(
            HttpClient httpClient,
            IConfigurationService configurationService,
            IUserRoleService userRoleService,
            ILocalStorageService localStorageService,
            AuthenticationStateProvider authenticationStateProvider,
            NavigationManager navigationManager,
            IStringLocalizer<AuthenticationManager> localizer
        )
        {
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
            _userRoleService = userRoleService;
            _configurationService = configurationService;
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localizer = localizer;
        }


        public async Task<bool> Login(string Email, string Password)
        {
            //_httpClient.DefaultRequestHeaders.Accept.Add( Authorization.)
            var content = JsonConvert.SerializeObject(new { Email = Email, Password = Password });
            var response = await _httpClient.PostAsync("api/Account/login", new StringContent(content, Encoding.UTF8, "application/json"));
            var result = await response.ToResultAsync<AccessToken>();
            if (result.Success)
            {
                var token = result.Data;
                await _localStorageService.SetItem("userid", token.UserId);
                await _localStorageService.SetItem(StorageConstants.Local.AuthToken, token.Token);
                await _localStorageService.SetItem("mail", token.Email);
                await _localStorageService.SetItem("username", token.UserName);
                await _localStorageService.SetItem("userroleid", token.UserRoleId);
                var authresult = await _authenticationStateProvider.GetAuthenticationStateAsync();
                ((CustomAuthStateProvider)this._authenticationStateProvider).MarkUserAsAuthenticated(Email);
                await _localStorageService.SetItem("ProjectCompanyName", (await _configurationService.GetById("ProjectCompanyName")).Data.ConfigurationValue);
                return true;
            }
            return false;
        }

        public async Task<HashSet<Menu>> GetAllMenu()
        {
            //var st= await _localStorageService.GetItem<string>("userroleid");
            var response = await _userRoleService.GetByUserRoleIdMenus(await _localStorageService.GetItem<Guid>("userroleid"));
            return response.Data;
        }
        public async void Logout()
        {
            await _localStorageService.RemoveItem(StorageConstants.Local.AuthToken);
            ((CustomAuthStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
            //_navigationManager.NavigateTo("/login");
            //return await Result.SuccessAsync();
            //await _localStorageService.RemoveItem("token");
            //await _authenticationStateProvider();
        }

        public async Task<string> TryRefreshToken()
        {            //check if token exists
            var availableToken = await _localStorageService.GetItem<string>(StorageConstants.Local.AuthToken);
            if (string.IsNullOrEmpty(availableToken)) return string.Empty;
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            var exp = user.FindFirst(c => c.Type.Equals("exp"))?.Value;
            var expTime = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(exp));
            var timeUTC = DateTime.UtcNow;
            var diff = expTime - timeUTC;
            //if (diff.TotalMinutes <= 1)
            //    return await RefreshToken();
            return string.Empty;
        }


        /*public async Task<string> RefreshToken()
        {
            var token = await _localStorageService.GetItem<string>(StorageConstants.Local.AuthToken);
            var refreshToken = await _localStorageService.GetItem<string>(StorageConstants.Local.RefreshToken);

            var response = await _httpClient.PostAsJsonAsync(Routes.TokenEndpoints.Refresh, new RefreshTokenRequest { Token = token, RefreshToken = refreshToken });

            var result = await response.ToResult<TokenResponse>();

            if (!result.Succeeded)
            {
                throw new ApplicationException(_localizer["Something went wrong during the refresh token action"]);
            }

            token = result.Data.Token;
            refreshToken = result.Data.RefreshToken;
            await _localStorageService.SetItem(StorageConstants.Local.AuthToken, token);
            await _localStorageService.SetItem(StorageConstants.Local.RefreshToken, refreshToken);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return token;
        }*/

        public Task<string> TryForceRefreshToken()
        {
            throw new NotImplementedException();
        }
    }
}
