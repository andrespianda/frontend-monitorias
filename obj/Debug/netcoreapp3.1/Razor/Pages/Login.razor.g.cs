#pragma checksum "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67752ec539f31e680ffef105d434c3691adc2e5f"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
using TodoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using TodoList.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<main class=""loginRegister"">
			<section class=""loginRegister__formSection"">
				<img class=""loginRegister__logo"" src=""/img/logo.png"" alt=""Logo"">
				<form class=""loginRegister__form"" action>
					<h1 class=""loginRegister__title"">Iniciar Sesión</h1>
					<input placeholder=""Correo"" class=""loginRegister__input"" type=""email"">
					<input placeholder=""Contraseña"" class=""loginRegister__input"" type=""password"">
					<button class=""loginRegister__button"">Iniciar Sesión</button>
					<p class=""loginRegister__question"">
						¿Aún no tienes cuenta?
						<a class=""loginRegister__question__a"" href=""/sign-up""> Regístrate </a>
					</p>
				</form>
			</section>
			<section class=""loginRegister__imageSection"">
				<h2 class=""loginRegister__imageSection__title"">
					Sistema de <br>
					monitorías
				</h2>
				<img class=""loginRegister__imageSection__img"" src=""/img/login-register/students.png"" alt=""Estudiantes"">
			</section>
		</main>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
