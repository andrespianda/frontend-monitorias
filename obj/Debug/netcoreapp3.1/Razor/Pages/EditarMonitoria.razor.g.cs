#pragma checksum "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\EditarMonitoria.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7505d79864e3abec415ab407dbf2a1a2a11497e7"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\EditarMonitoria.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\EditarMonitoria.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mainLayout");
            __builder.AddMarkupContent(2, "\r\n\t\t\t");
            __builder.OpenComponent<Frontend.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\t\t\t");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "mainLayout__container");
            __builder.AddMarkupContent(7, "\r\n\t\t\t\t");
            __builder.AddMarkupContent(8, @"<header class=""mainLayout__container__header"">
					<div class=""mainLayout__container__header__gradient"">
						<h1 class=""color-white"">Sistema de monitorias</h1>
						<span class=""color-white"">Universidad Santiago de Cali</span>
					</div>
				</header>
				");
            __builder.OpenElement(9, "main");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 17 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\EditarMonitoria.razor"
           if (loading == false){

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "          ");
            __builder.OpenElement(12, "h1");
            __builder.AddContent(13, "Blazor is ");
            __builder.AddContent(14, 
#nullable restore
#line 18 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\EditarMonitoria.razor"
                         monitoria.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, "!");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.AddContent(17, "          ");
            __builder.OpenElement(18, "form");
            __builder.AddMarkupContent(19, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "required", true);
            __builder.AddAttribute(22, "placeholder", "Nombre");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\EditarMonitoria.razor"
                                                                                monitoria.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => monitoria.Name = __value, monitoria.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(27, "select");
            __builder.AddAttribute(28, "required", true);
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\EditarMonitoria.razor"
                                                monitoria.faculty

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => monitoria.faculty = __value, monitoria.faculty));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(31, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "Facultad de Ciencias Básicas");
            __builder.AddMarkupContent(34, "\r\n\t\t\t\t\t\t\t\tFacultad de Ciencias Básicas\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "Facultad de Ciencias Económicas y Empresariales");
            __builder.AddMarkupContent(38, "\r\n\t\t\t\t\t\t\t\tFacultad de Ciencias Económicas y Empresariales\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", "Facultad de Comunicación  y Publicidad");
            __builder.AddMarkupContent(42, "\r\n\t\t\t\t\t\t\t\tFacultad de Comunicación y Publicidad\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(44, "option");
            __builder.AddAttribute(45, "value", "Facultad de Derecho");
            __builder.AddContent(46, "Facultad de Derecho");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(48, "option");
            __builder.AddAttribute(49, "value", "Facultad de Educación");
            __builder.AddMarkupContent(50, "\r\n\t\t\t\t\t\t\t\tFacultad de Educación\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(52, "option");
            __builder.AddAttribute(53, "value", "Facultad de Ingeniería");
            __builder.AddMarkupContent(54, "\r\n\t\t\t\t\t\t\t\tFacultad de Ingeniería\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(56, "option");
            __builder.AddAttribute(57, "value", "Facultad de Salud");
            __builder.AddContent(58, "Facultad de Salud");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(61, "select");
            __builder.AddAttribute(62, "required", true);
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\EditarMonitoria.razor"
                                                monitoria.day

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => monitoria.day = __value, monitoria.day));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(65, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(66, "option");
            __builder.AddAttribute(67, "value", "Lunes");
            __builder.AddContent(68, "Lunes");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(70, "option");
            __builder.AddAttribute(71, "value", "Martes");
            __builder.AddContent(72, "Martes");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", "Miércoles");
            __builder.AddMarkupContent(76, "Miércoles");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(78, "option");
            __builder.AddAttribute(79, "value", "Jueves");
            __builder.AddContent(80, "Jueves");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(82, "option");
            __builder.AddAttribute(83, "value", "Viernes");
            __builder.AddContent(84, "Viernes");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(86, "option");
            __builder.AddAttribute(87, "value", "Sábado");
            __builder.AddMarkupContent(88, "Sábado");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(90, "option");
            __builder.AddAttribute(91, "value", "Domingo");
            __builder.AddContent(92, "Domingo");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n\t\t\t\t\t\t");
            __builder.AddMarkupContent(95, "<label for=\"init\">\r\n\t\t\t\t\t\t\tHora de inicio\r\n\t\t\t\t\t\t\t<input id=\"init\" type=\"time\" min=\"07:00\" max=\"18:00\" required @* @bind=\"monitoria.init\" *@>\r\n\t\t\t\t\t\t</label>\r\n\t\t\t\t\t\t");
            __builder.AddMarkupContent(96, "<label for=\"init\">\r\n\t\t\t\t\t\t\tHora de Fin\r\n\t\t\t\t\t\t\t<input id=\"init\" type=\"time\" min=\"07:00\" max=\"18:00\" required @* @bind=\"monitoria.end\" *@>\r\n\t\t\t\t\t\t</label>\r\n\t\t\t\t\t\t");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "placeholder", "Sala");
            __builder.AddAttribute(99, "required", true);
            __builder.AddAttribute(100, "type", "text");
            __builder.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\EditarMonitoria.razor"
                                                                              monitoria.livingRoom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => monitoria.livingRoom = __value, monitoria.livingRoom));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(104, "input");
            __builder.AddAttribute(105, "placeholder", "Total de cupos");
            __builder.AddAttribute(106, "required", true);
            __builder.AddAttribute(107, "type", "number");
            __builder.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\EditarMonitoria.razor"
                                                                                          monitoria.initialQuotas

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => monitoria.initialQuotas = __value, monitoria.initialQuotas, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(111, "textarea");
            __builder.AddAttribute(112, "placeholder", "Descripción");
            __builder.AddAttribute(113, "cols", "30");
            __builder.AddAttribute(114, "rows", "10");
            __builder.AddAttribute(115, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\EditarMonitoria.razor"
                                                                                       monitoria.description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => monitoria.description = __value, monitoria.description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n\t\t\t\t\t\t");
            __builder.AddMarkupContent(118, "<button @* @onclick=\"@sendData\" *@ type=\"button\">Enviar</button>\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n");
#nullable restore
#line 63 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\EditarMonitoria.razor"
          }

#line default
#line hidden
#nullable disable
            __builder.AddContent(120, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n\t\t");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\EditarMonitoria.razor"
       
  [Parameter]
  public string Id { get; set; }

  public bool loading = true;
  
  Monitoria monitoria { get; set; }

  private static readonly System.Text.Json.JsonSerializerOptions s_options = 
    new System.Text.Json.JsonSerializerOptions() 
  {
    PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
    PropertyNameCaseInsensitive = true,
  };
  
  protected override async Task OnInitializedAsync()
    {
        var httpResponse = await Http.GetFromJsonAsync<Monitoria>("http://localhost:8080/api/monitorias/"+Id, s_options);
        monitoria = httpResponse;
        loading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
