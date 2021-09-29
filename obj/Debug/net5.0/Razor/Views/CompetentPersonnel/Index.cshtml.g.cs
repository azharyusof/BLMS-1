#pragma checksum "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "564052872e3c9c82a5cbaec8d55756dc6bc7d79c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompetentPersonnel_Index), @"mvc.1.0.view", @"/Views/CompetentPersonnel/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"564052872e3c9c82a5cbaec8d55756dc6bc7d79c", @"/Views/CompetentPersonnel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1935fafd0aa5610a1ac330bdda92ea4db0ded552", @"/Views/_ViewImports.cshtml")]
    public class Views_CompetentPersonnel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BLMS.Models.SOP.CompetentPersonnel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark tempting-azure-gradient btn-block text-white text-sm font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 12px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/mdb/css/addons/datatables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/mdb/css/addons/datatables-select.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
  
    ViewData["Title"] = "Competent Personnel";
    Layout = "~/Views/Shared/_SOPLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid mt-5 mt-md-0 mb-0"">
    <!-- Grid row -->
    <div class=""row"" style=""margin-top: -100px;"">
        <!-- Grid column -->
        <div class=""col-md-12 px-lg-5"">
            <!-- Card -->
            <div class=""card pb-5 mx-md-3"">
                <div class=""card-body"">
                    <div class=""container text-center my-5"">
                        <h2 class=""title font-weight-bold my-3 wow fadeIn"" data-wow-delay=""0.2s"">
                            <strong>COMPETENT PERSONNEL</strong>
                        </h2>

                        <div class=""row wow fadeIn"" data-wow-delay=""0.2s"" style=""font-size: 12px;"">
                            <div class=""col-12"">
                                <div class=""card"">
                                    <div class=""card-body"">
                                        <div id=""alert"" class=""form-group text-left"" style=""font-size: 14px;"">
                                            ");
#nullable restore
#line 26 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                       Write(Html.Raw(@ViewBag.Alert));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>

                                        <table id=""Competent"" class=""table table-hover table-wrapper table-striped table-responsive-lg text-left"" cellspacing=""0"" width=""100%"">
                                            <thead>
                                                <tr>
                                                    <th class=""text-sm font-weight-bold col-1"" style=""font-size: 12px;"">No.</th>
                                                    <th class=""text-sm font-weight-bold"" style=""font-size: 12px;"">
                                                        ");
#nullable restore
#line 34 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.BusinessUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </th>\r\n                                                    <th class=\"text-sm font-weight-bold\" style=\"font-size: 12px;\">\r\n                                                        ");
#nullable restore
#line 37 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.PersonnelName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </th>\r\n                                                    <th class=\"text-sm font-weight-bold\" style=\"font-size: 12px;\">\r\n                                                        ");
#nullable restore
#line 40 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.CertFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </th>\r\n                                                    <th class=\"text-sm font-weight-bold\" style=\"font-size: 12px;\">\r\n                                                        ");
#nullable restore
#line 43 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.CertType));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </th>
                                                    <th class=""text-sm font-weight-bold"" style=""font-size: 12px;"">
                                                        Date
                                                    </th>
                                                    <th class=""text-sm font-weight-bold"" style=""font-size: 12px;"">
                                                        ");
#nullable restore
#line 49 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.YearAwarded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </th>\r\n                                                    <th class=\"text-sm font-weight-bold\" style=\"font-size: 12px;\">\r\n                                                        ");
#nullable restore
#line 52 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.CertFileName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </th>
                                                    <th class=""text-sm font-weight-bold text-center col-2"" style=""font-size: 12px;"">Action</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 58 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                   int i = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr");
            BeginWriteAttribute("id", " id=\"", 4120, "\"", 4146, 2);
            WriteAttributeValue("", 4125, "row_", 4125, 4, true);
