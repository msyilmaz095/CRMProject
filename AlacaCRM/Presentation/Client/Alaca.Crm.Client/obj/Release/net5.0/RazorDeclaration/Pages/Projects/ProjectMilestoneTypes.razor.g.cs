// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Alaca.Crm.Client.Pages.Projects
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/MilestoneTypes")]
    public partial class ProjectMilestoneTypes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
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
