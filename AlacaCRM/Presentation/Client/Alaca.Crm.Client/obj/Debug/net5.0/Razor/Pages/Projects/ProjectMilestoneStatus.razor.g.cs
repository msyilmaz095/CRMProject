#pragma checksum "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abe8c3a95786ec4ae64dfbcdd6cbc95fcee67c1c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/MilestoneStatus")]
    public partial class ProjectMilestoneStatus : Microsoft.AspNetCore.Components.ComponentBase
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
#line 6 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIcon>(7);
                        __builder4.AddAttribute(8, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                Icons.Material.Filled.Update

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(9, "Class", "mr-3 mb-n1");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(10, "\r\n                Proje Süreç Durumu\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(11, "CardHeaderActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(12);
                    __builder3.AddAttribute(13, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                 MudBlazor.Icons.Filled.Add

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                                     MudBlazor.Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                                                                       NewMilestoneStatus

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCardContent>(17);
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.DataGrid.DataGrid<ProjectMilestoneStatu>>(19);
                    __builder3.AddAttribute(20, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                          true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Responsive", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ProjectMilestoneStatu>>(
#nullable restore
#line 14 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                                                          projectMilestoneStatus

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "RowClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazorise.DataGrid.DataGridRowMouseEventArgs<ProjectMilestoneStatu>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazorise.DataGrid.DataGridRowMouseEventArgs<ProjectMilestoneStatu>>(this, 
#nullable restore
#line 14 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                                                                                                e=>RowClick(e.Item)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(25, "Class", "table table-striped table-bordered table-hover");
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridColumn<ProjectMilestoneStatu>>(27);
                        __builder4.AddAttribute(28, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                    nameof(ProjectMilestoneStatu.ProjectMilestoneStatuName)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "Caption", "Adı");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.DataGrid.DataGridCheckColumn<ProjectMilestoneStatu>>(31);
                        __builder4.AddAttribute(32, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                         nameof(ProjectMilestoneStatu.IsActive)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "Caption", "Aktif");
                        __builder4.AddAttribute(34, "TextAlignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.TextAlignment>(
#nullable restore
#line 17 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                                                                                              Blazorise.TextAlignment.Center

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(35, "DisplayTemplate", (Microsoft.AspNetCore.Components.RenderFragment<ProjectMilestoneStatu>)((context) => (__builder5) => {
                            __builder5.OpenComponent<Blazorise.Check<bool>>(36);
                            __builder5.AddAttribute(37, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 19 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                            context.IsActive

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(38, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(39, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
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
            __builder.AddMarkupContent(40, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialog>(41);
            __builder.AddAttribute(42, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                            visible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "IsVisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => visible = __value, visible))));
            __builder.AddAttribute(44, "TitleContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(45);
                __builder2.AddAttribute(46, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 27 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(48, "\r\n            Statu Kaydı\r\n        ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(49, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudGrid>(50);
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(52);
                    __builder3.AddAttribute(53, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                 12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudSelect<bool>>(57);
                        __builder4.AddAttribute(58, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Margin>(
#nullable restore
#line 34 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                   Margin.Dense

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(59, "Label", "Durum");
                        __builder4.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 34 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                                     projectMilestoneStatu.IsActive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => projectMilestoneStatu.IsActive = __value, projectMilestoneStatu.IsActive))));
                        __builder4.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudSelectItem<bool>>(63);
                            __builder5.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 35 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                   true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(66, "Aktif");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(67, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudSelectItem<bool>>(68);
                            __builder5.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 36 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                   false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(71, "Pasif");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(73);
                    __builder3.AddAttribute(74, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                 12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.Alaca.Crm.Client.Pages.Projects.ProjectMilestoneStatus.TypeInference.CreateMudTextField_0(__builder4, 78, 79, "Proje Durum Adı", 80, 
#nullable restore
#line 40 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                                                                         ()=>projectMilestoneStatu.ProjectMilestoneStatuName

#line default
#line hidden
#nullable disable
                        , 81, 
#nullable restore
#line 40 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                   projectMilestoneStatu.ProjectMilestoneStatuName

#line default
#line hidden
#nullable disable
                        , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => projectMilestoneStatu.ProjectMilestoneStatuName = __value, projectMilestoneStatu.ProjectMilestoneStatuName)));
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(83, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 45 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
         if (projectMilestoneStatu.ProjectMilestoneStatuId != 0)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudIconButton>(84);
                __builder2.AddAttribute(85, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 47 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                  MudBlazor.Color.Warning

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                  MudBlazor.Icons.Filled.Delete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                                                          Delete

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(89, "Sil");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 48 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudIconButton>(90);
                __builder2.AddAttribute(91, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 49 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                              MudBlazor.Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                              MudBlazor.Icons.Filled.Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\msyil\Documents\GitHub\Ozel-Projeler\AlacaCRM\Presentation\Client\Alaca.Crm.Client\Pages\Projects\ProjectMilestoneStatus.razor"
                                                                                                    Save

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(95, "Kaydet");
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
namespace __Blazor.Alaca.Crm.Client.Pages.Projects.ProjectMilestoneStatus
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
