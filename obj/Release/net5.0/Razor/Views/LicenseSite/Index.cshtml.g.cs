#pragma checksum "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14e9697f391e877e2c282f94b15d3ca944b71231"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LicenseSite_Index), @"mvc.1.0.view", @"/Views/LicenseSite/Index.cshtml")]
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
#line 1 "C:\Users\azhar.yusof\Documents\BLMS\Views\_ViewImports.cshtml"
using BLMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\azhar.yusof\Documents\BLMS\Views\_ViewImports.cshtml"
using BLMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14e9697f391e877e2c282f94b15d3ca944b71231", @"/Views/LicenseSite/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1935fafd0aa5610a1ac330bdda92ea4db0ded552", @"/Views/_ViewImports.cshtml")]
    public class Views_LicenseSite_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BLMS.Models.License.LicenseSite>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-rounded btn-sm px-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Download File"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LicenseSite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadLicenseFileOnSystem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-block text-white text-sm font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
  
    ViewData["Title"] = "License Site";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section align-baseline"">
    <!-- Grid row -->
    <div class=""row"">

        <!-- Grid column -->
        <div class=""col-md-12"">
            <div class=""card card-cascade cascading-admin-card user-card"">
                <!-- Card Data -->
                <div class=""admin-up d-flex justify-content-start"">
                    <i class=""fas fa fa-industry info-color py-4 mr-3 z-depth-2""></i>
                    <div class=""data"">
                        <h5 class=""font-weight-bold dark-grey-text"">
                            License Site
                        </h5>
                    </div>
                </div>
                <!-- Card Data -->
                <!-- Card content -->
                <div class=""card-body card-body-cascade"">
                    <!-- Grid row -->
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div id=""alert"" class=""form-group"">
                                ");
#nullable restore
#line 30 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                           Write(Html.Raw(@ViewBag.Alert));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>

                            <div class=""table-responsive"">
                                <!--Table-->
                                <table id=""LicenseSite"" class=""table table-hover"">
                                    <!-- Table head -->
                                    <thead class=""heavy-rain-gradient text-black"">
                                        <tr>
                                            <th class=""text-sm font-weight-bold"">
                                                ");
#nullable restore
#line 40 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.UnitName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th class=\"text-sm font-weight-bold col-4\">\r\n                                                ");
#nullable restore
#line 43 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.LicenseName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </th>
                                            <th class=""text-sm font-weight-bold text-center"">File</th>
                                            <th class=""text-sm font-weight-bold"">
                                                ");
#nullable restore
#line 47 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </th>
                                            <th class=""text-sm font-weight-bold"">Person in Charge</th>
                                            <th class=""text-sm font-weight-bold"">Issued & Expired Date</th>
                                            <th class=""text-sm font-weight-bold"">Action</th>
                                        </tr>
                                    </thead>
                                    <!-- Table head -->
                                    <!-- Table body -->
                                    <tbody>
");
#nullable restore
#line 57 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td class=\"text-sm\">\r\n                                                    ");
#nullable restore
#line 61 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.UnitName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td class=\"text-sm\">\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3434, "\"", 3503, 1);
#nullable restore
#line 64 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
WriteAttributeValue("", 3441, Url.Action("Details", "LicenseSite", new {id=item.LicenseID}), 3441, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"font-weight-bold\">\r\n                                                        ");
#nullable restore
#line 65 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.LicenseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </a>\r\n\r\n                                                    <div class=\"btn-toolbar\">\r\n");
#nullable restore
#line 69 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                         if (item.isRegistered == true)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <button name=""button"" class=""btn btn-outline-success btn-sm px-2 text-sm"" disabled>
                                                                <i class=""fas fa-check mt-0""></i> Registered
                                                            </button>
");
#nullable restore
#line 74 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                         if ((item.RenewReminderDT.Date - DateTime.Now.Date).Days > 0 | item.RenewReminderDT.ToString() == "9999-12-31 00:00:00.000")
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <button name=""button"" class=""btn btn-outline-success btn-sm px-2 text-sm"" disabled>
                                                                <i class=""fas fa-thumbs-up mt-0 text-sm""></i> Active
                                                            </button>
