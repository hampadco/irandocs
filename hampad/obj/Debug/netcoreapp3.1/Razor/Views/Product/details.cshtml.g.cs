#pragma checksum "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39cc1db5eabcd72c381f8c52612cb548b925ba9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_details), @"mvc.1.0.view", @"/Views/Product/details.cshtml")]
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
#line 1 "g:\.Net Core\hampadco\hampad\hampad\Views\_ViewImports.cshtml"
using hampad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "g:\.Net Core\hampadco\hampad\hampad\Views\_ViewImports.cshtml"
using hampad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39cc1db5eabcd72c381f8c52612cb548b925ba9f", @"/Views/Product/details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c63872adf158985dc29e69c8ab5f89b8bcb1b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.AdminViewModel.Product.Vm_Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" mt-1  img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img-placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 250px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<section id=""timeline-card"">

    <div class=""row "">


        <div class=""col-lg-6 col-sm-12"">
            <div class=""card"" >

                <div class=""card-content"">
                    <div class=""card-body"">
                        <ul class=""activity-timeline timeline-left list-unstyled"">

                            <li>
                                <div class=""timeline-icon bg-warning"">
                                    <i class=""feather icon-check font-medium-2""></i>
                                </div>
                                <div class=""timeline-info"">
                                    <p class=""font-weight-bold mt-2 mb-2"" style=""text-align: center;font-size: 18px;line-height: 40px;"">
                                      عنوان محصول : ");
#nullable restore
#line 21 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                                               Write(Model.TitleProductPro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                                    <br>


                                    <div class=""col-lg-12 d-lg-block  text-center align-self-center px-1 py-0"">
                                         <div class=""footer-btn alert alert-primary text-center  "" style=""line-height: 40px;font-size: 18px;text-align: justify;"">

                                            برند محصول:");
#nullable restore
#line 28 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                                                  Write(Model.BrandPro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            
                                        </div>
                                         <div class=""footer-btn alert alert-primary text-center  "" style=""line-height: 40px;font-size: 18px;text-align: justify;"">

                                             تعداد در بسته:                         ");
#nullable restore
#line 33 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                                                                               Write(Model.TotalPro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            
                                        </div>
                                         <div class=""footer-btn alert alert-primary text-center  "" style=""line-height: 40px;font-size: 18px;text-align: justify;"">

                                             سایز:");
#nullable restore
#line 38 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                                             Write(Model.SizePro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            
                                        </div>
                                         <div class=""footer-btn alert alert-primary text-center  "" style=""line-height: 40px;font-size: 18px;text-align: justify;"">

                                             جنس:");
#nullable restore
#line 43 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                                            Write(Model.MaterialPro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            
                                        </div>

                                        <div class=""footer-btn alert alert-primary text-center  "" style=""line-height: 40px;font-size: 18px;text-align: justify;"">

                                            قیمت محصول:");
#nullable restore
#line 49 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                                                  Write(Model.PricePro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            
                                        </div>

                                         <div class=""footer-btn alert alert-primary text-center  "" style=""line-height: 40px;font-size: 18px;text-align: justify;"">

                                            درصد تخفیف:");
