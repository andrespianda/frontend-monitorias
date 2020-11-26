#pragma checksum "c:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Registro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d442c056414e741396eb3e184ee890889f635d5d"
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
#line 2 "c:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Registro.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Registro.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Registro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "c:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Registro.razor"
       
	private string name;
	private string career;
	private string mail;
	private string code;
	private string id;
	private string password;

	private string _error = "";

	public class responseData
	{
		public string token { get; set; }
		public string error { get; set; }
	}


	private async void sendData()
	{
		var postBody = new { name = name, code = code, career = career, mail = mail, password = password, roll = 3 };
		var response = await Http.PostAsJsonAsync("http://localhost:8080/api/usuarios/register", postBody);

		var responseString = await response.Content.ReadFromJsonAsync<responseData>();
		

		if (responseString.error == "")
		{
			if (responseString.token != null)
    	{
				await localStore.SetItemAsync("token", responseString.token);
				NavigationManager.NavigateTo("/monitorias");
    	}
		}
		else
		{
			_error = responseString.error;
		}
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
