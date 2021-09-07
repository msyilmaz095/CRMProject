using Alaca.Core.Entities;
using Alaca.Crm.Client.Service.Abstract;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Entities.Concrete;
using Microsoft.JSInterop;
using Alaca.Core.Utilities.Extension;
using Blazored.FluentValidation;
using MudBlazor;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Alaca.Crm.Client.Pages.Account
{
    public partial class Login : ComponentBase
    {
        private FluentValidationValidator _fluentValidationValidator;
        public User user { get; set; } = new();
        protected bool loading;
        protected bool LoginForm = true;
        protected string FormAdi = "Kullanıcı Girişi";
        protected string LoginMessage = "";
        [Inject] public AuthenticationStateProvider _authenticationStateProvider { get; set; }
        protected override async void OnInitialized()
        {
            var state = await _authenticationStateProvider.GetAuthenticationStateAsync();
            if (state != new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())))
            {
                _navigationManager.NavigateTo("/");
            }
        }

        protected async void OnValidSubmit()
        {
            loading = true;
            try
            {
                bool result = await _accountService.Login(user.Email, user.Password);
                if (result == false)
                {
                    _snackBar.Add("Kullanıcı Adı yada Şifre Hatalı Tekrar Deneyiniz!!!", Severity.Warning);
                }
                else
                {
                    loading = false;
                    _navigationManager.NavigateTo("/", true);
                }
            }
            catch (Exception ex)
            {
                _snackBar.Add("Kullanıcı Adı yada Şifre Hatalı Tekrar Deneyiniz!!!", Severity.Warning);
            }
            StateHasChanged();
        }

        private bool _passwordVisibility;
        private InputType _passwordInput = InputType.Password;
        private string _passwordInputIcon = Icons.Material.Filled.VisibilityOff;

        void TogglePasswordVisibility()
        {
            if (_passwordVisibility)
            {
                _passwordVisibility = false;
                _passwordInputIcon = Icons.Material.Filled.VisibilityOff;
                _passwordInput = InputType.Password;
            }
            else
            {
                _passwordVisibility = true;
                _passwordInputIcon = Icons.Material.Filled.Visibility;
                _passwordInput = InputType.Text;
            }
        }
    }

}
