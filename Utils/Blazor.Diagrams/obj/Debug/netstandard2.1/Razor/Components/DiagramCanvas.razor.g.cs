#pragma checksum "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6af19c09b115648d23990f394c85453a5cce3537"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Diagrams.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\_Imports.razor"
using Blazor.Diagrams.Components.Base;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\_Imports.razor"
using Blazor.Diagrams.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\_Imports.razor"
using Blazor.Diagrams.Core.Models;

#line default
#line hidden
#nullable disable
    public partial class DiagramCanvas : DiagramCanvasComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "diagram-canvas");
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                   OnMouseDown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                   OnMouseMove

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(5, "onmousemove", true);
            __builder.AddAttribute(6, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                 OnMouseUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                 OnKeyDown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onwheel", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.WheelEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
               OnWheel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(9, "onwheel", true);
            __builder.AddElementReferenceCapture(10, (__value) => {
#nullable restore
#line 5 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
           elementReference = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.OpenElement(12, "svg");
            __builder.AddAttribute(13, "class", "diagram-svg-layer");
            __builder.AddAttribute(14, "style", "transform:" + " translate(" + (
#nullable restore
#line 16 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                                       PanX

#line default
#line hidden
#nullable disable
            ) + "px," + " " + (
#nullable restore
#line 16 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                                                  PanY

#line default
#line hidden
#nullable disable
            ) + "px)" + " scale(" + (
#nullable restore
#line 16 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                                                                  Zoom

#line default
#line hidden
#nullable disable
            ) + ");");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 17 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
         foreach (var link in DiagramManager.AllLinks)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.OpenComponent<Blazor.Diagrams.Components.LinkRenderer>(17);
            __builder.AddAttribute(18, "Link", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor.Diagrams.Core.Models.LinkModel>(
#nullable restore
#line 19 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                                               link

#line default
#line hidden
#nullable disable
            ));
            __builder.SetKey(
#nullable restore
#line 19 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                                link.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 20 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 22 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
         foreach (var node in DiagramManager.Nodes.Where(n => n.Layer == RenderLayer.SVG))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "            ");
            __builder.OpenComponent<Blazor.Diagrams.Components.NodeRenderer>(22);
            __builder.AddAttribute(23, "Node", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor.Diagrams.Core.Models.NodeModel>(
#nullable restore
#line 24 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                                               node

#line default
#line hidden
#nullable disable
            ));
            __builder.SetKey(
#nullable restore
#line 24 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                                node.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 25 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "diagram-html-layer");
            __builder.AddAttribute(29, "style", "transform:" + " translate(" + (
#nullable restore
#line 30 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                                       PanX

#line default
#line hidden
#nullable disable
            ) + "px," + " " + (
#nullable restore
#line 30 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                                                  PanY

#line default
#line hidden
#nullable disable
            ) + "px)" + " scale(" + (
#nullable restore
#line 30 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                                                                  Zoom

#line default
#line hidden
#nullable disable
            ) + ");");
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 31 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
         foreach (var node in DiagramManager.Nodes.Where(n => n.Layer == RenderLayer.HTML))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "            ");
            __builder.OpenComponent<Blazor.Diagrams.Components.NodeRenderer>(32);
            __builder.AddAttribute(33, "Node", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor.Diagrams.Core.Models.NodeModel>(
#nullable restore
#line 33 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                                               node

#line default
#line hidden
#nullable disable
            ));
            __builder.SetKey(
#nullable restore
#line 33 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
                                node.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 34 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n");
            __builder.AddContent(38, 
#nullable restore
#line 38 "C:\Users\Lucca\Documents\GitHub\Cross-Check\XStock\SeeSharply\Utils\Blazor.Diagrams\Components\DiagramCanvas.razor"
 Widgets

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591