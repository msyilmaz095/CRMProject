#pragma checksum "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3449ff70f7229703f350d3f9f3173d6c50b3316"
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
    public partial class AddEditMilestoneTypes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                 projectMilestoneType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                                      Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(4);
                __builder2.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 2 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                     _fluentValidationValidator = (Blazored.FluentValidation.FluentValidationValidator)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDialog>(7);
                __builder2.AddAttribute(8, "TitleContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(9);
                    __builder3.AddAttribute(10, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 5 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(12, "\r\n                Proje Süreç Türü\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(13, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(14);
                    __builder3.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudItem>(16);
                        __builder4.AddAttribute(17, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(18, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                     12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudSelect<bool>>(21);
                            __builder5.AddAttribute(22, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Margin>(
#nullable restore
#line 12 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                       Margin.Dense

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(23, "Label", "Durum");
                            __builder5.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 12 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                                                                         projectMilestoneType.IsActive

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => projectMilestoneType.IsActive = __value, projectMilestoneType.IsActive))));
                            __builder5.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudSelectItem<bool>>(27);
                                __builder6.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 13 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                                       true

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(30, "Aktif");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(31, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudSelectItem<bool>>(32);
                                __builder6.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 14 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                                       false

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(35, "Pasif");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(36, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(37);
                        __builder4.AddAttribute(38, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(39, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                     12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(40, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.Alaca.Crm.Client.Pages.Projects.AddEditMilestoneTypes.TypeInference.CreateMudTextField_0(__builder5, 42, 43, "Proje Süreç Türü", 44, 
#nullable restore
#line 18 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                                                                                                            ()=>projectMilestoneType.ProjectMilestoneTypeName

#line default
#line hidden
#nullable disable
                            , 45, 
#nullable restore
#line 18 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                                                        projectMilestoneType.ProjectMilestoneTypeName

#line default
#line hidden
#nullable disable
                            , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => projectMilestoneType.ProjectMilestoneTypeName = __value, projectMilestoneType.ProjectMilestoneTypeName)));
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(47, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 23 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
             if (projectMilestoneType.ProjectMilestoneTypeId != 0)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(48);
                    __builder3.AddAttribute(49, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 25 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                      MudBlazor.Color.Warning

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                                                      MudBlazor.Icons.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                                                                                              Delete

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(53, "Sil");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 26 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(54);
                    __builder3.AddAttribute(55, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                  MudBlazor.Icons.Filled.Save

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 27 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                                                      MudBlazor.Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 27 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\AddEditMilestoneTypes.razor"
                                                                                                           MudBlazor.ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(59, "Kaydet");
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
namespace __Blazor.Alaca.Crm.Client.Pages.Projects.AddEditMilestoneTypes
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
