#pragma checksum "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cd421db43713062705a724edd163341188bb7e5"
// <auto-generated/>
#pragma warning disable 1591
namespace Alaca.Crm.Client.Pages.Stocks
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Service.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using MudBlazor.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Blazorise.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Blazorise.DataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Entities.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Blazor.AdminLte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Service.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Validations.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Core.Utilities.Result;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Service.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Service.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Service.Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Core.Utilities.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
using Alaca.Crm.Client.Service.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Stocks")]
    public partial class Stocks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazor.AdminLte.ContentMain>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazor.AdminLte.Card>(2);
                __builder2.AddAttribute(3, "Title", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazor.AdminLte.CardTitle>(4);
                    __builder3.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(6, "Stoklar");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(7, "\r\n            ");
                    __builder3.OpenElement(8, "div");
                    __builder3.AddAttribute(9, "class", "card-tools");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(10);
                    __builder3.AddAttribute(11, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                      Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 7 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                                                        MudBlazor.Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                                                                                           NewStock

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "Class", "ml-auto");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.AddAttribute(15, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.DataGrid.DataGrid<Stock>>(16);
                    __builder3.AddAttribute(17, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Stock>>(
#nullable restore
#line 11 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                          stocks

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                  true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                                  10

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "ShowPager", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Hoverable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Responsive", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                  true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Class", "table table-striped table-bordered table-hover");
                    __builder3.AddAttribute(24, "RowClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazorise.DataGrid.DataGridRowMouseEventArgs<Stock>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazorise.DataGrid.DataGridRowMouseEventArgs<Stock>>(this, 
#nullable restore
#line 15 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                                                                           e=>RowClick(e.Item)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(25, "DataGridColumns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Stock>>(26);
                        __builder4.AddAttribute(27, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                                          nameof(Stock.StockCode)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "Caption", "Stok Kod");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(29, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Stock>>(30);
                        __builder4.AddAttribute(31, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                                          nameof(Stock.StockName)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(32, "Caption", "Stok Adı");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(33, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Stock>>(34);
                        __builder4.AddAttribute(35, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                                          nameof(Stock.Description)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(36, "Caption", "Stok Açıklama");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Stock>>(38);
                        __builder4.AddAttribute(39, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                                          nameof(Stock.SpecialCode1)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(40, "Caption", "Özel Kod-1");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Stock>>(42);
                        __builder4.AddAttribute(43, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                                          nameof(Stock.SpecialCode2)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(44, "Caption", "Özel Kod-2");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(45, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Stock>>(46);
                        __builder4.AddAttribute(47, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Stocks\Stocks.razor"
                                                          nameof(Stock.SpecialCode3)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(48, "Caption", "Özel Kod-3");
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