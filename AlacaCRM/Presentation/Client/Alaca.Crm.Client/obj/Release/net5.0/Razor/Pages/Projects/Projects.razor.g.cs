#pragma checksum "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73df68d5412de4fa4db5bc9f342d6de2438e779a"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Projects")]
    public partial class Projects : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardHeader>(2);
                __builder2.AddAttribute(3, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(4);
                    __builder3.AddAttribute(5, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 5 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(7, "\r\n                PROJELER\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(8, "CardHeaderActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(9);
                    __builder3.AddAttribute(10, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                  Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 10 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                                    MudBlazor.Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                                                                       NewProject

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Class", "ml-auto");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCardContent>(15);
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.DataGrid.DataGrid<viewProject>>(17);
                    __builder3.AddAttribute(18, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<viewProject>>(
#nullable restore
#line 14 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                            projects

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                              10

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "ShowPager", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                             true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Hoverable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                             true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Responsive", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Class", "table table-striped table-bordered table-hover");
                    __builder3.AddAttribute(25, "RowClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazorise.DataGrid.DataGridRowMouseEventArgs<viewProject>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazorise.DataGrid.DataGridRowMouseEventArgs<viewProject>>(this, 
#nullable restore
#line 18 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                                                       e=>RowClick(e.Item)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(26, "SortMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.DataGrid.DataGridSortMode>(
#nullable restore
#line 18 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                                                                                       DataGridSortMode.Single

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "DataGridColumns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<viewProject>>(28);
                        __builder4.AddAttribute(29, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                            nameof(viewProject.ProjectNumber)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "Caption", "Proje No");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(31, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridDateColumn<viewProject>>(32);
                        __builder4.AddAttribute(33, "DisplayFormat", "{0:dd.MM.yyyy}");
                        __builder4.AddAttribute(34, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                                                               nameof(viewProject.ProjectDate)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(35, "Caption", "Teklif Tarihi");
                        __builder4.AddAttribute(36, "Direction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.SortDirection>(
#nullable restore
#line 21 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                                                                                                                                   Blazorise.SortDirection.Descending

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<viewProject>>(38);
                        __builder4.AddAttribute(39, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                            nameof(viewProject.CustomerName)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(40, "Caption", "Müşteri Adı");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<viewProject>>(42);
                        __builder4.AddAttribute(43, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                            nameof(viewProject.CustomerContactName)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(44, "Caption", "Müşteri Yetkilisi");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(45, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<viewProject>>(46);
                        __builder4.AddAttribute(47, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                            nameof(viewProject.AssignedToName)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(48, "Caption", "Temsilci");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(49, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<viewProject>>(50);
                        __builder4.AddAttribute(51, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                            nameof(viewProject.PaymentMethodName)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(52, "Caption", "Ödeme Şekli");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(53, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<viewProject>>(54);
                        __builder4.AddAttribute(55, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                            nameof(viewProject.CurrencyName)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(56, "Caption", "Para Birimi");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(57, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<viewProject>>(58);
                        __builder4.AddAttribute(59, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\Projects.razor"
                                                            nameof(viewProject.ProjectStatuName)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(60, "Caption", "Durum");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
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
