#pragma checksum "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Shared\Dialogs\Logout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a022f52b84533b26a0236b9de1c077e2be3071a6"
// <auto-generated/>
#pragma warning disable 1591
namespace Alaca.Crm.Client.Shared.Dialogs
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Service.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using MudBlazor.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Blazorise.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Blazorise.DataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Entities.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Blazor.AdminLte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Service.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Validations.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Core.Utilities.Result;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Service.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Service.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Service.Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Core.Utilities.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Service.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class Logout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "TitleContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(2);
                __builder2.AddAttribute(3, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 5 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Shared\Dialogs\Logout.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIcon>(5);
                    __builder3.AddAttribute(6, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Shared\Dialogs\Logout.razor"
                            Icons.Material.Filled.Logout

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "Class", "mr-3 mb-n1");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(8, "\r\n            ");
                    __builder3.AddContent(9, 
#nullable restore
#line 7 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Shared\Dialogs\Logout.razor"
             localizer["Logout Confirmation"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(10, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(13, 
#nullable restore
#line 11 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Shared\Dialogs\Logout.razor"
                  ContentText

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(14, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(15);
                __builder2.AddAttribute(16, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Shared\Dialogs\Logout.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, 
#nullable restore
#line 14 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Shared\Dialogs\Logout.razor"
                                     localizer["Cancel"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(20);
                __builder2.AddAttribute(21, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 15 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Shared\Dialogs\Logout.razor"
                           Color

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 15 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Shared\Dialogs\Logout.razor"
                                           Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Shared\Dialogs\Logout.razor"
                                                                    Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(25, 
#nullable restore
#line 15 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Shared\Dialogs\Logout.razor"
                                                                             ButtonText

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Shared\Dialogs\Logout.razor"
       
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }

    [Parameter] public HubConnection HubConnection { get; set; }

    [Parameter] public string ContentText { get; set; }

    [Parameter] public string ButtonText { get; set; }

    [Parameter] public MudBlazor.Color Color { get; set; }

    [Parameter] public string CurrentUserId { get; set; }

    async Task Submit()
    {
        //await HubConnection.SendAsync(ApplicationConstants.SignalR.OnDisconnect, CurrentUserId);
        _accountService.Logout();
        _navigationManager.NavigateTo("/login");
        MudDialog.Close(DialogResult.Ok(true));
    }
    void Cancel() => MudDialog.Cancel();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<Logout> localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientPreferenceManager _clientPreferenceManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomAuthStateProvider _stateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService _accountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpInterceptorManager _interceptor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService _dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
