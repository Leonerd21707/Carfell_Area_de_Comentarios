#pragma checksum "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "724728f0d6913eb8705bb6980ad417c895964981"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Cadastrar), @"mvc.1.0.view", @"/Views/Administrador/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Cadastrar.cshtml", typeof(AspNetCore.Views_Administrador_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"724728f0d6913eb8705bb6980ad417c895964981", @"/Views/Administrador/Cadastrar.cshtml")]
    public class Views_Administrador_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Cadastrar.cshtml"
  
    ViewBag.Title = "Cadastrar Administrador";
    Layout = "MasterPageDeslogado";

#line default
#line hidden
            BeginContext(92, 43, true);
            WriteLiteral("\r\n<h1> Cadastro de Administradores</h1>\r\n\r\n");
            EndContext();
            BeginContext(136, 16, false);
#line 8 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Senai.Sprint4.Carfel\Views\Administrador\Cadastrar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(152, 381, true);
            WriteLiteral(@"

<form action=""/Administrador/Cadastrar"" method=""POST"">
    <label>
        Nome
        <input type=""text""  name=""nome"">
    </label>

    <label>
        Email
        <input type=""email"" name=""email"">
    </label>

    <label>
        Senha
        <input type=""password"" name=""senha"">
    </label>
    

    <input type=""submit"" value=""Enviar"">

</form>
");
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
