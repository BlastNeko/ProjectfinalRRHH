#pragma checksum "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73916f04a6f7fa720ce4b66f20b425205ce290c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjectfinalRRHH.Pages.Empleados.Views_Empleados_Inactivo), @"mvc.1.0.view", @"/Views/Empleados/Inactivo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empleados/Inactivo.cshtml", typeof(ProjectfinalRRHH.Pages.Empleados.Views_Empleados_Inactivo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73916f04a6f7fa720ce4b66f20b425205ce290c9", @"/Views/Empleados/Inactivo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454d513b24f5cc080aafd3e3c6fc903fe309cb26", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Inactivo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectfinalRRHH.Models.MantenimientoEmpleado>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Inactivos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
  
    ViewData["Title"] = "Inactivo";

#line default
#line hidden
            BeginContext(107, 31, true);
            WriteLiteral("\n<h1>Empleados Inactivos</h1>\n\n");
            EndContext();
            BeginContext(138, 516, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19227a27b1a5438c8ce7cd3371a98be6", async() => {
                BeginContext(181, 466, true);
                WriteLiteral(@"
    <div class=""form-actions no-color d-flex justify-content-between"" style="" border:solid; border-radius:5px; border-width:2px; padding:0.6px"">
        <input type=""search"" name=""busqueda"" value="""" class=""form-control"" placeholder=""Buscar por nombre..."">
        <input type=""date"" name=""fecha0"" value="""" class=""form-control"" placeholder=""Buscar por fecha..."">
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
            BeginContext(654, 118, true);
            WriteLiteral("\n\n<table class=\"table table-responsive\">\n    <thead>\n        <tr>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(773, 26, false);
#line 20 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
           Write(Html.DisplayName("Codigo"));

#line default
#line hidden
            EndContext();
            BeginContext(799, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(871, 42, false);
#line 23 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(913, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(985, 44, false);
#line 26 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(1101, 44, false);
#line 29 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(1217, 48, false);
#line 32 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
           Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(1337, 27, false);
#line 35 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
           Write(Html.DisplayName("Ingreso"));

#line default
#line hidden
            EndContext();
            BeginContext(1364, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(1436, 43, false);
#line 38 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
           Write(Html.DisplayNameFor(model => model.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(1479, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(1551, 26, false);
#line 41 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
           Write(Html.DisplayName("Estado"));

#line default
#line hidden
            EndContext();
            BeginContext(1577, 71, true);
            WriteLiteral("\n            </th>\n            <th class=\"table-dark\">\n                ");
            EndContext();
            BeginContext(1649, 41, false);
#line 44 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
           Write(Html.DisplayNameFor(model => model.Cargo));

#line default
#line hidden
            EndContext();
            BeginContext(1690, 58, true);
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 49 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
         foreach (var item in Model)
        {

            if (item.Estatus == false)
            {

#line default
#line hidden
            BeginContext(1849, 70, true);
            WriteLiteral("                <tr>\n                    <td>\n                        ");
            EndContext();
            BeginContext(1920, 49, false);
#line 56 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CodigoEmpleado));

#line default
#line hidden
            EndContext();
            BeginContext(1969, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(2046, 41, false);
#line 59 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(2087, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(2164, 43, false);
#line 62 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(2207, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(2284, 43, false);
#line 65 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(2327, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(2404, 47, false);
#line 68 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(2451, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(2528, 47, false);
#line 71 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FechaIngreso));

#line default
#line hidden
            EndContext();
            BeginContext(2575, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(2652, 42, false);
#line 74 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(2694, 52, true);
            WriteLiteral("\n                    </td>\n                    <td>\n");
            EndContext();
#line 77 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
                         if (item.Estatus == true)
                        {

#line default
#line hidden
            BeginContext(2823, 26, false);
#line 78 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
                    Write(Html.DisplayName("Activo"));

#line default
#line hidden
            EndContext();
#line 78 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
                                                    }
                        else if (item.Estatus == false)
                        {

#line default
#line hidden
            BeginContext(2933, 28, false);
#line 80 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
                    Write(Html.DisplayName("Inactivo"));

#line default
#line hidden
            EndContext();
#line 80 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
                                                      }

#line default
#line hidden
            BeginContext(2963, 75, true);
            WriteLiteral("                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(3039, 40, false);
#line 83 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cargo));

#line default
#line hidden
            EndContext();
            BeginContext(3079, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 86 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Inactivo.cshtml"
            }
            else { }
        }

#line default
#line hidden
            BeginContext(3173, 32, true);
            WriteLiteral("    </tbody>\n</table>\n<div>\n    ");
            EndContext();
            BeginContext(3205, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e63c0a9fbaaa4de4ab7fe851f392a3d3", async() => {
                BeginContext(3227, 14, true);
                WriteLiteral("Volver a Lista");
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
            BeginContext(3245, 9, true);
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectfinalRRHH.Models.MantenimientoEmpleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
