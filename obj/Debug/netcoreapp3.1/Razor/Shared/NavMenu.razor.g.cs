#pragma checksum "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d0d5f37705b12362ad70c6080bd0f24a668b6de"
// <auto-generated/>
#pragma warning disable 1591
namespace Frontend.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""mainLayout__navPanel"">
				<div class=""mainLayout__navPanel__user"">
					<img class=""mainLayout__navPanel__img"" src=""/img/perfil.svg"" alt=""Perfil"">
					<div>
						<span class=""mainLayout__navPanel__username"">Admin</span>
						<br>
						<span>USC</span>
					</div>
				</div>
				<nav class=""nav"">
					<ul class=""nav__ul"">
						<li>
							<a href=""/monitorias"" class=""nav__item"">
								<span class=""nav__item__text"">Monitorias</span>
							</a>
						</li>
						<li>
							<a href=""/"" class=""nav__item"">
								<span class=""nav__item__text"">Monitores</span>
							</a>
						</li>
						<li>
							<a href=""/"" class=""nav__item"">
								<span class=""nav__item__text--logOut"">Cerrar Sesión</span>
							</a>
						</li>
					</ul>
				</nav>
			</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