");
#nullable restore
#line 81 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <button name=""button"" class=""btn btn-outline-danger btn-sm px-2 text-sm"" disabled>
                                                                <i class=""fas fa-thumbs-down mt-0 text-sm""></i> Not Active
                                                            </button>
");
#nullable restore
#line 87 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </div>\r\n                                                </td>\r\n                                                <td class=\"text-center\">\r\n");
#nullable restore
#line 91 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                     if (item.hasFile == true)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e9697f391e877e2c282f94b15d3ca944b7123115460", async() => {
                WriteLiteral("\r\n                                                            <i class=\"fas fa-file-alt mt-0\"></i> Download\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                                                                                                                                                                                               WriteLiteral(item.LicenseID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 99 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                                <td class=\"text-sm\">\r\n                                                    ");
#nullable restore
#line 102 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </td>
                                                <td class=""text-sm text-nowrap"">
                                                    <label class=""font-weight-bold"">PIC 1:</label>
                                                    <br />
                                                    ");
#nullable restore
#line 107 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.PIC1Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    <br /><br />\r\n\r\n");
#nullable restore
#line 110 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                     if (string.IsNullOrEmpty(item.PIC2Name))
                                                    {

                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <label class=\"font-weight-bold\">PIC 2:</label>\r\n                                                        <br />\r\n");
#nullable restore
#line 118 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.PIC2Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <br /><br />\r\n");
#nullable restore
#line 120 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 122 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                     if (string.IsNullOrEmpty(item.PIC3Name))
                                                    {

                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <label class=\"font-weight-bold\">PIC 3:</label>\r\n                                                        <br />\r\n");
#nullable restore
#line 130 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.PIC3Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                                                                    
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                                <td class=\"text-sm\">\r\n");
#nullable restore
#line 134 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                     if (string.IsNullOrEmpty(item.IssuedDT))
                                                    {

                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <label class=\"font-weight-bold\">Issued Date:</label>\r\n");
#nullable restore
#line 141 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.IssuedDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <br /><br />\r\n");
#nullable restore
#line 143 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 145 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                     if (string.IsNullOrEmpty(item.ExpiredDT))
                                                    {

                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <label class=\"font-weight-bold\">Expired Date:</label>\r\n");
#nullable restore
#line 152 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.ExpiredDT));

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                                                                     
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                                <td class=\"text-center\">\r\n");
#nullable restore
#line 156 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                     if ((item.RenewReminderDT.Date - DateTime.Now.Date).Days < 0 && item.RenewReminderDT.ToString() != "9999-12-31 00:00:00.000")
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a class=\"btn btn-info btn-rounded btn-sm px-2\" title=\"Renewal\"");
            BeginWriteAttribute("href", " href=\"", 10595, "\"", 10664, 1);
#nullable restore
#line 158 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
WriteAttributeValue("", 10602, Url.Action("Renewal", "LicenseSite", new {id=item.LicenseID}), 10602, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <i class=\"fas fa-pencil-alt mt-0\"></i> Renewal\r\n                                                        </a>\r\n");
#nullable restore
#line 161 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 164 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                    <!-- Table body -->
                                </table>
                                <!-- Table -->
                            </div>

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e9697f391e877e2c282f94b15d3ca944b7123126989", async() => {
                WriteLiteral("<i class=\"far fa fa-plus ml-1 text-black\"></i> Register New License");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <!-- Grid row -->\r\n                </div>\r\n                <!-- Card content -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14e9697f391e877e2c282f94b15d3ca944b7123128629", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#LicenseSite').DataTable();
            $('.dataTables_length').addClass('bs-select');
        });

        //auto hide viewbag.alert
        $(document).ready(function () {
            setTimeout(function () {
                $(""#alert"").fadeOut();
            }, 3000);
        });
    </script>

");
#nullable restore
#line 202 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseSite\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BLMS.Models.License.LicenseSite>> Html { get; private set; }
    }
}
#pragma warning restore 1591
