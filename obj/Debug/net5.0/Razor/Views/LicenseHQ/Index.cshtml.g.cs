#pragma checksum "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "add7755452adeb56c8ee78cbe2a792b28e0512c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LicenseHQ_Index), @"mvc.1.0.view", @"/Views/LicenseHQ/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add7755452adeb56c8ee78cbe2a792b28e0512c3", @"/Views/LicenseHQ/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1935fafd0aa5610a1ac330bdda92ea4db0ded552", @"/Views/_ViewImports.cshtml")]
    public class Views_LicenseHQ_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BLMS.Models.License.LicenseHQ>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RequestLicense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-block text-white text-sm font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
  
    ViewData["Title"] = "License HQ";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section align-baseline"" style=""font-size: 12px;"">
    <!-- Grid row -->
    <div class=""row"">

        <!-- Grid column -->
        <div class=""col-md-12"">
            <div class=""card card-cascade cascading-admin-card user-card"">
                <!-- Card Data -->
                <div class=""admin-up d-flex justify-content-start"">
                    <i class=""fas fa fa-building info-color py-4 mr-3 z-depth-2""></i>
                    <div class=""data"">
                        <h5 class=""font-weight-bold dark-grey-text"">
                            License HQ
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
            WriteLiteral("               ");
#nullable restore
#line 30 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                           Write(Html.Raw(@ViewBag.Alert));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>

                            <div class=""table table-wrapper table-responsive"" style=""width:100%"">
                                <!--Table-->
                                <table id=""LicenseHQ"" class=""table table-hover mb-0"">
                                    <!-- Table head -->
                                    <thead>
                                        <tr>
                                            <th class=""text-sm font-weight-bold align-text-top"" style=""font-size: 12px;"">
                                                ");
#nullable restore
#line 40 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.indexNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th class=\"text-sm font-weight-bold align-text-top\" style=\"font-size: 12px;\">\r\n                                                ");
#nullable restore
#line 43 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.UnitName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th class=\"text-sm font-weight-bold align-text-top\" style=\"font-size: 12px;\">\r\n                                                ");
#nullable restore
#line 46 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.LicenseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th class=\"text-sm font-weight-bold align-text-top\" style=\"font-size: 12px;\">\r\n                                                ");
#nullable restore
#line 49 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </th>
                                            <th class=""text-sm font-weight-bold align-text-top"" style=""font-size: 12px;"">Person in Charge</th>
                                            <th class=""text-sm font-weight-bold align-text-top"" style=""font-size: 12px;"">Issued & Expired Date</th>
                                            <th class=""text-sm font-weight-bold align-text-top"" style=""font-size: 12px;"">File</th>
                                            <th class=""text-sm font-weight-bold align-text-top"" style=""font-size: 12px;"">Renewal</th>
                                        </tr>
                                    </thead>
                                    <!-- Table head -->
                                    <!-- Table body -->
                                    <tbody>
");
#nullable restore
#line 60 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n");
            WriteLiteral("                                                <td class=\"text-sm text-center\" style=\"font-size: 12px;\">\r\n                                                    ");
#nullable restore
#line 65 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.indexNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n");
            WriteLiteral("                                                <td class=\"text-sm col-2\" style=\"font-size: 12px;\">\r\n                                                    ");
#nullable restore
#line 69 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.UnitName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n");
            WriteLiteral("                                                <td class=\"text-sm col-4\" style=\"font-size: 12px;\">\r\n");
#nullable restore
#line 73 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                     if (item.isRequested == true | item.isApproved == true | item.isRejected)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a");
            BeginWriteAttribute("href", " href=\"", 4686, "\"", 4759, 1);
#nullable restore
#line 75 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
WriteAttributeValue("", 4693, Url.Action("DetailRequest", "LicenseHQ", new {id=item.LicenseID}), 4693, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"font-weight-bold\">\r\n                                                            ");
#nullable restore
#line 76 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.LicenseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                            <br />\r\n\r\n");
#nullable restore
#line 80 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                             if (item.isRequested == true)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"badge bg-primary text-sm\">Requested</span>\r\n");
#nullable restore
#line 83 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                            }
                                                            else if (item.isApproved == true)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"badge bg-info text-sm\">Approved</span>\r\n");
#nullable restore
#line 87 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                            }
                                                            else if (item.isRejected == true)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"badge bg-danger text-sm\">Rejected</span>\r\n");
#nullable restore
#line 91 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </a>\r\n");
#nullable restore
#line 93 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                    }
                                                    else if (item.isRegistered == true)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a");
            BeginWriteAttribute("href", " href=\"", 6305, "\"", 6379, 1);
