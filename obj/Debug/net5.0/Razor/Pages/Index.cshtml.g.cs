#pragma checksum "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "129311ffc230664bdcc583c7b54250511ddc780e8190d6e0deb2d676372c78d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ecom_app.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ecom_app.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"129311ffc230664bdcc583c7b54250511ddc780e8190d6e0deb2d676372c78d9", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"839df734bbc7a9c5fd623eeafbeb3e822ca062bcf3b1cccc6344be9eb47ba4a5", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Products/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<section class=\"product-categories my-5\">\r\n    <div class=\"container\">\r\n        <h2 class=\"text-center mb-4\">Find What You Need</h2>\r\n\r\n        <div class=\"scrolling-wrapper d-flex flex-row flex-nowrap overflow-auto pb-4\">\r\n");
#nullable restore
#line 12 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Index.cshtml"
             foreach (var category in Model.categories)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <div class=\"category-card text-center p-3\">\r\n                    <h5>");
            Write(
#nullable restore
#line 15 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Index.cshtml"
                         category.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5> \r\n\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Index.cshtml"
                         foreach (var product in category.Products.Take(4))
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <div class=\"col-6 p-1\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "129311ffc230664bdcc583c7b54250511ddc780e8190d6e0deb2d676372c78d94869", async() => {
                WriteLiteral("\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 814, "\"", 928, 1);
                WriteAttributeValue("", 820, 
#nullable restore
#line 22 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Index.cshtml"
                                                !string.IsNullOrEmpty(product.ImageUrl) ? product.ImageUrl : Url.Content("~/assets/default_product.jpeg")

#line default
#line hidden
#nullable disable
                , 820, 108, false);
                EndWriteAttribute();
                WriteLiteral("\r\n                                         class=\"img-fluid product-image\"");
                BeginWriteAttribute("alt", "\r\n                                         alt=\"", 1003, "\"", 1064, 1);
                WriteAttributeValue("", 1051, 
#nullable restore
#line 24 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Index.cshtml"
                                               product.Name

#line default
#line hidden
#nullable disable
                , 1051, 13, false);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 21 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Index.cshtml"
                                                                               product.ProductId

#line default
#line hidden
#nullable disable
            );
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
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 27 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                    </div>\r\n\r\n               </div>\r\n");
#nullable restore
#line 31 "C:\Users\Achra\Documents\ILISI 3\ASP .NET\ecom-app\ecom-app\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"        </div>
    </div>
</section>

<!-- CSS for Styling -->
<style>
    /* Horizontal scroll container */
    .scrolling-wrapper {
        display: flex;
        flex-wrap: nowrap; 
        overflow-x: auto; 
        -webkit-overflow-scrolling: touch; /* Smooth scrolling for mobile */
    }

    .category-card {
        border: 1px solid #ddd;
        border-radius: 10px;
        background-color: #fff;
        margin-right: 15px;
        width: 500px; /* Fixed width for large cards */
        flex: 0 0 auto; /* Prevent shrinking or growing */
    }

    .product-image {
        width: 100%; 
        height: 200px; 
        object-fit: cover; /* Maintain aspect ratio while filling the container */
        border-radius: 5px;
    }

</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
