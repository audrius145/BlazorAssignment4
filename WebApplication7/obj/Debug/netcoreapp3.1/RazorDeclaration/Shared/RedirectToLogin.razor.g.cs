#pragma checksum "D:\.net\Solution1\WebApplication7\Shared\RedirectToLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f351bb05622a7fc65765dcc76309bb93d682a300"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication7.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using WebApplication7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using WebApplication7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\.net\Solution1\WebApplication7\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "D:\.net\Solution1\WebApplication7\Shared\RedirectToLogin.razor"
       
    [CascadingParameter]
    public Task<AuthenticationState> AuthenticationState { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var auth = await AuthenticationState;

        if (auth?.User?.Identity is null || !auth.User.Identity.IsAuthenticated)
        {
            navigationManager.NavigateTo("/", true);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
