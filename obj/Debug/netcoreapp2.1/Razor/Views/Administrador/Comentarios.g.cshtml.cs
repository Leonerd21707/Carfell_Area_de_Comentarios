#pragma checksum "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Comentarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efc26ee38cfb43fd5214e3985f535263779ff1de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Comentarios), @"mvc.1.0.view", @"/Views/Administrador/Comentarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Comentarios.cshtml", typeof(AspNetCore.Views_Administrador_Comentarios))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Comentarios.cshtml"
using Senai.Sprint4.Carfel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efc26ee38cfb43fd5214e3985f535263779ff1de", @"/Views/Administrador/Comentarios.cshtml")]
    public class Views_Administrador_Comentarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Comentarios.cshtml"
  
    ViewBag.Title = "Aprove ou Rejeite um comenttario";
    Layout = "MasterPageLogado";

#line default
#line hidden
            BeginContext(137, 91, true);
            WriteLiteral("\r\n<h1>Seleção de comentarios</h1>\r\n\r\n<style>\r\ntextarea{\r\n    resize: none;\r\n}\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(229, 16, false);
#line 16 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Comentarios.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(245, 259, true);
            WriteLiteral(@"

<table>
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Comentario</th>
            <th>Data Criação</th>
            <th>Status</th>
            <th>ações</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 30 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Comentarios.cshtml"
         foreach (var item in ViewData["comentarios"] as List<ComentarioModel>)
        {

#line default
#line hidden
            BeginContext(596, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(657, 7, false);
#line 34 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Comentarios.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(664, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(732, 17, false);
#line 37 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Comentarios.cshtml"
               Write(item.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(749, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(817, 15, false);
#line 40 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Comentarios.cshtml"
               Write(item.Comentario);

#line default
#line hidden
            EndContext();
            BeginContext(832, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(900, 36, false);
#line 43 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Comentarios.cshtml"
               Write(item.DataCriacao.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(936, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1004, 13, false);
#line 46 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Comentarios.cshtml"
               Write(item.Aprovado);

#line default
#line hidden
            EndContext();
            BeginContext(1017, 68, true);
            WriteLiteral("\r\n               </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1085, "\"", 1126, 2);
            WriteAttributeValue("", 1092, "/Administrador/Alterar?id=", 1092, 26, true);
#line 49 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 1118, item.Id, 1118, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1127, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 50 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Comentarios.cshtml"
                     if(item.Aprovado){
                       Html.Raw("Rejeitar");
                    } else {
                        Html.Raw("Aprovar");
                    }

#line default
#line hidden
            BeginContext(1316, 90, true);
            WriteLiteral("                    </a>\r\n                    \r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 59 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Comentarios.cshtml"
        }

#line default
#line hidden
            BeginContext(1417, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
