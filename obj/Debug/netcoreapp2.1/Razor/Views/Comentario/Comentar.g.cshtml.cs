#pragma checksum "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Comentario\Comentar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8e98b55a959c36b2b1dc1dc4d8c40e0f10b6c9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_Comentar), @"mvc.1.0.view", @"/Views/Comentario/Comentar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/Comentar.cshtml", typeof(AspNetCore.Views_Comentario_Comentar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8e98b55a959c36b2b1dc1dc4d8c40e0f10b6c9e", @"/Views/Comentario/Comentar.cshtml")]
    public class Views_Comentario_Comentar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Comentario\Comentar.cshtml"
  
    ViewBag.Title = "Fazer um Comentario";
    Layout = "MasterPageLogado";

#line default
#line hidden
            BeginContext(85, 77, true);
            WriteLiteral("\r\n<h1>FeedBack</h1>\r\n\r\n<style>\r\ntextarea{\r\n    resize: none;\r\n}\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(163, 16, false);
#line 14 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Comentario\Comentar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(179, 209, true);
            WriteLiteral("\r\n\r\n<form action=\"/Comentario/Comentar\" method=\"POST\">\r\n      \r\n     <textarea  name=\"comentario\" rows=\"6\" cols=\"50\" required> \r\n     </textarea>\r\n    <input type=\"submit\"    value=\"Enviar\">\r\n    \r\n</form>\r\n\r\n");
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
