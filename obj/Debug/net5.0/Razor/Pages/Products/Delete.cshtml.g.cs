#pragma checksum "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b082de72b4b406b534f9161b7a35c48e650479175aef630c83bbd54b42cd0a36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ecom_app.Pages.Products.Pages_Products_Delete), @"mvc.1.0.razor-page", @"/Pages/Products/Delete.cshtml")]
namespace ecom_app.Pages.Products
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\_ViewImports.cshtml"
using ecom_app

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b082de72b4b406b534f9161b7a35c48e650479175aef630c83bbd54b42cd0a36", @"/Pages/Products/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"839df734bbc7a9c5fd623eeafbeb3e822ca062bcf3b1cccc6344be9eb47ba4a5", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Products_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 16 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
             Html.DisplayNameFor(model => model.Product.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 19 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
             Html.DisplayFor(model => model.Product.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 22 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
             Html.DisplayNameFor(model => model.Product.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 25 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
             Html.DisplayFor(model => model.Product.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 28 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
             Html.DisplayNameFor(model => model.Product.Price)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 31 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
             Html.DisplayFor(model => model.Product.Price)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 34 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
             Html.DisplayNameFor(model => model.Product.Stock)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 37 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
             Html.DisplayFor(model => model.Product.Stock)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 40 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
             Html.DisplayNameFor(model => model.Product.ImageUrl)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 43 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
             Html.DisplayFor(model => model.Product.ImageUrl)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 46 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
             Html.DisplayNameFor(model => model.Product.Category)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 49 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
             Html.DisplayFor(model => model.Product.Category.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b082de72b4b406b534f9161b7a35c48e650479175aef630c83bbd54b42cd0a369271", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b082de72b4b406b534f9161b7a35c48e650479175aef630c83bbd54b42cd0a369561", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.
#nullable restore
#line 54 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Products\Delete.cshtml"
                                      Product.ProductId

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b082de72b4b406b534f9161b7a35c48e650479175aef630c83bbd54b42cd0a3611469", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ecom_app.Pages.Products.DeleteModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ecom_app.Pages.Products.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ecom_app.Pages.Products.DeleteModel>)PageContext?.ViewData;
        public ecom_app.Pages.Products.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
