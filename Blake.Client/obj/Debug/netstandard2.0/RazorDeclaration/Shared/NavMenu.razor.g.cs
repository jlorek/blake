#pragma checksum "/Users/xlash/Code/Blake/Blake.Client/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b29e18954329bad34074fbdb675b92caf5decaab"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blake.Client.Shared
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
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 33 "/Users/xlash/Code/Blake/Blake.Client/Shared/NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591