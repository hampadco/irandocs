#pragma checksum "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b846254acb8459541b2e4080a8b1a980c0b68c99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_index), @"mvc.1.0.view", @"/Views/Contact/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b846254acb8459541b2e4080a8b1a980c0b68c99", @"/Views/Contact/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c63872adf158985dc29e69c8ab5f89b8bcb1b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"   <link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.3.4/dist/leaflet.css"" />
<script src=""https://unpkg.com/leaflet@1.3.4/dist/leaflet.js""></script>
   
    <style>
        #map { height:300px; width:100%; }
       

    </style>

             <div class=""row match-height justify-content-center mt-2  "">


                 
                    <div class=""col-lg-10 col-12  text-center"">
                        
                        
                        <section id=""timeline-card"">



<div class=""col-lg-12 col-12 p-0"">
                                <div class=""card rounded-0 mb-0 px-2"">
                                    <div class=""card-header pb-1"">
                                        <div class=""card-title"">
                                            <h4 class=""mb-0"">ارتباط با ما</h4>
                                        </div>
                                    </div>
                                    <p class=""px-2"">خوش آمدید،لطفا نظرات  و انتقاداتون ");
            WriteLiteral(" رو برای ما بفرستید.</p>\r\n                                    <div class=\"card-content\">\r\n                                        <div class=\"card-body pt-1\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b846254acb8459541b2e4080a8b1a980c0b68c994805", async() => {
                WriteLiteral(@"
                                                <fieldset class=""form-label-group form-group position-relative has-icon-left"">
                                                    <input type=""text"" class=""form-control"" id=""user-name"" placeholder=""نام و فامیلی""");
                BeginWriteAttribute("required", " required=\"", 1517, "\"", 1528, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                    <div class=""form-control-position"">
                                                        <i class=""feather icon-user""></i>
                                                    </div>
                                                    <label for=""user-name"">نام کاربری</label>
                                                </fieldset>

                                                <fieldset class=""form-label-group position-relative has-icon-left"">
                                                    <input type=""text"" class=""form-control"" id=""user-password"" placeholder=""ایمیل خود را وارد کنید""");
                BeginWriteAttribute("required", " required=\"", 2194, "\"", 2205, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                    <div class=""form-control-position"">
                                                        <i class=""feather icon-mail""></i>
                                                    </div>
                                                    <label for=""user-password"">کلمه عبور</label>
                                                </fieldset>
                                                <fieldset class=""form-label-group position-relative has-icon-left"">
                                                    <textarea class=""form-control"" placeholder=""لطفا نظرات  و انتقاداتون  رو برای ما بفرستید""></textarea>
                                                    <div class=""form-control-position"">
                                                        <i class=""feather icon-mail""></i>
                                                    </div>
                                                    <label for=""user-password"">کلمه عبور</label>
            ");
                WriteLiteral(@"                                    </fieldset>
                                                
                                                <a href=""#"" class=""btn btn-outline-primary float-right  btn-inline waves-effect waves-light"">ارسال</a>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                                    <div class=""login-footer"">
                                        <div class=""divider"">
                                            <div class=""divider-text"">یا</div>
                                        </div>



                                    </div>
                                </div>
                            </div>
                            <br>



















                            <div class=""row "">
                                
                                
");
#nullable restore
#line 92 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                 if (ViewBag.address != null)
                                {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                 foreach (var item in ViewBag.address)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-lg-6 col-sm-12"">
                                    <div class=""card"">

                                        <div class=""card-content"">
                                            <div class=""card-body"">
                                                <ul class=""activity-timeline timeline-left list-unstyled"">

                                                    <li>
                                                        <div class=""timeline-icon bg-warning"">
                                                            <i class=""feather icon-check font-medium-2""></i>
                                                        </div>
                                                        <div class=""timeline-info"">
                                                            <p class=""font-weight-bold"" style=""text-align: right;"">
                                                                شماره تماس های ثابت :</p>
                                ");
            WriteLiteral("                            <br>\r\n                                                           \r\n                                                              <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5599, "\"", 5623, 1);
#nullable restore
#line 112 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
WriteAttributeValue("", 5607, item.LocationAd, 5607, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""location"" style=""display:none;"">
                                                            <div class=""col-lg-12 d-lg-block  text-center align-self-center px-1 py-0"">


                                <div class=""footer-btn alert alert-primary  "">

                                    <a");
            BeginWriteAttribute("href", " href=\"", 5924, "\"", 5953, 2);
            WriteAttributeValue("", 5931, "tel:", 5931, 4, true);
#nullable restore
#line 118 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
WriteAttributeValue("", 5935, item.Officetel1Ad, 5935, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary col-12 text-white  waves-effect waves-light\"><span class=\"feather icon-phone-call mr-1\"></span> شماره تماس ثابت اول :");
#nullable restore
#line 118 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                                                                                                                                                                                            Write(item.Officetel1Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 119 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                    if (@item.Officetel2Ad != null)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                              <a");
            BeginWriteAttribute("href", " href=\"", 6315, "\"", 6344, 2);
            WriteAttributeValue("", 6322, "tel:", 6322, 4, true);
#nullable restore
#line 121 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
WriteAttributeValue("", 6326, item.Officetel2Ad, 6326, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary col-12 text-white  waves-effect waves-light mt-2\"><span class=\"feather icon-phone-call mr-1\"></span> شماره تماس ثابت اول :");
#nullable restore
#line 121 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                                                                                                                                                                                                                           Write(item.Officetel2Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 122 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </div>
















                                                            

                                                        </div>

                                                    </li>

                                                    <li>
                                                        <div class=""timeline-icon bg-primary"">
                                                            <i class=""feather icon-check font-medium-2""></i>
                                                        </div>
                                                        <div class=""timeline-info"">
                                                            <p class=""font-weight-bold"" style=""text-align: right;"">
                                                                شماره تماس های همراه :</p>
                                                            <br>
                                     ");
            WriteLiteral("                       <p style=\"text-align: ;line-height: 50px;font-size: 20px;\">\r\n                                                                <a style=\"text-align: ;line-height: 50px;font-size: 20px;\"");
            BeginWriteAttribute("href", "\r\n                                                                    href=\"", 7808, "\"", 7900, 2);
            WriteAttributeValue("", 7884, "tel:", 7884, 4, true);
#nullable restore
#line 157 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
WriteAttributeValue("", 7888, item.Tel1Ad, 7888, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                    <b class=\"btn btn-primary btn-lg\">");
#nullable restore
#line 158 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                                                                                 Write(item.Tel1Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                                                    <i class=\"fa fa-phone\"></i>\r\n                                                                </a>\r\n");
#nullable restore
#line 161 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                                                 if (@item.Tel2Ad != null)
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <a style=\"text-align: ;line-height: 50px;font-size: 20px;\"");
            BeginWriteAttribute("href", "\r\n                                                                    href=\"", 8472, "\"", 8564, 2);
            WriteAttributeValue("", 8548, "tel:", 8548, 4, true);
#nullable restore
#line 164 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
WriteAttributeValue("", 8552, item.Tel2Ad, 8552, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                    <b class=\"btn btn-primary btn-lg\">");
#nullable restore
#line 165 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                                                                                 Write(item.Tel2Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                                                    <i class=\"fa fa-phone\"></i>\r\n                                                                </a>\r\n");
#nullable restore
#line 168 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                                        </div>

                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-6 col-sm-12"">
                                    <div class=""card"">

                                        <div class=""card-content"">
                                            <div class=""card-body"">
                                                <ul class=""activity-timeline timeline-left list-unstyled"">
                                                    <li>
                                                        <div class=""timeline-icon bg-success"">
                                                            <i class=""feather icon-check font-medium-2""></i>
                       ");
            WriteLiteral(@"                                 </div>
                                                        <div class=""timeline-info"">
                                                            <p class=""font-weight-bold"" style=""text-align: right;""> آدرس
                                                                ها :</p>
                                                           <br>

                                                             <div class=""footer-btn alert alert-primary  "">

                                    <a");
            BeginWriteAttribute("href", " href=\"", 10484, "\"", 10491, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary col-12 text-white  waves-effect waves-light\"><span class=\"feather icon-map-pin mr-1\" style=\"line-height: 30px;\"></span>   آدرس اول :  ");
#nullable restore
#line 196 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                                                                                                                                                                                       Write(item.FirstAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 197 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                    if (@item.SecondAddress != null)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                              <a");
            BeginWriteAttribute("href", " href=\"", 10871, "\"", 10878, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary col-12 text-white  waves-effect waves-light mt-2 \" style=\"line-height: 30px;\"><span class=\"feather icon-map-pin mr-1\"></span> آدرس دوم :");
#nullable restore
#line 199 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                                                                                                                                                                                                                   Write(item.SecondAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 200 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>


                                                        </div>

                                                    </li>

                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 213 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 213 "g:\.Net Core\hampadco\hampad\hampad\Views\Contact\index.cshtml"
                                 
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            
 <div class=""col-sm-12 col-12"">
                               <div id=""map""></div>
                            </div>
                        </section>
                    </div>

                </div>

                             <script>
                                  var locationToStringed=document.getElementById('location').value;
                                 
var input = locationToStringed.replace('(', '');
var latlngStr = input.split("","", 2);
var lat = parseFloat(latlngStr[0]);
var lng = parseFloat(latlngStr[1]);

                                 debugger
         // Creating map options
         var mapOptions = {
            center: [lat,lng],
            zoom: 12
         }
         // Creating a map object
         var map = new L.map('map', mapOptions);

         // Creating a Layer object
         var layer = new L.TileLayer('http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png');

         // A");
            WriteLiteral(@"dding layer to the map
         map.addLayer(layer);

         // Creating a Marker
         var markerOptions = {
            title: ""MyLocation"",
            clickable: true,
            draggable: false
         }
         // Creating a marker
         var marker = L.marker([lat,lng], markerOptions);

         // Adding marker to the map
         marker.addTo(map);


        



      </script>



");
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
