#pragma checksum "/Users/xlash/Code/Blake/Blake.Client/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ef1317b2f36400bcdba3da980e32b2c4cc172b0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blake.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/xlash/Code/Blake/Blake.Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/xlash/Code/Blake/Blake.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/Users/xlash/Code/Blake/Blake.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "/Users/xlash/Code/Blake/Blake.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "/Users/xlash/Code/Blake/Blake.Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/Users/xlash/Code/Blake/Blake.Client/_Imports.razor"
using Blake.Client;

#line default
#line hidden
#line 7 "/Users/xlash/Code/Blake/Blake.Client/_Imports.razor"
using Blake.Client.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 9 "/Users/xlash/Code/Blake/Blake.Client/Pages/Counter.razor"
       
    int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
