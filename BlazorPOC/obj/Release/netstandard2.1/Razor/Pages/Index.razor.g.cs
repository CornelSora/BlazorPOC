#pragma checksum "C:\Workspace_New\GIT\BlazorNETCorePOC\BlazorPOC\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1263182b655a2f6cfafbc021a8a9bf970c0ef315"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPOC.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Workspace_New\GIT\BlazorNETCorePOC\BlazorPOC\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace_New\GIT\BlazorNETCorePOC\BlazorPOC\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Workspace_New\GIT\BlazorNETCorePOC\BlazorPOC\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Workspace_New\GIT\BlazorNETCorePOC\BlazorPOC\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Workspace_New\GIT\BlazorNETCorePOC\BlazorPOC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Workspace_New\GIT\BlazorNETCorePOC\BlazorPOC\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Workspace_New\GIT\BlazorNETCorePOC\BlazorPOC\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Workspace_New\GIT\BlazorNETCorePOC\BlazorPOC\_Imports.razor"
using BlazorPOC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Workspace_New\GIT\BlazorNETCorePOC\BlazorPOC\_Imports.razor"
using BlazorPOC.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Workspace_New\GIT\BlazorNETCorePOC\BlazorPOC\_Imports.razor"
using POC.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Workspace_New\GIT\BlazorNETCorePOC\BlazorPOC\_Imports.razor"
using POC.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Workspace_New\GIT\BlazorNETCorePOC\BlazorPOC\_Imports.razor"
using POC.ComponentsLibrary.Vue;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<BlazorPOC.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