#nullable restore
#line 61 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
WriteAttributeValue("", 4129, item.PersonnelId, 4129, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <td class=\"text-sm text-center\" style=\"font-size: 12px;\">\r\n                                                            ");
#nullable restore
#line 63 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td class=\"text-sm col-2\" style=\"font-size: 12px;\">\r\n                                                            ");
#nullable restore
#line 66 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.BusinessUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        </td>
                                                        <td class=""text-sm col-2"" style=""font-size: 12px;"">
                                                            <a title=""Click here to view details""");
            BeginWriteAttribute("href", " href=\"", 4880, "\"", 4958, 1);
#nullable restore
#line 69 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
WriteAttributeValue("", 4887, Url.Action("Details", "CompetentPersonnel", new {id=item.PersonnelId}), 4887, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                <span class=\"font-weight-bold\">");
#nullable restore
#line 70 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.PersonnelName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                            </a>
                                                        </td>
                                                        <td class=""text-sm col-2"" style=""font-size: 12px;"">
                                                            ");
#nullable restore
#line 74 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.CertFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td class=\"text-sm col-2\" style=\"font-size: 12px;\">\r\n                                                            ");
#nullable restore
#line 77 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.CertType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td class=\"text-sm col-2\" style=\"font-size: 12px;\">\r\n");
#nullable restore
#line 80 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                             if (item.AppointedDt.HasValue)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <label class=\"font-weight-bold\">Appointment Date:</label>\r\n                                                                <br />\r\n");
#nullable restore
#line 84 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.AppointedDt));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <br /><br />\r\n");
#nullable restore
#line 87 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 89 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                             if (item.ExpiredDt.HasValue)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <label class=\"font-weight-bold\">Expired Date:</label>\r\n                                                                <br />\r\n");
#nullable restore
#line 93 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.ExpiredDt));

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                                                                             
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 96 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                             if (item.AppointedDt == null && item.ExpiredDt == null)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <i class=\"text-sm font-italic\" style=\"font-size: 12px;\">No date</i>\r\n");
#nullable restore
#line 99 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </td>\r\n                                                        <td class=\"text-sm text-center\" style=\"font-size: 12px;\">\r\n");
#nullable restore
#line 102 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                             if (item.YearAwarded != null)
                                                            {
                                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.YearAwarded));

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                                                                               
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <i class=\"text-sm\" style=\"font-size: 12px;\">-</i>\r\n");
#nullable restore
#line 109 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </td>\r\n                                                        <td class=\"text-sm text-center col-1\" style=\"font-size: 12px;\">\r\n");
#nullable restore
#line 112 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                              
                                                                if (item.CertFileName == null)
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <i class=\"text-sm font-italic\" style=\"font-size: 12px;\">Not available</i>\r\n");
#nullable restore
#line 116 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                                }
                                                                else
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <a class=\"btn btn-outline-dark heavy-rain-gradient btn-rounded btn-sm px-2\" title=\"Open certificate link\"");
            BeginWriteAttribute("href", " href=\"", 9159, "\"", 9214, 1);
#nullable restore
#line 119 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
WriteAttributeValue("", 9166, Html.DisplayFor(modelItem => item.CertFileName), 9166, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                                                                        <i class=\"fas fa-external-link-square-alt mt-0\"></i>\r\n                                                                    </a>\r\n");
#nullable restore
#line 122 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                                }
                                                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </td>
                                                        <td class=""text-sm text-center"" style=""font-size: 12px;"">
                                                            <a class=""btn btn-outline-dark winter-neva-gradient btn-rounded btn-sm px-2"" title=""Renewal""");
            BeginWriteAttribute("href", " href=\"", 9894, "\"", 9972, 1);
#nullable restore
#line 126 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
WriteAttributeValue("", 9901, Url.Action("Renewal", "CompetentPersonnel", new {id=item.PersonnelId}), 9901, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                                <i class=""fas fa-sync-alt mt-0""></i>
                                                            </a>
                                                        </td>
                                                    </tr>
");
#nullable restore
#line 131 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
                                                    i++;
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </tbody>\r\n                                        </table>\r\n\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "564052872e3c9c82a5cbaec8d55756dc6bc7d79c24276", async() => {
                WriteLiteral("Create Competent Personnel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://use.fontawesome.com/releases/v5.11.2/css/all.css\">\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "564052872e3c9c82a5cbaec8d55756dc6bc7d79c26076", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "564052872e3c9c82a5cbaec8d55756dc6bc7d79c27255", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <style>\r\n        .select-wrapper input.select-dropdown {\r\n            font-size: 12px;\r\n        }\r\n\r\n        .dropdown-content li > span {\r\n            font-size: 12px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        new WOW().init();

        $(document).ready(function () {
            $('#Competent').DataTable();
            $('#Competent_wrapper').find('label').each(function () {
                $(this).parent().append($(this).children());
            });
            $('#Competent_wrapper .dataTables_filter').find('input').each(function () {
                $('input').attr(""placeholder"", ""Search"");
                $('input').attr(""style"", 'font-size: 12px');
                $('input').removeClass('form-control-sm');
            });
            $('#Competent_wrapper .dataTables_length').addClass('d-flex flex-row');
            $('#Competent_wrapper .dataTables_filter').addClass('md-form');
            $('#Competent_wrapper select').removeClass(
                'custom-select custom-select-sm form-control form-control-sm');
            $('#Competent_wrapper select').addClass('mdb-select');
            $('#Competent_wrapper .mdb-select').materialSelect();
            $('#Competent");
                WriteLiteral(@"_wrapper .dataTables_filter').find('label').remove();
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
#line 196 "C:\Users\azhar.yusof\Documents\BLMS\Views\CompetentPersonnel\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BLMS.Models.SOP.CompetentPersonnel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
