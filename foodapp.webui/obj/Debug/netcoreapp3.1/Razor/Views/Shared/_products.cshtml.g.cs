#pragma checksum "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "578e53ad005158c7f26339486be28f6c069c56c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__products), @"mvc.1.0.view", @"/Views/Shared/_products.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\_ViewImports.cshtml"
using foodapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\_ViewImports.cshtml"
using foodapp.webui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\_ViewImports.cshtml"
using foodapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\_ViewImports.cshtml"
using foodapp.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\_ViewImports.cshtml"
using foodapp.webui.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578e53ad005158c7f26339486be28f6c069c56c2", @"/Views/Shared/_products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792e53754977ff9e2b5ae4b755dd1b7490f297aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 200px; height:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid changingImage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("srcset", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info float-right my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container-fluid form-inline \">\r\n    <div class=\"col-md-12 mt-3\">\r\n        <div class=\"card\">\r\n            <div class=\"card-horizontal\">\r\n                <div class=\"img-square-wrapper\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "578e53ad005158c7f26339486be28f6c069c56c26866", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 247, "~/img/Products/", 247, 15, true);
#nullable restore
#line 8 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
AddHtmlAttributeValue("", 262, Model.ImageUrl, 262, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-body\">\r\n\r\n                    <h5 class=\"card-title text-dark\">\r\n                        ");
#nullable restore
#line 14 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text text-dark\">\r\n                        ");
#nullable restore
#line 16 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</p>\r\n                    <div class=\"input-group float-right my-2\">\r\n\r\n                        <div class=\"input-group-prepend\">\r\n                            <button class=\"btn btn-info btn-sm text-light\"");
            BeginWriteAttribute("id", "\r\n                                id=\"", 852, "\"", 912, 2);
            WriteAttributeValue("", 890, "minus-", 890, 6, true);
#nullable restore
#line 21 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
WriteAttributeValue("", 896, Model.ProductId, 896, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-minus\"></i></button>\r\n                        </div>\r\n                        <input type=\"text\" class=\"form-control input-sm\" onkeypress=\"return isNumber(event)\"");
            BeginWriteAttribute("id", "\r\n                            id=\"", 1093, "\"", 1152, 2);
            WriteAttributeValue("", 1127, "quantity-", 1127, 9, true);
#nullable restore
#line 24 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
WriteAttributeValue("", 1136, Model.ProductId, 1136, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"quantity\" value=\"1\" min=\"1\" max=\"100\"\r\n                            step=\"1\">\r\n                        <div class=\"input-group-append\">\r\n                            <button class=\"btn btn-info btn-sm text-light\"");
            BeginWriteAttribute("id", "\r\n                                id=\"", 1370, "\"", 1429, 2);
            WriteAttributeValue("", 1408, "plus-", 1408, 5, true);
#nullable restore
#line 28 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
WriteAttributeValue("", 1413, Model.ProductId, 1413, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-plus\"></i></button>\r\n                        </div>\r\n                        <input type=\"hidden\" name=\"productId\"");
            BeginWriteAttribute("id", " id=\"", 1562, "\"", 1593, 2);
            WriteAttributeValue("", 1567, "productId-", 1567, 10, true);
#nullable restore
#line 30 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
WriteAttributeValue("", 1577, Model.ProductId, 1577, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                            value=\"", 1594, "\"", 1647, 1);
#nullable restore
#line 31 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
WriteAttributeValue("", 1631, Model.ProductId, 1631, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            <input type=\"hidden\" name=\"CategoryId\"");
            BeginWriteAttribute("id", " id=\"", 1719, "\"", 1751, 2);
            WriteAttributeValue("", 1724, "productId-", 1724, 10, true);
#nullable restore
#line 33 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
WriteAttributeValue("", 1734, Model.CategoryId, 1734, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                            value=\"", 1752, "\"", 1806, 1);
#nullable restore
#line 34 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
WriteAttributeValue("", 1789, Model.CategoryId, 1789, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            \r\n                            <script>\r\n                                $(document).ready(function () {\r\n                                        \r\n                                            $(\"#plus-");
#nullable restore
#line 39 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
                                                Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function (e) { \r\n                                                let quantity=$(\"#quantity-");
#nullable restore
#line 40 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
                                                                     Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""").val();
                                                quantity++;
                                                if (quantity>=100) {
                                                    quantity=99;
                                                }
                                                $(""#quantity-");
#nullable restore
#line 45 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
                                                        Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").val(quantity);\r\n                                                e.preventDefault();\r\n                                            });\r\n                                            $(\"#minus-");
#nullable restore
#line 48 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
                                                 Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function (e) { \r\n                                                let quantity=$(\"#quantity-");
#nullable restore
#line 49 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
                                                                     Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""").val();
                                                quantity--;
                                                if (quantity<=0) {
                                                    quantity=1;
                                                }
                                                $(""#quantity-");
#nullable restore
#line 54 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
                                                        Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""").val(quantity);
                                                e.preventDefault();
                                            });


                                        
                               
                                $(""#addToCart-");
#nullable restore
#line 61 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
                                         Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").click(function(e){\r\n                                    const productId=$(\"#productId-");
#nullable restore
#line 62 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
                                                             Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").val();\r\n                                    const quantity=$(\"#quantity-");
#nullable restore
#line 63 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
                                                           Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""").val();
                                    var data = {""ProductId"" : productId, ""Quantity"" : quantity};
                                    
                                    $.ajax({
                                      async:true,
                                      type: ""POST"",
                                      url: ""/Cart/AddtoCart"",
                                      data: data,
                                      dataType:""JSON"",
                                      success: function (response) {
                                      }
                                     }).always(function () {

                                         $.ajax({
                                             type: ""GET"",
                                             url: ""/cart"",
                                             success: function (response) {
                                                 if (response.match(/productInCart/gm)==null) {
                                      ");
            WriteLiteral(@"               $(""#notification"").css(""display"", ""none"");
                                                 }else{
                                                     $(""#notification"").css(""display"", ""inline"");
                                                 notification = response.match(/productInCart/gm).length;
                                                                           $(""#notification"").html(notification);
                                                  }
                                              }
                                          });


                                        });
                                    e.preventDefault();
                                })

                                });
                                   
                            </script>
                            
                           
                        
                    </div>
                </div>
            </div>

");
#nullable restore
#line 105 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
             if (!User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <div class=\"col-auto\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "578e53ad005158c7f26339486be28f6c069c56c220067", async() => {
                WriteLiteral("Sepete\r\n                            Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 114 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <div class=\"col-auto\">\r\n                        <button class=\"btn btn-outline-info float-right my-2\"\r\n                            type=\"submit\"");
            BeginWriteAttribute("id", " id=\"", 6304, "\"", 6335, 2);
            WriteAttributeValue("", 6309, "addToCart-", 6309, 10, true);
#nullable restore
#line 120 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
WriteAttributeValue("", 6319, Model.ProductId, 6319, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sepete Ekle</button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 123 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Shared\_products.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
