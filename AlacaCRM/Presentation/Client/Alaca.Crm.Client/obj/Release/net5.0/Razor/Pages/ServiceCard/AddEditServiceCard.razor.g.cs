#pragma checksum "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9c7e0b1b32b6b79c989b0e103700da43e263823"
// <auto-generated/>
#pragma warning disable 1591
namespace Alaca.Crm.Client.Pages.ServiceCard
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddEditServiceCards/{ServiceCardId:guid}")]
    public partial class AddEditServiceCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 3 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
     if (_mudDialog == null)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudCardHeader>(2);
                __builder2.AddAttribute(3, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 7 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                  
                    if (ServiceCardId == Guid.Empty)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudText>(4);
                    __builder3.AddAttribute(5, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 10 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                       Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIcon>(7);
                        __builder4.AddAttribute(8, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                            Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(9, "Class", "mr-3 mb-n1");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(10, "\r\n                            Hizmet Kaydı\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 14 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudText>(11);
                    __builder3.AddAttribute(12, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 17 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                       Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIcon>(14);
                        __builder4.AddAttribute(15, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                            Icons.Material.Filled.Update

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "Class", "mr-3 mb-n1");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(17, "\r\n                            Hizmet Düzeltme\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 21 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                    }
                

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.AddAttribute(18, "CardHeaderActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 27 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(19);
                __builder2.AddAttribute(20, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 28 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                     serviceCard

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 28 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                 OnValidSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(23);
                    __builder3.AddComponentReferenceCapture(24, (__value) => {
#nullable restore
#line 29 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                         _fluentValidationValidator = (Blazored.FluentValidation.FluentValidationValidator)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudCardContent>(26);
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudGrid>(28);
                        __builder4.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudItem>(30);
                            __builder5.AddAttribute(31, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(32, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                     12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(33, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudSelect<bool>>(35);
                                __builder6.AddAttribute(36, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Margin>(
#nullable restore
#line 33 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                       Margin.Dense

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(37, "Label", "Durum");
                                __builder6.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 33 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                                                         serviceCard.IsActive

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => serviceCard.IsActive = __value, serviceCard.IsActive))));
                                __builder6.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudSelectItem<bool>>(41);
                                    __builder7.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 34 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                       true

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(44, "Aktif");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(45, "\r\n                        ");
                                    __builder7.OpenComponent<MudBlazor.MudSelectItem<bool>>(46);
                                    __builder7.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 35 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                       false

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(49, "Pasif");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(50, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudItem>(51);
                            __builder5.AddAttribute(52, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(53, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                     12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(54, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudTextField<string>>(56);
                                __builder6.AddAttribute(57, "Label", "Hizmet Kod");
                                __builder6.AddAttribute(58, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(
#nullable restore
#line 39 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                                                                              ()=>serviceCard.ServiceCardCode

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(59, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                                 serviceCard.ServiceCardCode

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(60, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => serviceCard.ServiceCardCode = __value, serviceCard.ServiceCardCode))));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(61, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudItem>(62);
                            __builder5.AddAttribute(63, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(64, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                     12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(65, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudTextField<string>>(67);
                                __builder6.AddAttribute(68, "Label", "Hizmet Adı");
                                __builder6.AddAttribute(69, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(
#nullable restore
#line 42 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                                                                              ()=>serviceCard.ServiceCardName

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(70, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                                 serviceCard.ServiceCardName

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(71, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => serviceCard.ServiceCardName = __value, serviceCard.ServiceCardName))));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(72, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudItem>(73);
                            __builder5.AddAttribute(74, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 44 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(75, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 44 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                     12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(76, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 44 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudTextField<string>>(78);
                                __builder6.AddAttribute(79, "Label", "Hizmet Açıklaması");
                                __builder6.AddAttribute(80, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(
#nullable restore
#line 45 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                                                                                 ()=>serviceCard.Description

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(81, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                                        serviceCard.Description

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(82, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => serviceCard.Description = __value, serviceCard.Description))));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudCardActions>(84);
                    __builder3.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(86);
                        __builder4.AddAttribute(87, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                  Icons.Material.Filled.Close

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(88, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 50 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                                      MudBlazor.Color.Error

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                                                                       Cancel

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(90, "Class", "mr-auto p-2");
                        __builder4.CloseComponent();
#nullable restore
#line 51 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
             if (serviceCard.ServiceCardId != Guid.Empty)
            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(91);
                        __builder4.AddAttribute(92, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                      Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(93, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 53 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                                           MudBlazor.Color.Warning

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                                                                              Delete

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(95, "Class", "p-2");
                        __builder4.CloseComponent();
#nullable restore
#line 54 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
            }

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(96);
                        __builder4.AddAttribute(97, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                  Icons.Material.Filled.Save

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(98, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 55 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                                     MudBlazor.Color.Success

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(99, "Class", "p-2");
                        __builder4.AddAttribute(100, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 55 "D:\Alaca\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\ServiceCard\AddEditServiceCard.razor"
                                                                                                                      MudBlazor.ButtonType.Submit

#line default
#line hidden
#nullable disable
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