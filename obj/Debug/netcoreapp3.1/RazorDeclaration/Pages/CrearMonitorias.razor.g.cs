#pragma checksum "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\CrearMonitorias.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb0775f5b3ad17ae3d7ef2526328f4a5f68ad90"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Frontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\CrearMonitorias.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/nueva-monitoria")]
    public partial class CrearMonitorias : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\CrearMonitorias.razor"
       
  private string name;
  private string faculty;
  private string day;
  private DateTime init;
  private DateTime end;
  private string livingRoom;
  private string initialQuotas;
  private string description;
  bool loadingToken = true;


	protected async override Task OnAfterRenderAsync(bool firstRender)    
	{
		if (firstRender)
    {
  			var aux = await localStorage.GetItemAsync<string>("token");
				if(aux == null){
					loadingToken = false;
					NavigationManager.NavigateTo("/login");
				}else{
					loadingToken = false;
				}
    }
		StateHasChanged();
	}

  private async Task sendData()
    {
        var postBody = new { name = name, faculty = faculty, day= day, init= init.ToString(), end= end.ToString(), livingRoom= livingRoom, initialQuotas= initialQuotas, description= description};
        var response = await Http.PostAsJsonAsync("http://localhost:8080/api/monitorias", postBody);

        Console.WriteLine(response);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
