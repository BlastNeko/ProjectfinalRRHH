#pragma checksum "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f455d86cdee226ea06b98079e2e69ef05baf66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjectfinalRRHH.Pages.Empleados.Views_Empleados_Details), @"mvc.1.0.view", @"/Views/Empleados/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empleados/Details.cshtml", typeof(ProjectfinalRRHH.Pages.Empleados.Views_Empleados_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8f455d86cdee226ea06b98079e2e69ef05baf66", @"/Views/Empleados/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454d513b24f5cc080aafd3e3c6fc903fe309cb26", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectfinalRRHH.Models.MantenimientoEmpleado>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
  
    ViewData["Title"] = "Detalles";

#line default
#line hidden
            BeginContext(95, 138, true);
            WriteLiteral("\n<h1>Detalles</h1>\n\n<div>\n    <h4>Mantenimiento Empleado</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(234, 50, false);
#line 14 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CodigoEmpleado));

#line default
#line hidden
            EndContext();
            BeginContext(284, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(345, 46, false);
#line 17 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.CodigoEmpleado));

#line default
#line hidden
            EndContext();
            BeginContext(391, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(451, 42, false);
#line 20 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(493, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(554, 38, false);
#line 23 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(592, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(652, 44, false);
#line 26 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(696, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(757, 40, false);
#line 29 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(797, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(857, 44, false);
#line 32 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(901, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(962, 40, false);
#line 35 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1062, 48, false);
#line 38 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1171, 44, false);
#line 41 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1275, 48, false);
#line 44 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaIngreso));

#line default
#line hidden
            EndContext();
            BeginContext(1323, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1384, 44, false);
#line 47 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaIngreso));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1488, 43, false);
#line 50 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1592, 39, false);
#line 53 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1691, 43, false);
#line 56 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estatus));

#line default
#line hidden
            EndContext();
            BeginContext(1734, 46, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n");
            EndContext();
#line 59 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
             if (Model.Estatus == true)
            {

#line default
#line hidden
            BeginContext(1834, 26, false);
#line 60 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
        Write(Html.DisplayName("Activo"));

#line default
#line hidden
            EndContext();
#line 60 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
                                        }
            else if (Model.Estatus == false)
            {

#line default
#line hidden
            BeginContext(1921, 28, false);
#line 62 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
        Write(Html.DisplayName("Inactivo"));

#line default
#line hidden
            EndContext();
#line 62 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
                                          }

#line default
#line hidden
            BeginContext(1951, 58, true);
            WriteLiteral("        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2010, 41, false);
#line 65 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cargo));

#line default
#line hidden
            EndContext();
            BeginContext(2051, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2112, 37, false);
#line 68 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cargo));

#line default
#line hidden
            EndContext();
            BeginContext(2149, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(2191, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "287b713bd8bd4ca78907bb7852d237bf", async() => {
                BeginContext(2237, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\USER\source\repos\ProjectfinalRRHH\ProjectfinalRRHH\Views\Empleados\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2247, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(2254, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f12fb60996b4a4987424e6d13220f17", async() => {
                BeginContext(2276, 23, true);
                WriteLiteral("Volver a lista Completa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2303, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectfinalRRHH.Models.MantenimientoEmpleado> Html { get; private set; }
    }
}
#pragma warning restore 1591
