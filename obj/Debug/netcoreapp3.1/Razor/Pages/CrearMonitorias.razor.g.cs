#pragma checksum "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\CrearMonitorias.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eca103e4d21ffefaf7cc8f855ef5b781f0a85d72"
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
#line 2 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\CrearMonitorias.razor"
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
            __builder.AddMarkupContent(10, "\r\n          ");
            __builder.OpenElement(11, "form");
            __builder.AddMarkupContent(12, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "required", true);
            __builder.AddAttribute(15, "placeholder", "Nombre");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\CrearMonitorias.razor"
                                                                                name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(20, "select");
            __builder.AddAttribute(21, "required", true);
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\CrearMonitorias.razor"
                                                faculty

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => faculty = __value, faculty));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(24, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", "Facultad de Ciencias Básicas");
            __builder.AddMarkupContent(27, "\r\n\t\t\t\t\t\t\t\tFacultad de Ciencias Básicas\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", "Facultad de Ciencias Económicas y Empresariales");
            __builder.AddMarkupContent(31, "\r\n\t\t\t\t\t\t\t\tFacultad de Ciencias Económicas y Empresariales\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "Facultad de Comunicación  y Publicidad");
            __builder.AddMarkupContent(35, "\r\n\t\t\t\t\t\t\t\tFacultad de Comunicación y Publicidad\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", "Facultad de Derecho");
            __builder.AddContent(39, "Facultad de Derecho");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(41, "option");
            __builder.AddAttribute(42, "value", "Facultad de Educación");
            __builder.AddMarkupContent(43, "\r\n\t\t\t\t\t\t\t\tFacultad de Educación\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(45, "option");
            __builder.AddAttribute(46, "value", "Facultad de Ingeniería");
            __builder.AddMarkupContent(47, "\r\n\t\t\t\t\t\t\t\tFacultad de Ingeniería\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(49, "option");
            __builder.AddAttribute(50, "value", "Facultad de Salud");
            __builder.AddContent(51, "Facultad de Salud");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(54, "select");
            __builder.AddAttribute(55, "required", true);
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\CrearMonitorias.razor"
                                                day

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => day = __value, day));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(58, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "Lunes");
            __builder.AddContent(61, "Lunes");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(63, "option");
            __builder.AddAttribute(64, "value", "Martes");
            __builder.AddContent(65, "Martes");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(67, "option");
            __builder.AddAttribute(68, "value", "Miércoles");
            __builder.AddMarkupContent(69, "Miércoles");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(71, "option");
            __builder.AddAttribute(72, "value", "Jueves");
            __builder.AddContent(73, "Jueves");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(75, "option");
            __builder.AddAttribute(76, "value", "Viernes");
            __builder.AddContent(77, "Viernes");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(79, "option");
            __builder.AddAttribute(80, "value", "Sábado");
            __builder.AddMarkupContent(81, "Sábado");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(83, "option");
            __builder.AddAttribute(84, "value", "Domingo");
            __builder.AddContent(85, "Domingo");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(88, "label");
            __builder.AddAttribute(89, "for", "init");
            __builder.AddMarkupContent(90, "\r\n\t\t\t\t\t\t\tHora de inicio\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(91, "input");
            __builder.AddAttribute(92, "id", "init");
            __builder.AddAttribute(93, "type", "time");
            __builder.AddAttribute(94, "min", "07:00");
            __builder.AddAttribute(95, "max", "18:00");
            __builder.AddAttribute(96, "required", true);
            __builder.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\CrearMonitorias.razor"
                                                                                                 init

#line default
#line hidden
#nullable disable
            , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => init = __value, init, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(101, "label");
            __builder.AddAttribute(102, "for", "init");
            __builder.AddMarkupContent(103, "\r\n\t\t\t\t\t\t\tHora de Fin\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(104, "input");
            __builder.AddAttribute(105, "id", "init");
            __builder.AddAttribute(106, "type", "time");
            __builder.AddAttribute(107, "min", "07:00");
            __builder.AddAttribute(108, "max", "18:00");
            __builder.AddAttribute(109, "required", true);
            __builder.AddAttribute(110, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\CrearMonitorias.razor"
                                                                                                 end

#line default
#line hidden
#nullable disable
            , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(111, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => end = __value, end, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(114, "input");
            __builder.AddAttribute(115, "placeholder", "Sala");
            __builder.AddAttribute(116, "required", true);
            __builder.AddAttribute(117, "type", "text");
            __builder.AddAttribute(118, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\CrearMonitorias.razor"
                                                                              livingRoom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(119, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => livingRoom = __value, livingRoom));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(121, "input");
            __builder.AddAttribute(122, "placeholder", "Total de cupos");
            __builder.AddAttribute(123, "required", true);
            __builder.AddAttribute(124, "type", "number");
            __builder.AddAttribute(125, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\CrearMonitorias.razor"
                                                                                          initialQuotas

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(126, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => initialQuotas = __value, initialQuotas, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(128, "textarea");
            __builder.AddAttribute(129, "placeholder", "Descripción");
            __builder.AddAttribute(130, "cols", "30");
            __builder.AddAttribute(131, "rows", "10");
            __builder.AddAttribute(132, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\CrearMonitorias.razor"
                                                                                       description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(133, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => description = __value, description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(135, "button");
            __builder.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\CrearMonitorias.razor"
                                           sendData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(137, "type", "button");
            __builder.AddContent(138, "Enviar");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n\t\t");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\CrearMonitorias.razor"
       
  private string name;
  private string faculty;
  private string day;
  private DateTime init;
  private DateTime end;
  private string livingRoom;
  private string initialQuotas;
  private string description;

  private async Task sendData()
    {
        var postBody = new { name = name, faculty = faculty, day= day, init= init.ToString(), end= end.ToString(), livingRoom= livingRoom, initialQuotas= initialQuotas, description= description};
        var response = await Http.PostAsJsonAsync("http://localhost:8080/api/monitorias", postBody);

        Console.WriteLine(response);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
