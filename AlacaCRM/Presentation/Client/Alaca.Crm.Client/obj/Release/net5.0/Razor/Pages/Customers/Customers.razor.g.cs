#pragma checksum "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81e2bea6dde75d22df4d733a8d3dc17edfe8c9ab"
// <auto-generated/>
#pragma warning disable 1591
namespace Alaca.Crm.Client.Pages.Customers
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/customers")]
    public partial class Customers : Microsoft.AspNetCore.Components.ComponentBase
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
                        __builder4.AddMarkupContent(6, "\r\n                M????teri Listesi\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(7, "\r\n            ");
                    __builder3.OpenElement(8, "div");
                    __builder3.AddAttribute(9, "class", "card-tools");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(10);
                    __builder3.AddAttribute(11, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                      Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 10 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                                        MudBlazor.Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                                                                           New

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
                    __builder3.OpenComponent<Blazorise.DataGrid.DataGrid<Customer>>(16);
                    __builder3.AddAttribute(17, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Customer>>(
#nullable restore
#line 14 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                            lstCustomers

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                                                       10

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "ShowPager", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Hoverable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Responsive", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                  true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "RowHoverCursor", new System.Func<Customer, Blazorise.Cursor>(
#nullable restore
#line 17 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                        e=>  Blazorise.Cursor.Pointer

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Class", "table table-striped table-bordered table-hover");
                    __builder3.AddAttribute(25, "RowClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazorise.DataGrid.DataGridRowMouseEventArgs<Customer>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazorise.DataGrid.DataGridRowMouseEventArgs<Customer>>(this, 
#nullable restore
#line 18 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                                                           e=>RowClick(e.Item)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(26, "DataGridColumns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Customer>>(27);
                        __builder4.AddAttribute(28, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                             nameof(Customer.CustomerCode)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "Caption", "M????teri Kodu");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Customer>>(31);
                        __builder4.AddAttribute(32, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                             nameof(Customer.CustomerName)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "Caption", "M????teri Ad??");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(34, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Customer>>(35);
                        __builder4.AddAttribute(36, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                             nameof(Customer.CustomerTitle)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(37, "Caption", "M????teri K??sa Ad??");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(38, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Customer>>(39);
                        __builder4.AddAttribute(40, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                             nameof(Customer.TaxAdministration)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "Caption", "Vergi Dairesi");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(42, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Customer>>(43);
                        __builder4.AddAttribute(44, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                             nameof(Customer.TaxNumber)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(45, "Caption", "Vergi Numaras??");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(46, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Customer>>(47);
                        __builder4.AddAttribute(48, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                             nameof(Customer.Phone1)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(49, "Caption", "Telefon-1");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(50, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Customer>>(51);
                        __builder4.AddAttribute(52, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                             nameof(Customer.Phone2)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(53, "Caption", "Telefon-2");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(54, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Customer>>(55);
                        __builder4.AddAttribute(56, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                             nameof(Customer.Fax)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(57, "Caption", "Fax");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(58, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Customer>>(59);
                        __builder4.AddAttribute(60, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                             nameof(Customer.CustomField1)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(61, "Caption", "??zel Kod-1");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(62, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Customer>>(63);
                        __builder4.AddAttribute(64, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                             nameof(Customer.CustomField2)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(65, "Caption", "??zel Kod-2");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(66, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Customer>>(67);
                        __builder4.AddAttribute(68, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                             nameof(Customer.CustomField3)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(69, "Caption", "Ozel Kod-3");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(70, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<Customer>>(71);
                        __builder4.AddAttribute(72, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                                             nameof(Customer.IsCandidate)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(73, "Caption", "Aday M????teri");
                        __builder4.AddAttribute(74, "DisplayTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Customer>)((context) => (__builder5) => {
#nullable restore
#line 33 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                             if (context.IsCandidate)
                            {
                                

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(75, 
#nullable restore
#line 35 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                  "Evet"

#line default
#line hidden
#nullable disable
                            );
#nullable restore
#line 35 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                         
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(76, 
#nullable restore
#line 39 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                  "Hay??r"

#line default
#line hidden
#nullable disable
                            );
#nullable restore
#line 39 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
                                          
                            }

#line default
#line hidden
#nullable disable
                        }
                        ));
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
#nullable restore
#line 48 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Customers\Customers.razor"
      
    List<Customer> lstCustomers;
    //Customer SelectedRow;
    protected override async Task OnInitializedAsync()
    {
        lstCustomers = (await _customerService.GetAll()).Data.ToList();
    }

    protected void RowClick(Customer row)
    {
        NavigateToCustomer(row.CustomerId);
    }

    protected void New()
    {
        NavigateToCustomer(Guid.Empty);
    }

    protected void NavigateToCustomer(Guid CustomerId)
    {
        _navigationManager.NavigateTo("/customer/" + CustomerId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerService _customerService { get; set; }
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
