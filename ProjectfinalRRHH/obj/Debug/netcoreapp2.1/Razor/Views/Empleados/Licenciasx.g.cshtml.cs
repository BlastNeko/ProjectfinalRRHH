#pragma checksum "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73569baa629576194673ace43c4f6533ba318a56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjectfinalRRHH.Pages.Empleados.Views_Empleados_Licenciasx), @"mvc.1.0.view", @"/Views/Empleados/Licenciasx.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empleados/Licenciasx.cshtml", typeof(ProjectfinalRRHH.Pages.Empleados.Views_Empleados_Licenciasx))]
namespace ProjectfinalRRHH.Pages.Empleados
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\_ViewImports.cshtml"
using ProjectfinalRRHH;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73569baa629576194673ace43c4f6533ba318a56", @"/Views/Empleados/Licenciasx.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454d513b24f5cc080aafd3e3c6fc903fe309cb26", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Licenciasx : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectfinalRRHH.Models.ProcessLicencias>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Licenciasx", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Licencias", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml"
  
    ViewData["Title"] = "Licenciasx";

#line default
#line hidden
            BeginContext(104, 21, true);
            WriteLiteral("\n<h1>Licencias</h1>\n\n");
            EndContext();
            BeginContext(125, 406, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c2c92c8bbf843daba2ab9a6104a2dbb", async() => {
                BeginContext(169, 355, true);
                WriteLiteral(@"
    <div class=""form-actions no-color d-flex justify-content-between"" style="" border:solid; border-radius:5px; border-width:2px; padding:0.6px"">
        <input type=""date"" name=""fecha3"" value="""" class=""form-control"" placeholder=""Buscar por fecha..."">
        <input type=""submit"" value=""Buscar"" class=""btn btn-outline-success form-control"" />
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(531, 101, true);
            WriteLiteral("\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(633, 43, false);
#line 19 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml"
           Write(Html.DisplayNameFor(model=> model.Empleado));

#line default
#line hidden
            EndContext();
            BeginContext(676, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(748, 41, false);
#line 22 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml"
           Write(Html.DisplayNameFor(model => model.Desde));

#line default
#line hidden
            EndContext();
            BeginContext(789, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(861, 41, false);
#line 25 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml"
           Write(Html.DisplayNameFor(model => model.Hasta));

#line default
#line hidden
            EndContext();
            BeginContext(902, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(974, 42, false);
#line 28 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml"
           Write(Html.DisplayNameFor(model => model.Motivo));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(1088, 46, false);
#line 31 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml"
           Write(Html.DisplayNameFor(model => model.Comentario));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 58, true);
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 36 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1239, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(1298, 43, false);
#line 40 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml"
               Write(Html.DisplayFor(modelItem => item.Empleado));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1406, 40, false);
#line 43 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml"
               Write(Html.DisplayFor(modelItem => item.Desde));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1511, 40, false);
#line 46 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hasta));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1616, 41, false);
#line 49 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml"
               Write(Html.DisplayFor(modelItem => item.Motivo));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1722, 45, false);
#line 52 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml"
               Write(Html.DisplayFor(modelItem => item.Comentario));

#line default
#line hidden
            EndContext();
            BeginContext(1767, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 55 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Licenciasx.cshtml"
        }

#line default
#line hidden
            BeginContext(1818, 32, true);
            WriteLiteral("    </tbody>\n</table>\n<div>\n    ");
            EndContext();
            BeginContext(1850, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d24cb083151043cdb88c09fcc89edad1", async() => {
                BeginContext(1876, 16, true);
                WriteLiteral("Agregar Licencia");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1896, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1903, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4408627109644deab1f2f89d80bb55c", async() => {
                BeginContext(1925, 14, true);
                WriteLiteral("Volver a Lista");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1943, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectfinalRRHH.Models.ProcessLicencias>> Html { get; private set; }
    }
}
#pragma warning restore 1591