#nullable restore
#line 55 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                                                  Write(Model.OfferPro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            
                                        </div>
                                         <div class=""footer-btn alert alert-primary text-center  "" style=""line-height: 40px;font-size: 18px;text-align: justify;"">

                                           <a");
            BeginWriteAttribute("href", " href=\"", 3264, "\"", 3271, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary form-control"">اضافه کردن به سبد خرید</a>
                                            
                                        </div>
                                        
                                        
                                    </div>

                                </div>

                            </li>

                            <li>
                             

                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 col-sm-12"">
            <div class=""card"" >

                <div class=""card-content"">
                    <div class=""card-body"">
                        <ul class=""activity-timeline timeline-left list-unstyled"" style=""margin-right: 0px !important;"">
                            <li>
                                <div class=""timeline-icon bg-success"">
                                    <i c");
            WriteLiteral(@"lass=""feather icon-check font-medium-2""></i>
                                </div>
                                <div class=""timeline-info"">
                                    <p class=""font-weight-bold"" style=""text-align: center;""> عکس محصول
                                      </p>
                                    <br>

                                    <div class=""footer-btn alert alert-primary text-center text-center "">

                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39cc1db5eabcd72c381f8c52612cb548b925ba9f12196", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4794, "~/fileupload/", 4794, 13, true);
#nullable restore
#line 97 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
AddHtmlAttributeValue("", 4807, Model.ImageMainPro, 4807, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>


                                </div>

                            </li>

                        </ul>
                    </div>
                </div>
            </div>
        </div>

    </div>





<section id=""ecommerce-products"" class=""row"">

");
#nullable restore
#line 119 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
 if ( ViewBag.baner != null)
                        {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                         foreach (var item in ViewBag.baner)
                        {





#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card ecommerce-card col-lg-4 col-xl-4 col-md-4 col-sm-6 col-12"" style=""background-image:url('../app-assets/images/icons/sidRight1.png')"">
        <div class=""card-content alert alert-secondary "">
            <div class=""item-img text-center"">
               
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39cc1db5eabcd72c381f8c52612cb548b925ba9f14893", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5647, "~/fileupload/", 5647, 13, true);
#nullable restore
#line 131 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
AddHtmlAttributeValue("", 5660, item.ImagePath, 5660, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                
            </div>
            <div class=""card-body"">
                <div class=""item-wrapper text-center"">
                    <div class=""item-rating"">
                        <div class=""badge badge-primary badge-md "">


                            ");
#nullable restore
#line 140 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                       Write(menu.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n            <div class=\"item-options text-center \">\r\n\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 162 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
   
  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
   
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"





</section>
    











<style>
    img{
        max-width: 50%;
  height: auto;
    }
    p{
        text-align:justify;
    }
    
</style>

<div class=""row "">
    <div class=""col-lg-12 col-12 p-0"">
        <div class=""card rounded-0 mb-0 px-2""");
            BeginWriteAttribute("style", " style=\"", 6570, "\"", 6578, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""card-header pb-1 alert alert-primary text-center"">
                <div class=""card-title "">
                    <h4 class=""mb-0"">توضیحات بیشتر</h4>
                </div>
            </div>
            
           <div class=""display-field"" class="" col-9 "">
              ");
#nullable restore
#line 205 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
         Write(Html.Raw(Model.DescreptionPro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             </div>\r\n            \r\n        </div>\r\n    </div>\r\n</div> \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n   <div class=\"col-lg-12 col-12\">\r\n             <div class=\"d-flex justify-content-start align-items-center mb-1\">\r\n                <p class=\"ml-auto d-flex align-items-center\">\r\n                  \r\n              </div>\r\n            \r\n              \r\n");
#nullable restore
#line 228 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                 if (ViewBag.comments != null)
                {
                    
                    
                     

#line default
#line hidden
#nullable disable
#nullable restore
#line 232 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                      foreach (var item1 in ViewBag.comments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <div class=\"d-flex justify-content-start align-items-center mb-1 \" style=\"background-color: white;\">\r\n");
#nullable restore
#line 235 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                      if (item1.image != null)
                     {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <div");
            BeginWriteAttribute("class", " class=\"", 7790, "\"", 7798, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39cc1db5eabcd72c381f8c52612cb548b925ba9f20287", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7830, "~/fileupload/", 7830, 13, true);
#nullable restore
#line 238 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
AddHtmlAttributeValue("", 7843, item1.image, 7843, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 240 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                     }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <div");
            BeginWriteAttribute("class", " class=\"", 7978, "\"", 7986, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                  <img src=\"../../icons/user.png\" alt=\"Avatar\" height=\"70\" width=\"70\">\r\n                </div>\r\n");
#nullable restore
#line 244 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"

                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("               \r\n\r\n                    <div class=\"user-page-info card-title cart\">\r\n                  <h6 class=\"mb-12\">");
#nullable restore
#line 249 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                               Write(item1.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                  <span class=\"font-small-3\">");
#nullable restore
#line 250 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                                        Write(item1.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                </div>\r\n");
#nullable restore
#line 253 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 253 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                 




                }

#line default
#line hidden
#nullable disable
            WriteLiteral("               \r\n                \r\n");
#nullable restore
#line 261 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                if (User.Identity.IsAuthenticated)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"alert alert-success mb-5\" id=\"msg\">نظر خود را تبت کنید</span>\r\n                     <br/>\r\n");
#nullable restore
#line 265 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
               }else
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     <span class=\"alert alert-success mb-5\" id=\"msg\">برای ثبت نظر حتما باید وارد سایت شوید</span>\r\n                                     <br/>\r\n");
#nullable restore
#line 269 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"

               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"             
            
              <div  class=""form-label-group mb-50"">
                   
                  <textarea class=""form-control"" id=""comment"" rows=""3"" required placeholder=""نظر دادن""></textarea>
                 
                 
              </div>
              <div class=""text-center"">
");
#nullable restore
#line 280 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                   if (User.Identity.IsAuthenticated)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a style=\"color: white;\"  class=\"btn btn-md btn-primary text-left mb-5\" onclick=\"sabt()\">ثبت نظر </a>\r\n                        <br/>\r\n");
#nullable restore
#line 284 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                        

                  }else
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <a onclick=\"ref();\"  style=\"color: white;\" class=\"btn btn-md btn-primary text-left mb-5 \" >ثبت نظر </a>\r\n                         <br/>\r\n");
#nullable restore
#line 290 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </div>\r\n   </div>\r\n\r\n\r\n<input id=\"idblog\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 9772, "\"", 9789, 1);
#nullable restore
#line 295 "g:\.Net Core\hampadco\hampad\hampad\Views\Product\details.cshtml"
WriteAttributeValue("", 9780, Model.Id, 9780, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""display: none;"">


<script>

        

     function sabt()
      {
        
        if (document.getElementById(""comment"").value !="""") 
        {
           

            $.ajax({
                url: ""/comment/addproduct?comment="" + document.getElementById(""comment"").value+""&&id=""+document.getElementById(""idblog"").value,
                type: ""post"",
            }).done(function (result)
             {
                if (result == true)
                 {
                
                    $(""#msg"").text(""  نظر شما با موفقیت ثبت شد و منتظر تایید از سوی مدیریت است"");
                   document.getElementById(""comment"").value="""";
                }
            });
        
        }
     }

    
</script>
<script>
    function ref()
    {
      
        document.location.href=""/login/index"";
    }
</script>


");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    \r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.AdminViewModel.Product.Vm_Product> Html { get; private set; }
    }
}
#pragma warning restore 1591