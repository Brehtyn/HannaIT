#pragma checksum "C:\Users\admin\Desktop\HannaIT\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1758ee4c52a19bd57b17b4219284d40ebb371ec"
// <auto-generated/>
#pragma warning disable 1591
namespace HannaIT.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\admin\Desktop\HannaIT\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\HannaIT\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\HannaIT\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\Desktop\HannaIT\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\admin\Desktop\HannaIT\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\admin\Desktop\HannaIT\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\admin\Desktop\HannaIT\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\admin\Desktop\HannaIT\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\admin\Desktop\HannaIT\_Imports.razor"
using HannaIT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\admin\Desktop\HannaIT\_Imports.razor"
using HannaIT.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"home_banner\" b-y7xreefxs1><img width=\"100%\" src=\"assets/home_banner.jpg\" b-y7xreefxs1></div>   \n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page");
            __builder.AddAttribute(3, "b-y7xreefxs1");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "sidebar");
            __builder.AddAttribute(6, "b-y7xreefxs1");
            __builder.OpenComponent<HannaIT.Shared.NavMenu>(7);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "main");
            __builder.AddAttribute(11, "b-y7xreefxs1");
            __builder.AddMarkupContent(12, @"<div class=""quick_info"" b-y7xreefxs1><div class=""contact_info"" b-y7xreefxs1><span class=""oi oi-phone"" aria-hidden=""true"" b-y7xreefxs1></span> 
             <a href=""(702)???-???"" b-y7xreefxs1> Call Us </a> &nbsp;
             <span class=""oi oi-chat"" aria-hidden=""true"" b-y7xreefxs1></span> 
             <a href=""mailto: Email: Support@HannaIT.com"" b-y7xreefxs1> Email: Support@HannaIT.com </a></div>
        <div class=""hours_info"" b-y7xreefxs1><span class=""oi oi-bell"" aria-hidden=""true"" align=""right"" b-y7xreefxs1></span> 
             Hours: Clients 24/7 | Inquiries 10am-7pm &nbsp;&nbsp;
        </div></div>

        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "content px-4");
            __builder.AddAttribute(15, "b-y7xreefxs1");
            __builder.AddContent(16, 
#nullable restore
#line 27 "C:\Users\admin\Desktop\HannaIT\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n\n    ");
            __builder.AddMarkupContent(18, "<div align=\"bottom-left\" style=\"margin-left:-32px;,float:bottom;\" b-y7xreefxs1><img src=\"assets/footer_heel.png\" b-y7xreefxs1></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.AddMarkupContent(20, "<div class=\"footer\" b-y7xreefxs1><p b-y7xreefxs1> © HannaIT All Rights Reserved 2021 | Made by Brentyn Hanna </p></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
