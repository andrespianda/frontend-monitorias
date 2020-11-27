#pragma checksum "c:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\EditarMonitoria.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49aa824a599bdc6f1453cc7211a1e09e9e4d24b1"
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
#line 2 "c:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\EditarMonitoria.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\EditarMonitoria.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/monitorias/{id}")]
    public partial class EditarMonitoria : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "c:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\EditarMonitoria.razor"
       
  [Parameter]
  public string Id { get; set; }

  public bool loading = true;
  
  Monitoria monitoria { get; set; }
	private DateTime init;
  private DateTime end;
	public bool success = false;
	public bool error = false;
	bool loadingToken = true;
	Usuario usuario { get; set; }

  private static readonly System.Text.Json.JsonSerializerOptions s_options = 
    new System.Text.Json.JsonSerializerOptions() 
  {
    PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
    PropertyNameCaseInsensitive = true,
  };

	private async Task edit()
    {
			try
			{	
				monitoria.init = init.ToString();
				monitoria.end = end.ToString();
        var response = await Http.PutAsJsonAsync<Monitoria>("http://localhost:8080/api/monitorias/"+Id, monitoria);
				success = true;
			}
			catch (System.Exception)
			{
					error = true;
			}
	
    }

	protected async override Task OnAfterRenderAsync(bool firstRender)    
	{
		if (firstRender)
    {
  			var aux = await localStorage.GetItemAsync<string>("token");
				if(aux == null){
					loadingToken = false;
					NavigationManager.NavigateTo("/");
				}else{
					loadingToken = false;
					var httpResponseUser = await Http.GetFromJsonAsync<Usuario>("http://localhost:8080/api/usuarios/" + aux, s_options );
					usuario = httpResponseUser; 
					if (usuario.roll != 1)
					{
							NavigationManager.NavigateTo("/monitorias");
					}
        	loading = false;
				}
    }
		StateHasChanged();
	}
  
  protected override async Task OnInitializedAsync()
    {
        var httpResponse = await Http.GetFromJsonAsync<Monitoria>("http://localhost:8080/api/monitorias/"+Id, s_options);
        monitoria = httpResponse;
				init = DateTime.Parse(httpResponse.init);
				end = DateTime.Parse(httpResponse.end);
        loading = false;
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