#nullable restore
#line 96 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
WriteAttributeValue("", 6312, Url.Action("DetailRegister", "LicenseHQ", new {id=item.LicenseID}), 6312, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"font-weight-bold\">\r\n                                                            ");
#nullable restore
#line 97 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.LicenseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                            <br />\r\n\r\n                                                            <span class=\"badge bg-success text-sm\">Registered</span>\r\n                                                        </a>\r\n");
#nullable restore
#line 103 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                    }
                                                    else if (item.isRenewed == true)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a");
            BeginWriteAttribute("href", " href=\"", 7023, "\"", 7096, 1);
#nullable restore
#line 106 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
WriteAttributeValue("", 7030, Url.Action("DetailRenewal", "LicenseHQ", new {id=item.LicenseID}), 7030, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"font-weight-bold\">\r\n                                                            ");
#nullable restore
#line 107 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.LicenseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                            <br />\r\n\r\n                                                            <span class=\"badge bg-secondary text-sm\">Renewed</span>\r\n                                                        </a>\r\n");
#nullable restore
#line 113 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                    }

                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                     if ((item.RenewReminderDT.Date - DateTime.Now.Date).Days > 0 | item.RenewReminderDT.ToString() == "9999-12-31 00:00:00.000")
                                                    {

                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"badge bg-danger text-sm\">Expired</span>\r\n");
#nullable restore
#line 123 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n");
            WriteLiteral("                                                <td class=\"text-sm\" style=\"font-size: 12px;\">\r\n                                                    ");
#nullable restore
#line 127 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n");
            WriteLiteral("                                                <td class=\"text-sm col-3\" style=\"font-size: 12px;\">\r\n");
#nullable restore
#line 131 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                     if (string.IsNullOrEmpty(item.PIC1Name))
                                                    {

                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <label class=\"font-weight-bold\">PIC 1:</label>\r\n                                                        <br />\r\n");
#nullable restore
#line 139 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.PIC1Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <br /><br />\r\n");
#nullable restore
#line 141 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 143 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
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
#line 151 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.PIC2Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <br /><br />\r\n");
#nullable restore
#line 153 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 155 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
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
#line 163 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.PIC3Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                                                                    
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n");
            WriteLiteral("                                                <td class=\"text-sm text-center col-2\" style=\"font-size: 12px;\">\r\n");
#nullable restore
#line 168 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
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
#line 175 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.IssuedDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <br /><br />\r\n");
#nullable restore
#line 177 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 179 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
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
#line 186 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.ExpiredDT));

#line default
#line hidden
#nullable disable
#nullable restore
#line 186 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                                                                     
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n");
            WriteLiteral("                                                <td class=\"text-center col-1\" style=\"font-size: 12px;\">\r\n");
#nullable restore
#line 191 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                     if (item.hasFile == true)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a class=\"btn btn-outline-primary btn-rounded btn-sm px-2\" title=\"Download License File\"");
            BeginWriteAttribute("href", " href=\"", 12802, "\"", 12881, 1);
#nullable restore
#line 193 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
WriteAttributeValue("", 12809, Url.Action("DownloadLicenseFile", "LicenseHQ", new {id=item.LicenseID}), 12809, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <i class=\"fas fa-download mt-0\"></i>\r\n                                                        </a>\r\n");
#nullable restore
#line 196 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n");
            WriteLiteral("                                                <td class=\"text-center col-1\" style=\"font-size: 12px;\">\r\n");
#nullable restore
#line 201 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                     if ((item.RenewReminderDT.Date - DateTime.Now.Date).Days > 0 | item.RenewReminderDT.ToString() == "9999-12-31 00:00:00.000")
                                                    {

                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a class=\"btn btn-outline-warning btn-rounded btn-sm px-2\" title=\"Request Renewal\"");
            BeginWriteAttribute("href", " href=\"", 13950, "\"", 14024, 1);
#nullable restore
#line 207 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
WriteAttributeValue("", 13957, Url.Action("RequestRenewal", "LicenseHQ", new {id=item.LicenseID}), 13957, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 12px;\">\r\n                                                            <i class=\"fas fa-fist-raised mt-0\"></i>\r\n                                                        </a>\r\n");
#nullable restore
#line 210 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 213 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "add7755452adeb56c8ee78cbe2a792b28e0512c328349", async() => {
                WriteLiteral("<i class=\"far fa fa-plus ml-1 text-black\" style=\"font-size: 12px;\"></i> Request New License");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <!-- Grid row -->\r\n                </div>\r\n                <!-- Card content -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#LicenseHQ').DataTable();
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
#line 246 "C:\Users\azhar.yusof\Documents\BLMS\Views\LicenseHQ\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BLMS.Models.License.LicenseHQ>> Html { get; private set; }
    }
}
#pragma warning restore 1591
