// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\RiderProjects\Client\Client\Pages\Tester.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\RiderProjects\Client\Client\Pages\Tester.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tester")]
    public partial class Tester : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Bruger\RiderProjects\Client\Client\Pages\Tester.razor"
       
    private string x,y,z;
    private Test test = new Test();
    private Test alltests;
    //private int currentCount = 0;
    
    protected async Task SearchTest()
    {
        alltests = await tst.GetTestAsync(z);
        //test = alltests;
        
        Console.WriteLine(alltests.phoneNo);
        Console.WriteLine(alltests.name);
    }

    protected async Task SendTest()
    {
        await tst.PostTest(x, y);
    }


    //<button class="btn btn-primary" @onclick="IncrementCount">Execute test</button>

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITest tst { get; set; }
    }
}
#pragma warning restore 1591