#pragma checksum "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\Hospital\HospitalList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "30b4777372c5cec48f2ab2f4753b4e099f8ef2e80e8f31cf88a5387d94e44947"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hospital_HospitalList), @"mvc.1.0.view", @"/Views/Hospital/HospitalList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\Hospital\HospitalList.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\Hospital\HospitalList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"30b4777372c5cec48f2ab2f4753b4e099f8ef2e80e8f31cf88a5387d94e44947", @"/Views/Hospital/HospitalList.cshtml")]
    #nullable restore
    public class Views_Hospital_HospitalList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Hospital/HospitalCreate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-icon btn-sm text-white mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\Hospital\HospitalList.cshtml"
  
    ViewBag.Title = "Hospital";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- PAGE-HEADER -->
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i>Admin Console</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Hospital List</li>
    </ol>
    <div class=""ml-auto"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30b4777372c5cec48f2ab2f4753b4e099f8ef2e80e8f31cf88a5387d94e449474588", async() => {
                WriteLiteral("\r\n            <span>\r\n                <i class=\"fe fe-plus\"></i>\r\n            </span> Hospital Create\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
<div class=""row"">
    <div class=""col-md-12 col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title"">Hospital List</div>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table id=""hospital"" class=""table table-striped table-bordered nowrap dataTable no-footer dtr-inline"" style=""width:100%"">
                        <thead>
                            <tr>
                                <th>Hospital Name</th>
                                <th>Address 1</th>
                                <th>Address 2</th>
                                <th>Contact Person</th>
                                <th>Contact Person No</th>
                                <th>No Of Floor(s)</th>
                                <th>Hospital Logo</th>
                                <th>Action</th>
                            </tr>
                        <");
            WriteLiteral("/thead>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        //List
        loadHospital()
        function loadHospital() {
             var table = $('#hospital').DataTable();
             table.destroy();
             table = $('#hospital').dataTable({
                ""paginationType"": ""full_numbers"",
                ""dom"": 'Bfrtip',
                ""buttons"": ['copy', 'csv', 'excel', 'pdf', 'print'],
                ""searching"": true,
                ""paging"": true,
                ""sort"": true,
                ""info"": true,
                ""ajax"": {
                    ""url"": '");
#nullable restore
#line 70 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\Hospital\HospitalList.cshtml"
                       Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Hospital/GetHospitalList\',\r\n                    \"type\": \"GET\",\r\n                    \"dataType\": \"json\",\r\n                    \"headers\": {\r\n                        \"authorization\": \"Bearer ");
#nullable restore
#line 74 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\Hospital\HospitalList.cshtml"
                                            Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                    },
                    ""error"": function (data) {
                        if (data.status == 401) {
                            window.location.replace('/Message/TokenExpire');
                        } else if (data.status == 403) {
                            window.location.replace('/Message/Unauthorize');
                        }
                    }
                },
                ""order"": [],
                ""columns"": [
                    { ""data"": ""hospitalName"", ""orderable"": true },
                    { ""data"": ""address1"", ""orderable"": true },
                    { ""data"": ""address2"", ""orderable"": true },
                    { ""data"": ""contactPerson"", ""orderable"": true },
                    { ""data"": ""contactPersonNo"", ""orderable"": true },
                    { ""data"": ""floorNo"", ""orderable"": true },
                    {
                        ""render"": function (data, type, row) {
                            if (row.hospitalLogo === '')
          ");
                WriteLiteral(@"                      return '';
                            else
                                return '<img style=""MAX-WIDTH: 70PX; margin-left: 28px;"" src=""' + row.hospitalLogo + '""/>'
                        }
                    },
                    {
                        ""render"": function (data, type, row) {
                            return '<a class=""btn btn-sm btn-primary"" href=""../hospital/HospitalEdit?hospitalMasterid=' + row.hospitalMasterid + '""><i class=""fa fa-edit""></i></a>' + '&nbsp&nbsp<button class=""btn btn-sm btn-danger"" data-target=""#delete"" data-id=' + row.hospitalMasterid + ' data-title=""Delete""><i class=""fa fa-trash""></i></button>';

                        }
                    }
                ]
            });
        }

        //Delete
        $('#hospital tbody').on('click', 'button[data-target=""#delete""]', function () {
            var id = $(this).data('id');
            swal({
                html: true,
                title: ""Are you sure?"",
    ");
                WriteLiteral(@"            text: ""You will not be able to recover this data!"",
                type: ""warning"",
                showCancelButton: true,
                confirmButtonColor: ""#DD6B55"",
                confirmButtonText: ""Yes, confirm it!"",
                closeOnConfirm: false
            }, function () {
                $.ajax({
                    type: ""GET"",
                    url: """);
#nullable restore
#line 125 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\Hospital\HospitalList.cshtml"
                     Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Hospital/DeleteHospital/\" +id+\"/\"+");
#nullable restore
#line 125 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\Hospital\HospitalList.cshtml"
                                                                   Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    contentType: \"application/json; charset=utf-8\",\r\n                    headers: {\r\n                       \"authorization\": \"Bearer ");
#nullable restore
#line 128 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\Hospital\HospitalList.cshtml"
                                           Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                    },
                    dataType: ""json"",
                    success: function (data, statusText, xhr) {
                        if (xhr.status == 200) {
                            $('#hospital').DataTable().ajax.reload(null, false);
                            sweetAlert({
                                html: true,
                                title: ""Hospital"",
                                text: ""Successfully deleted!"",
                                type: ""success""
                            });
                        } else if (xhr.status == 202) {
                            sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                        } else {
                            sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                        }
                    },
                    error: function (data) {
                        if (data.status == 401) {
                            window.location.repl");
                WriteLiteral(@"ace('/Message/TokenExpire');
                        } else if (data.status == 403) {
                            window.location.replace('/Message/Unauthorize');
                        }
                    }
                });
            });
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
