#pragma checksum "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd71de02ca51fa5e27be23d5b592bf67bb2caf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetAllOrders), @"mvc.1.0.view", @"/Views/Admin/GetAllOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd71de02ca51fa5e27be23d5b592bf67bb2caf6", @"/Views/Admin/GetAllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792e53754977ff9e2b5ae4b755dd1b7490f297aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetAllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeOrderState", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/data.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            DefineSection("Css", async() => {
                WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.22/css/dataTables.bootstrap4.min.css\">\r\n");
            }
            );
#nullable restore
#line 8 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
Write(await Html.PartialAsync("_navbar2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<div class=\"container-fluid my-4\">\r\n    <h1>Tüm Siparişlerin Listesi</h1>\r\n       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fd71de02ca51fa5e27be23d5b592bf67bb2caf67564", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 97 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = (TempData.Get<AlertMessage>("message"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        \r\n        <hr>\r\n<div class=\"row\">\r\n    <div class=\"col-md-7\">\r\n        \r\n");
#nullable restore
#line 103 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
         if (Model.Count() == 0)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"alert alert-warning\">Henüz Sipariş Bulunmamaktadır.</div>\r\n");
#nullable restore
#line 106 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""table-responsive"">
        <table class=""table"" id=""myTable"" data-page-length=""10"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Sipariş Numarası</th>
                    <th scope=""col"">Alıcının Adı</th>
                    <th scope=""col"">Telefon</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Sipariş Durumu</th>
                    <th scope=""col"">Adres</th>
                    <th scope=""col"">Toplam Tutar</th>
                    
                    
                    
                </tr>
            </thead>
            <tbody id=""accordion"">
                
");
#nullable restore
#line 125 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                 if (Model!=null && Model.Count()>0)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                     foreach (var order in Model)
                    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("class", " class=", 4735, "", 5069, 1);
#nullable restore
#line 130 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
WriteAttributeValue("", 4742, order.OrderState.Equals(EnumOrderState.waiting)?"bg-warning":
                        order.OrderState.Equals(EnumOrderState.unpaid)?"bg-danger":
                        order.OrderState.Equals(EnumOrderState.onway)?"bg-secondary":
                        order.OrderState.Equals(EnumOrderState.completed)?"bg-success":"", 4742, 327, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <th>\r\n                                <a class=\"btn btn-link\" data-toggle=\"collapse\" data-parent=\"#accordion\" data-target=\"#Order-");
#nullable restore
#line 135 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                                                                                                                       Write(order.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 5249, "\"", 5290, 2);
            WriteAttributeValue("", 5265, "#Order-", 5265, 7, true);
#nullable restore
#line 135 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
WriteAttributeValue("", 5272, order.OrderNumber, 5272, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-expanded=\"false\" role=\"button\">#");
#nullable restore
#line 135 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                                                                                                                                                                                                                          Write(order.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                \r\n                            </th>\r\n                            <td>\r\n                                ");
#nullable restore
#line 139 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                           Write(order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 139 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                                            Write(order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 142 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                           Write(order.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 145 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                           Write(order.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 148 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                           Write(order.OrderStateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 151 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                           Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 155 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                           Write(order.OrderTotal());

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL\r\n\r\n                            </td>\r\n\r\n                            \r\n                            \r\n                        </tr>\r\n");
#nullable restore
#line 162 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                       
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n                \r\n            </tbody>\r\n            \r\n        </table>\r\n        </div>\r\n    </div>\r\n    \r\n       \r\n            <div class=\"col-md-5\">\r\n");
#nullable restore
#line 175 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                  foreach (var order in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card collapse\"");
            BeginWriteAttribute("id", "  id=\"", 6583, "\"", 6613, 2);
            WriteAttributeValue("", 6589, "Order-", 6589, 6, true);
#nullable restore
#line 177 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
WriteAttributeValue("", 6595, order.OrderNumber, 6595, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordion\">\r\n                <div class=\"card-header\">\r\n                    <h4>");
#nullable restore
#line 179 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                   Write(order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 179 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                                    Write(order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | #");
#nullable restore
#line 179 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                                                       Write(order.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <div>\r\n                        \r\n");
#nullable restore
#line 182 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                             foreach (var orderState in ViewBag.EnumOrderValues)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fd71de02ca51fa5e27be23d5b592bf67bb2caf618672", async() => {
                WriteLiteral("\r\n                                    \r\n                                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 7170, "\"", 7189, 1);
#nullable restore
#line 186 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
WriteAttributeValue("", 7178, orderState, 7178, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"orderState\"");
                BeginWriteAttribute("id", " id=\"", 7208, "\"", 7230, 2);
                WriteAttributeValue("", 7213, "State-", 7213, 6, true);
#nullable restore
#line 186 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
WriteAttributeValue("", 7219, orderState, 7219, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 7290, "\"", 7312, 1);
#nullable restore
#line 187 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
WriteAttributeValue("", 7298, order.OrderId, 7298, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"orderId\"");
                BeginWriteAttribute("id", " id=\"", 7328, "\"", 7355, 2);
                WriteAttributeValue("", 7333, "orderId-", 7333, 8, true);
#nullable restore
#line 187 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
WriteAttributeValue("", 7341, order.OrderId, 7341, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <button class=\"btn btn-warning m-4\" type=\"submit\"");
                BeginWriteAttribute("id", "  id=\"", 7448, "\"", 7482, 2);
                WriteAttributeValue("", 7454, "orderStateButton-", 7454, 17, true);
#nullable restore
#line 188 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
WriteAttributeValue("", 7471, orderState, 7471, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 188 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                                                                                                                        Write(orderState);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                \r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n");
#nullable restore
#line 191 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                                    
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            
                        </div>
                </div>
            <div class=""card-body"">
                <table class=""card-table table"">
                    <thead>
                        <th scope=""col""></th>
                        <th scope=""col"">Ürün Adı</th>
                        <th scope=""col"">Ürün Fiyatı</th>
                        <th scope=""col"">Alınan Miktar</th>
                    </thead>
                    <tbody>
");
#nullable restore
#line 205 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                     foreach (var orderItem in order.OrderItems)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <tr>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3fd71de02ca51fa5e27be23d5b592bf67bb2caf624594", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8291, "~/img/Products/", 8291, 15, true);
#nullable restore
#line 208 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
AddHtmlAttributeValue("", 8306, orderItem.ImageUrl, 8306, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 209 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
AddHtmlAttributeValue("", 8376, orderItem.ProductName, 8376, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 210 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                       Write(orderItem.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 211 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                       Write(orderItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 212 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                       Write(orderItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        \r\n                    </tr>\r\n");
#nullable restore
#line 215 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
                <tfoot>
                        <th scope=""col"">Ad Soyad</th>
                        <th scope=""col"">Telefon</th>
                        <th scope=""col"">Adres</th>
                        <th scope=""col"">Sipariş durumu</th>
                        <tr>
                             <td>");
#nullable restore
#line 223 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                            Write(order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 223 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                                             Write(order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td>");
#nullable restore
#line 224 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                            Write(order.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td>");
#nullable restore
#line 225 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                            Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td>");
#nullable restore
#line 226 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
                            Write(order.OrderStateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        \r\n                </tfoot>\r\n                </table>\r\n                \r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 234 "C:\Users\pc\Desktop\Website\FoodApp\FoodApp\foodapp.webui\Views\Admin\GetAllOrders.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n       \r\n        \r\n    \r\n</div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"//cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js\"></script>\r\n    <script src=\"https://cdn.datatables.net/1.10.22/js/dataTables.bootstrap4.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fd71de02ca51fa5e27be23d5b592bf67bb2caf630350", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/plug-ins/1.10.22/sorting/turkish-string.js""></script>
    
    <script>
        $(document).ready( function () {
            $('#myTable').DataTable({
                ""language"":{
                    ""url"":""//cdn.datatables.net/plug-ins/1.10.22/i18n/Turkish.json""
                }
            });
            $('.btn-link').on('click',function(){$('.collapse.show').collapse('hide');})
            } );
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
