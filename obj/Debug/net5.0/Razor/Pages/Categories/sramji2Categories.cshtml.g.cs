#pragma checksum "C:\Users\sramj\OneDrive\Desktop\BAIST 3150\UIAssignmentRazorPages\Pages\Categories\sramji2Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39885bba7d30f3c166423a9026824315c94d2654"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UIAssignmentRazorPages.Pages.Categories.Pages_Categories_sramji2Categories), @"mvc.1.0.razor-page", @"/Pages/Categories/sramji2Categories.cshtml")]
namespace UIAssignmentRazorPages.Pages.Categories
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\sramj\OneDrive\Desktop\BAIST 3150\UIAssignmentRazorPages\Pages\_ViewImports.cshtml"
using UIAssignmentRazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39885bba7d30f3c166423a9026824315c94d2654", @"/Pages/Categories/sramji2Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c097e476c506d63df77b1c17a5dc06890c1d5b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Categories_sramji2Categories : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Northwind Categories</h1>\r\n\r\n<table border= \"1\">\r\n    <tr class=\"table-secondary\">\r\n        <th>Category Name</th>\r\n        <th>Description</th>\r\n        <th>Picture</th>\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\sramj\OneDrive\Desktop\BAIST 3150\UIAssignmentRazorPages\Pages\Categories\sramji2Categories.cshtml"
     foreach (var item in Model.Categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 18 "C:\Users\sramj\OneDrive\Desktop\BAIST 3150\UIAssignmentRazorPages\Pages\Categories\sramji2Categories.cshtml"
   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    <td>");
#nullable restore
#line 20 "C:\Users\sramj\OneDrive\Desktop\BAIST 3150\UIAssignmentRazorPages\Pages\Categories\sramji2Categories.cshtml"
   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 423, "\"", 516, 2);
            WriteAttributeValue("", 429, "data:image/png;base64,", 429, 22, true);
#nullable restore
#line 22 "C:\Users\sramj\OneDrive\Desktop\BAIST 3150\UIAssignmentRazorPages\Pages\Categories\sramji2Categories.cshtml"
WriteAttributeValue("", 451, Convert.ToBase64String(item.Picture,78, item.Picture.Length -78), 451, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </td>\r\n");
            WriteLiteral("</tr>\r\n");
#nullable restore
#line 26 "C:\Users\sramj\OneDrive\Desktop\BAIST 3150\UIAssignmentRazorPages\Pages\Categories\sramji2Categories.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UIAssignmentRazorPages.Pages.Categories.sramji2CategoriesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UIAssignmentRazorPages.Pages.Categories.sramji2CategoriesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UIAssignmentRazorPages.Pages.Categories.sramji2CategoriesModel>)PageContext?.ViewData;
        public UIAssignmentRazorPages.Pages.Categories.sramji2CategoriesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
