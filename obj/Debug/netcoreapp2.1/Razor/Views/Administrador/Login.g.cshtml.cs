#pragma checksum "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "728f6bc07978f8b877d9ae9f2b0742919943e100"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Login), @"mvc.1.0.view", @"/Views/Administrador/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Login.cshtml", typeof(AspNetCore.Views_Administrador_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"728f6bc07978f8b877d9ae9f2b0742919943e100", @"/Views/Administrador/Login.cshtml")]
    public class Views_Administrador_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Login.cshtml"
  
    ViewBag.Title = "Login";
    Layout = "MasterPageDeslogado";

#line default
#line hidden
            BeginContext(74, 103, true);
            WriteLiteral("\r\n<link href=\"/css/login.css\" rel=\"stylesheet\" type=\"text/css\"/>\r\n\r\n<h1>Login de Administrador</h1>\r\n\r\n");
            EndContext();
            BeginContext(178, 16, false);
#line 10 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Login.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(194, 330, true);
            WriteLiteral(@"

<form action=""/Administrador/Login"" method=""POST"">
    <label  >
        Email
        <input type=""text"" name=""email"" required=""true"">
    </label>
    <label class=""cor-azul"">
        Senha
        <input type=""password"" name=""senha"" required=""true"">
    </label>

    <input type=""submit"" value=""Entrar"">
</form>");
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
