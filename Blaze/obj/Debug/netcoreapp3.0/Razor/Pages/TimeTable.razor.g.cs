#pragma checksum "D:\BlazorDemo\Blaze\Blaze\Pages\TimeTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb42581405ca8f2a4cfe98a51dcfb735799ea3d8"
// <auto-generated/>
#pragma warning disable 1591
namespace Blaze.Pages
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MasterLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/timetable")]
    public partial class TimeTable : Blaze.ComponentBaseClass.TimeTableComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    th {\r\n        background-color: white;\r\n    }\r\n\r\n    td {\r\n        color: white;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "booking");
            __builder.AddAttribute(3, "class", "section");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "section-center");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "conferenceroom-status");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-md-12 conf-statuswrap");
            __builder.AddMarkupContent(16, "\r\n\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "row");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-md-3");
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.AddMarkupContent(25, "\r\n                                ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "id", "datepicker");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "type", "date");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "D:\BlazorDemo\Blaze\Blaze\Pages\TimeTable.razor"
                                                                                                      DatePickerValue

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => DatePickerValue = __value, DatePickerValue, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-md-4 p-0");
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group");
            __builder.AddMarkupContent(40, "\r\n                                ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn btn-primary mr-2");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\BlazorDemo\Blaze\Blaze\Pages\TimeTable.razor"
                                                                               SearchConfernce

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "\r\n                                    Search\r\n                                    <i class=\"fa fa-search \" aria-hidden=\"true\"></i>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "type", "button");
            __builder.AddAttribute(48, "class", "btn btn-dribbble px-4");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\BlazorDemo\Blaze\Blaze\Pages\TimeTable.razor"
                                                                                               NavigateNewBookingComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(50, "\r\n                                    New Booking\r\n                                    <i class=\"fa fa-plus-square\" aria-hidden=\"true\"></i>\r\n                                    <span class=\"caret\"></span>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n");
#nullable restore
#line 42 "D:\BlazorDemo\Blaze\Blaze\Pages\TimeTable.razor"
                     if (conferenceRoomModelByDate.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                        ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "row");
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 45 "D:\BlazorDemo\Blaze\Blaze\Pages\TimeTable.razor"
                             foreach (var item in conferenceRoomModelByDate)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "                                ");
            __builder.OpenComponent<Blaze.Shared.BookingTile>(60);
            __builder.AddAttribute(61, "conferenceDetail", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazeShared.ConferenceDetail>(
#nullable restore
#line 47 "D:\BlazorDemo\Blaze\Blaze\Pages\TimeTable.razor"
                                                               item

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 48 "D:\BlazorDemo\Blaze\Blaze\Pages\TimeTable.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 50 "D:\BlazorDemo\Blaze\Blaze\Pages\TimeTable.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "                        ");
            __builder.AddMarkupContent(66, "<div style=\"text-align:center ;background-color:white\">\r\n                            <h3>No more meetings available for today\'s</h3>\r\n                        </div>\r\n");
#nullable restore
#line 56 "D:\BlazorDemo\Blaze\Blaze\Pages\TimeTable.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591