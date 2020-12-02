#pragma checksum "/Users/miguelgondres/Projects/DataVentasWeb/Pages/Board.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9585b925211dcb685a9effa9f2a9f3634a797b7"
// <auto-generated/>
#pragma warning disable 1591
namespace DataVentasWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/miguelgondres/Projects/DataVentasWeb/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/miguelgondres/Projects/DataVentasWeb/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/miguelgondres/Projects/DataVentasWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguelgondres/Projects/DataVentasWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/Projects/DataVentasWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/miguelgondres/Projects/DataVentasWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/miguelgondres/Projects/DataVentasWeb/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/miguelgondres/Projects/DataVentasWeb/_Imports.razor"
using DataVentasWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/miguelgondres/Projects/DataVentasWeb/_Imports.razor"
using DataVentasWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/miguelgondres/Projects/DataVentasWeb/_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/miguelgondres/Projects/DataVentasWeb/_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/miguelgondres/Projects/DataVentasWeb/Pages/Board.razor"
using DataVentasWeb.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguelgondres/Projects/DataVentasWeb/Pages/Board.razor"
using DataVentasWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/Projects/DataVentasWeb/Pages/Board.razor"
using DataVentasWeb.DAL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/board")]
    public partial class Board : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "<div class=\"card-header\"><h3>Gameplays made</h3></div>\n\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "input-group");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-6");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "input-group mb-3");
            __builder.OpenElement(15, "select");
            __builder.AddAttribute(16, "class", "form-control");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "/Users/miguelgondres/Projects/DataVentasWeb/Pages/Board.razor"
                                                                filtro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filtro = __value, filtro));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", "0");
            __builder.AddContent(21, "Todos");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "input-group-append");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", "btn btn-primary");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/Users/miguelgondres/Projects/DataVentasWeb/Pages/Board.razor"
                                                                                        Consultar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Serch");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\n    ");
            __builder.OpenElement(31, "table");
            __builder.AddAttribute(32, "class", "table text-center");
            __builder.AddMarkupContent(33, "<thead class=\"thead-light\"><tr><th>Username</th>\n                <th>Time</th>\n                <th>Message</th></tr></thead>\n        ");
            __builder.OpenElement(34, "tbody");
#nullable restore
#line 42 "/Users/miguelgondres/Projects/DataVentasWeb/Pages/Board.razor"
             foreach (var item in lista)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "tr");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 45 "/Users/miguelgondres/Projects/DataVentasWeb/Pages/Board.razor"
                         item.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 46 "/Users/miguelgondres/Projects/DataVentasWeb/Pages/Board.razor"
                         item.Tiempo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 47 "/Users/miguelgondres/Projects/DataVentasWeb/Pages/Board.razor"
                         item.Mensaje

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "/Users/miguelgondres/Projects/DataVentasWeb/Pages/Board.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "/Users/miguelgondres/Projects/DataVentasWeb/Pages/Board.razor"
       

    [Inject]
    public JugadoresBLL JugadoresBLL { get; set; }
    public int filtro { get; set; }
    public List<Jugadores> lista = new List<Jugadores>();


    [Inject]
    public Contexto _contexto { get; set;}

    Jugadores jugador = new Jugadores();

    private void Consultar()
    {
        try
        {
            switch (filtro)
            {
                case 0:
                    this.lista = JugadoresBLL.GetJugadores(p => true);
                    break;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
