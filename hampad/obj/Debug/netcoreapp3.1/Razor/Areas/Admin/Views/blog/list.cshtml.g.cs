#pragma checksum "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3781a890a39f39ba9bd531cf5d98be41ce79fd7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_blog_list), @"mvc.1.0.view", @"/Areas/Admin/Views/blog/list.cshtml")]
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
#nullable restore
#line 1 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\_ViewImports.cshtml"
using hampad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\_ViewImports.cshtml"
using hampad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3781a890a39f39ba9bd531cf5d98be41ce79fd7b", @"/Areas/Admin/Views/blog/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c63872adf158985dc29e69c8ab5f89b8bcb1b3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_blog_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <!-- BEGIN: Content-->\r\n<section id=\"data-list-view\" class=\"data-list-view-header\">\r\n");
#nullable restore
#line 5 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml"
    if (ViewBag.er != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 7 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml"
                              Write(ViewBag.er);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 8 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <!-- DataTable starts -->
  <div class=""table-responsive"">
    <table class=""table data-list-view"">
      <thead>
        <tr>
          <th></th>
          <th>ردیف</th>
          <th> عنوان خبر  </th>
          <th> زبان </th>
          <th> تصویر اصلی </th>
          <th> دسته بندی</th>
          <th> عملیات</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 24 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml"
 if ( ViewBag.list != null)
{
int i=1;
    foreach (var item in ViewBag.list)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\r\n          <td></td>\r\n          <td class=\"product-category\">");
#nullable restore
#line 31 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml"
                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td class=\"product-name\">");
#nullable restore
#line 32 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml"
                              Write(item.TitleBLo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"product-category\">");
#nullable restore
#line 33 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml"
                                    Write(item.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n           <td class=\"product-category\">  <img style=\"width: 60px;border-radius: 50%;\"");
            BeginWriteAttribute("src", " src=\"", 938, "\"", 974, 2);
            WriteAttributeValue("", 944, "/fileupload/", 944, 12, true);
#nullable restore
#line 35 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml"
WriteAttributeValue("", 956, item.ImageMainBlo, 956, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 975, "\"", 981, 0);
            EndWriteAttribute();
            WriteLiteral(">  </td>\r\n            <td class=\"product-category\"> ");
#nullable restore
#line 36 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml"
                                     Write(item.catname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                     \r\n           <td class=\"product-action\">\r\n             <div class=\"col-lg-3 col-md-3 mb-1\">\r\n                <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 1269, "\"", 1307, 2);
            WriteAttributeValue("", 1276, "/admin/Blog/updateblog/", 1276, 23, true);
#nullable restore
#line 41 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml"
WriteAttributeValue("", 1299, item.Id, 1299, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\">مشاهده</a>\r\n                  <a onclick=\"return confirm(\'آیا از حذف رکورد مورد نظر مطمئن هستید؟\')\"");
            BeginWriteAttribute("href", " href=\"", 1439, "\"", 1470, 2);
            WriteAttributeValue("", 1446, "/admin/Blog/del/", 1446, 16, true);
#nullable restore
#line 42 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml"
WriteAttributeValue("", 1462, item.Id, 1462, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">حذف</a>\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 1531, "\"", 1569, 2);
            WriteAttributeValue("", 1538, "/admin/Blog/updateblog/", 1538, 23, true);
#nullable restore
#line 43 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml"
WriteAttributeValue("", 1561, item.Id, 1561, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success  btn-sm\">ویرایش</a>\r\n                </div>\r\n              </div>\r\n          </td>\r\n        </tr>\r\n");
#nullable restore
#line 48 "g:\.Net Core\hampadco\hampad\hampad\Areas\Admin\Views\blog\list.cshtml"
        i++;
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n\r\n\r\n      \r\n\r\n\r\n      </tbody>\r\n    </table>\r\n  </div>\r\n  <!-- DataTable ends -->\r\n\r\n  <!-- add new sidebar starts -->\r\n \r\n  <!-- add new sidebar ends -->\r\n</section>\r\n<!-- Data list view end -->\r\n");
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
