#pragma checksum "D:\BlazorDemo\Blaze\Blaze\Shared\MasterLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98341cc251c6054fbfefbac73b21b014ea8fa79d"
// <auto-generated/>
#pragma warning disable 1591
namespace Blaze.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\BlazorDemo\Blaze\Blaze\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BlazorDemo\Blaze\Blaze\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BlazorDemo\Blaze\Blaze\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BlazorDemo\Blaze\Blaze\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\BlazorDemo\Blaze\Blaze\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\BlazorDemo\Blaze\Blaze\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\BlazorDemo\Blaze\Blaze\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\BlazorDemo\Blaze\Blaze\_Imports.razor"
using Blaze;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\BlazorDemo\Blaze\Blaze\_Imports.razor"
using Blaze.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\BlazorDemo\Blaze\Blaze\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class MasterLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-dark bg-dark fixed-top");
            __builder.AddAttribute(2, "role", "navigation");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.AddMarkupContent(7, "<a class=\"navbar-brand\" href=\"#\"><img src=\"images/DSRCLogo.png\" alt=\"dsrc ogo\"></a>\r\n            ");
            __builder.AddMarkupContent(8, "<button class=\"navbar-toggler border-0\" type=\"button\" data-toggle=\"collapse\" data-target=\"#exCollapsingNavbar\">\r\n                &#9776;\r\n            </button>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "collapse navbar-collapse");
            __builder.AddAttribute(11, "id", "exCollapsingNavbar");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "nav navbar-nav flex-row justify-content-between ml-auto");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "dropdown order-1");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "type", "button");
            __builder.AddAttribute(21, "id", "dropdownMenu1");
            __builder.AddAttribute(22, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\BlazorDemo\Blaze\Blaze\Shared\MasterLayout.razor"
                                                                                                               NavigateToLiveComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "\r\n                            <i class=\"fa fa-television\" aria-hidden=\"true\"></i>\r\n                            Live\r\n                            <span class=\"caret\"></span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "id", "dropdownMenu1");
            __builder.AddAttribute(29, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\BlazorDemo\Blaze\Blaze\Shared\MasterLayout.razor"
                                                                                                               NavigateToTimeTableComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "\r\n                            <i class=\"fa fa-address-book\" aria-hidden=\"true\"></i>\r\n                            Booking\r\n                            <span class=\"caret\"></span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "id", "dropdownMenu1");
            __builder.AddAttribute(36, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\BlazorDemo\Blaze\Blaze\Shared\MasterLayout.razor"
                                                                                                               NavigateToLoginComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "\r\n                            <i class=\"fa fa-key\" aria-hidden=\"true\"></i>\r\n                            Login\r\n                            <span class=\"caret\"></span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "id", "booking");
            __builder.AddAttribute(47, "class", "section");
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.AddContent(49, 
#nullable restore
#line 40 "D:\BlazorDemo\Blaze\Blaze\Shared\MasterLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\BlazorDemo\Blaze\Blaze\Shared\MasterLayout.razor"
      
    private void NavigateToLoginComponent()
    {
        NavigationManager.NavigateTo("/account/login");
    }
    private void NavigateToTimeTableComponent()
    {
        NavigationManager.NavigateTo("/timetable");
    }
     private void NavigateToLiveComponent()
    {
        NavigationManager.NavigateTo("/Conference/Live");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
