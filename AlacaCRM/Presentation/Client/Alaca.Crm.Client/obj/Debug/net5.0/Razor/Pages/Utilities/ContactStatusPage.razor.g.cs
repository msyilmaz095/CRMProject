#pragma checksum "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e15a5b28df238cdde49e9aac390e84bbab7529c0"
// <auto-generated/>
#pragma warning disable 1591
namespace Alaca.Crm.Client.Pages.Utilities
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/contactstatu")]
    public partial class ContactStatusPage : Microsoft.AspNetCore.Components.ComponentBase
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
                        __builder4.AddMarkupContent(6, "??leti??im Durumlar??");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(7, "\r\n            ");
                    __builder3.OpenElement(8, "div");
                    __builder3.AddAttribute(9, "class", "card-tools");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(10);
                    __builder3.AddAttribute(11, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                      Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 7 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                        MudBlazor.Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                                           NewContactStatu

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
                    __builder3.OpenComponent<Blazorise.DataGrid.DataGrid<ContactStatu>>(16);
                    __builder3.AddAttribute(17, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ContactStatu>>(
#nullable restore
#line 11 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                 contactStatus

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "ShowPager", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                                             10

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Class", "table table-striped table-bordered table-hover");
                    __builder3.AddAttribute(22, "RowClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazorise.DataGrid.DataGridRowMouseEventArgs<ContactStatu>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazorise.DataGrid.DataGridRowMouseEventArgs<ContactStatu>>(this, 
#nullable restore
#line 12 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                           e=>GetContactType(e.Item.ContactStatuId)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<ContactStatu>>(24);
                        __builder4.AddAttribute(25, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                 nameof(ContactStatu.ContactStatuName)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "Caption", "Yetkili Durum");
                        __builder4.AddAttribute(27, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                                                                          true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(28, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridCheckColumn<ContactStatu>>(29);
                        __builder4.AddAttribute(30, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                      nameof(ContactStatu.IsActive)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(31, "Caption", "Aktif");
                        __builder4.AddAttribute(32, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                                                               true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "DisplayTemplate", (Microsoft.AspNetCore.Components.RenderFragment<ContactStatu>)((context) => (__builder5) => {
                            __builder5.OpenComponent<Blazorise.Check<bool>>(34);
                            __builder5.AddAttribute(35, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 17 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                    context.IsActive

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(36, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(37, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
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
            __builder.AddMarkupContent(38, "\r\n");
            __builder.OpenComponent<Blazorise.Modal>(39);
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.ModalContent>(41);
                __builder2.AddAttribute(42, "Centered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.ModalHeader>(44);
                    __builder3.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.ModalTitle>(46);
                        __builder4.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(48, "??leti??im Durum");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(49, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.CloseButton>(50);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(52);
                    __builder3.AddAttribute(53, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 31 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                          contactStatu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 31 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                       ()=>OnValidSubmit()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.OpenComponent<Blazorise.ModalBody>(56);
                        __builder4.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(58);
                            __builder5.AddComponentReferenceCapture(59, (__value) => {
#nullable restore
#line 33 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                 _fluentValidationValidator = (Blazored.FluentValidation.FluentValidationValidator)__value;

#line default
#line hidden
#nullable disable
                            }
                            );
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(60, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudSelect<bool>>(61);
                            __builder5.AddAttribute(62, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Margin>(
#nullable restore
#line 34 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                   Margin.Dense

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(63, "Label", "Durum");
                            __builder5.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 34 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                     contactStatu.IsActive

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contactStatu.IsActive = __value, contactStatu.IsActive))));
                            __builder5.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudSelectItem<bool>>(67);
                                __builder6.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 35 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                   true

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(70, "Aktif");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(71, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudSelectItem<bool>>(72);
                                __builder6.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 36 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                   false

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(75, "Pasif");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(76, "\r\n                ");
                            __Blazor.Alaca.Crm.Client.Pages.Utilities.ContactStatusPage.TypeInference.CreateMudTextField_0(__builder5, 77, 78, "Yetkili Durum", 79, 
#nullable restore
#line 38 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                                     ()=>contactStatu.ContactStatuName

#line default
#line hidden
#nullable disable
                            , 80, 
#nullable restore
#line 38 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                           contactStatu.ContactStatuName

#line default
#line hidden
#nullable disable
                            , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contactStatu.ContactStatuName = __value, contactStatu.ContactStatuName)));
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(82, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.ModalFooter>(83);
                        __builder4.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudItem>(85);
                            __builder5.AddAttribute(86, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(87, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                     12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(88, "lg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(89, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                     12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudIconButton>(91);
                                __builder6.AddAttribute(92, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                          Icons.Material.Filled.Close

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(93, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 42 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                              MudBlazor.Color.Error

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                                                 ()=>modalRef.Hide()

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(95, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudIconButton>(96);
                                __builder6.AddAttribute(97, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                          Icons.Material.Filled.Save

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(98, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 43 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                             MudBlazor.Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(99, "Class", "float-right");
                                __builder6.AddAttribute(100, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 43 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                                                                      MudBlazor.ButtonType.Submit

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
#nullable restore
#line 44 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                     if (contactStatu.ContactStatuId != Guid.Empty)
                    {

#line default
#line hidden
#nullable disable
                                __builder6.OpenComponent<MudBlazor.MudIconButton>(101);
                                __builder6.AddAttribute(102, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                              Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(103, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 46 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                   MudBlazor.Color.Warning

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                                                                                                                      Delete

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(105, "Class", "float-right");
                                __builder6.CloseComponent();
#nullable restore
#line 47 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                    }

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
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
            __builder.AddComponentReferenceCapture(106, (__value) => {
#nullable restore
#line 25 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Utilities\ContactStatusPage.razor"
                       modalRef = (Blazorise.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
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
namespace __Blazor.Alaca.Crm.Client.Pages.Utilities.ContactStatusPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
