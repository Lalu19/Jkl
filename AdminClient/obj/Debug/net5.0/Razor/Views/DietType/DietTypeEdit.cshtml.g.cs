#pragma checksum "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\DietType\DietTypeEdit.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ca514a06c53ed9ded1af4e468468bfbd704a62828adea383cbaeb4cc596eae0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DietType_DietTypeEdit), @"mvc.1.0.view", @"/Views/DietType/DietTypeEdit.cshtml")]
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
#line 1 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\DietType\DietTypeEdit.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\DietType\DietTypeEdit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ca514a06c53ed9ded1af4e468468bfbd704a62828adea383cbaeb4cc596eae0c", @"/Views/DietType/DietTypeEdit.cshtml")]
    #nullable restore
    public class Views_DietType_DietTypeEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/DietType/DietTypeList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\DietType\DietTypeEdit.cshtml"
  
    ViewBag.Title = "DietType";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i> Admin Console</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Diet Type</li>
    </ol>
    <div class=""ml-auto"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca514a06c53ed9ded1af4e468468bfbd704a62828adea383cbaeb4cc596eae0c4561", async() => {
                WriteLiteral("\r\n            <span>\r\n                <i class=\"fe fe-plus\"></i>\r\n            </span> Diet Type List\r\n        ");
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
    <div class=""col-lg-12"">

        <form action=""#"" role=""form"" class=""card validate"" id=""formPost"" enctype=""multipart/form-data"">
            <div class=""card-header"">
                <h3 class=""card-title"">Diet Type Edit</h3>
            </div>
            <div class="" card-body"">
                <div class=""row  mb-1"">
                    <div class=""col-lg-6  mb-1"">
                        <label class=""form-label"">Diet Type &nbsp;<span style=""color: red;""><b>*</b></span></label>
                        <input type=""text"" class=""form-control"" id=""diettypename"" placeholder=""Diet Type"" required>
                    </div>
                </div>
                <br />
                <br />
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <button type=""button"" id=""btnUpdate"" class=""btn btn-radius btn-success"">Update</button>
                        <a type=""button"" href=""/DietType/DietTypeEdit");
            WriteLiteral("\" class=\"btn btn-radius btn-danger\">Reset</a>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n        var dietTypeId = ");
#nullable restore
#line 57 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\DietType\DietTypeEdit.cshtml"
                    Write(ViewBag.dietTypeId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        loadSingleDietType()\r\n        function loadSingleDietType() {\r\n            $.ajax({\r\n                type: \"GET\",\r\n                url: \"");
#nullable restore
#line 62 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\DietType\DietTypeEdit.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/DietType/GetSingleDietTypeId/\" + dietTypeId,\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                    \"authorization\": \"Bearer ");
#nullable restore
#line 65 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\DietType\DietTypeEdit.cshtml"
                                        Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                success: function (data) {
                    //console.log(data);
                    if (data) {
                        $('#diettypename').val(data.dietTypeName);
                        // loadParent();
                    }
                    else {
                        sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                    }
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
                }
            });
        }
        $(function () {

            $(""#btnUpdate"").click(function (e) {

                if (!document.getElementById(""formPost"").checkValidity()) {
                    e.preventDef");
                WriteLiteral("ault();\r\n                }\r\n                else {\r\n                    var model = {\r\n                        dietTypeId: dietTypeId,\r\n                        diettypename: $.trim($(\"#diettypename\").val()),\r\n                        createdBy: ");
#nullable restore
#line 98 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\DietType\DietTypeEdit.cshtml"
                              Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    }\r\n                    $.ajax({\r\n                        type: \"POST\",\r\n                        url: \"");
#nullable restore
#line 102 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\DietType\DietTypeEdit.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/DietType/UpdateDietType\",\r\n                        data: JSON.stringify(model),\r\n                        contentType: \"application/json; charset=utf-8\",\r\n                        headers: {\r\n                            \"authorization\": \"Bearer ");
#nullable restore
#line 106 "\\APPMAN\1. Public Folder\Tanmay\AdminConsole\AdminClient\Views\DietType\DietTypeEdit.cshtml"
                                                Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                        },
                        dataType: ""json"",
                        success: function (data, statusText, xhr) {
                            if (xhr.status === 200) {

                                sweetAlert({
                                    html: true,
                                    icon: ""success"",
                                    title: ""Diet Type"",
                                    text: ""Successfully Updated!"",
                                    type: ""success""
                                });
                            } else if (data.status === ""duplicate"") {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            } else if (data.status === ""error"") {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            } else {
                                sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warn");
                WriteLiteral(@"ing"");
                            }
                        },
                        error: function (data) {
                            if (data.status == 401) {
                                window.location.replace('/Message/TokenExpire');
                            } else if (data.status == 403) {
                                window.location.replace('/Message/Unauthorize');
                            } else if (data.status == 400) {
                                sweetAlert(""Validation Alert!"", ""Please check input data!"", ""warning"");
                            }
                        }
                    });
                }
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
