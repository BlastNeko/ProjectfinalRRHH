#pragma checksum "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Permisosx.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "638cd9dc2cd0f195eb25a57f4c8bd038a4f15187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjectfinalRRHH.Pages.Empleados.Views_Empleados_Permisosx), @"mvc.1.0.view", @"/Views/Empleados/Permisosx.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empleados/Permisosx.cshtml", typeof(ProjectfinalRRHH.Pages.Empleados.Views_Empleados_Permisosx))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"638cd9dc2cd0f195eb25a57f4c8bd038a4f15187", @"/Views/Empleados/Permisosx.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454d513b24f5cc080aafd3e3c6fc903fe309cb26", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Permisosx : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectfinalRRHH.Models.ProcessPermisos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Permisosx", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Permisos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Permisosx.cshtml"
  
    ViewData["Title"] = "Permisos";

#line default
#line hidden
            BeginContext(101, 20, true);
            WriteLiteral("\n<h1>Permisos</h1>\n\n");
            EndContext();
            BeginContext(121, 405, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9280279e0f84442ab9a959370fde1480", async() => {
                BeginContext(164, 355, true);
                WriteLiteral(@"
    <div class=""form-actions no-color d-flex justify-content-between"" style="" border:solid; border-radius:5px; border-width:2px; padding:0.6px"">
        <input type=""date"" name=""fecha4"" value="""" class=""form-control"" placeholder=""Buscar por fecha..."">
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
            BeginContext(526, 101, true);
            WriteLiteral("\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(628, 43, false);
#line 19 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Permisosx.cshtml"
           Write(Html.DisplayNameFor(model=> model.Empleado));

#line default
#line hidden
            EndContext();
            BeginContext(671, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(743, 41, false);
#line 22 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Permisosx.cshtml"
           Write(Html.DisplayNameFor(model => model.Desde));

#line default
#line hidden
            EndContext();
            BeginContext(784, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(856, 41, false);
#line 25 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Permisosx.cshtml"
           Write(Html.DisplayNameFor(model => model.Hasta));

#line default
#line hidden
            EndContext();
            BeginContext(897, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(969, 46, false);
#line 28 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Permisosx.cshtml"
           Write(Html.DisplayNameFor(model => model.Comentario));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 58, true);
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 33 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Permisosx.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1120, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(1179, 43, false);
#line 37 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Permisosx.cshtml"
               Write(Html.DisplayFor(modelItem => item.Empleado));

#line default
#line hidden
            EndContext();
            BeginContext(1222, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1287, 40, false);
#line 40 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Permisosx.cshtml"
               Write(Html.DisplayFor(modelItem => item.Desde));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1392, 40, false);
#line 43 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Permisosx.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hasta));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1497, 45, false);
#line 46 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Permisosx.cshtml"
               Write(Html.DisplayFor(modelItem => item.Comentario));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 49 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Permisosx.cshtml"
        }

#line default
#line hidden
            BeginContext(1593, 32, true);
            WriteLiteral("    </tbody>\n</table>\n<div>\n    ");
            EndContext();
            BeginContext(1625, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c79f88fb540845dc89de2bb14cb75f9c", async() => {
                BeginContext(1650, 15, true);
                WriteLiteral("Agregar Permiso");
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
            BeginContext(1669, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1676, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91d5a75cbe984c928fcad2781fe2269c", async() => {
                BeginContext(1698, 14, true);
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
            BeginContext(1716, 7, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectfinalRRHH.Models.ProcessPermisos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
