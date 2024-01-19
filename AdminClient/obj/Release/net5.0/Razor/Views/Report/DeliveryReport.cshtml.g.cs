#pragma checksum "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Report\DeliveryReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "599c277af4dc4764416e59b4b509a1a0950ac0de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_DeliveryReport), @"mvc.1.0.view", @"/Views/Report/DeliveryReport.cshtml")]
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
#line 1 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Report\DeliveryReport.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Report\DeliveryReport.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"599c277af4dc4764416e59b4b509a1a0950ac0de", @"/Views/Report/DeliveryReport.cshtml")]
    #nullable restore
    public class Views_Report_DeliveryReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Report\DeliveryReport.cshtml"
  
    ViewBag.Title = "Report";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    thead.clr {
    background-color: #d7e1dc;
}
</style>
<!-- PAGE-HEADER -->
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i>Report</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Delivery Report</li>
    </ol>
    <div class=""ml-auto"">
        
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-body"">
                <form action=""#"" role=""form"" class=""validate"" id=""formPost"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label class=""form-label"">Hospital</label>
                                <select class=""form-control""  id=""hospitalid""></select>
                            </div>
                        </div>
                        <div class=""col-md-4"">
        ");
            WriteLiteral(@"                    <div class=""form-group"">
                                <label class=""form-label"">Date</label>
                                <input type=""date"" class=""form-control"" id=""date"">
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <button type=""button"" id=""btnShow"" class=""btn btn-radius btn-success"" style=""margin-top: 36px;"">Show</button>
                            </div>
                        </div>
                    </div>
                </form>
            </div>
        </div>

    </div><!-- COL-END -->
</div>
<div class=""row"">
	<div class=""col-md-12"">
		<div class=""card"">
			<div class=""card-body"">
				<div class=""clearfix"">
					<div class=""float-left"">
						<h3 class=""card-title mb-0""> Report</h3>
					</div>
					<div class=""float-right"">
						<h3 class=""card-title"">Date: 22-05-2019</h3>
               ");
            WriteLiteral(@"         <p id=""date""></p>
					</div>
				</div>
				<hr>
				<div class=""row"">
					<div class=""col-lg-6 "">
						<img src=""/images/brand/yatri-LOGO.png"" alt=""Yatri"" style=""max-width: 180px;"">
					</div>
					<div class=""col-lg-6 text-right"">
						<p class=""h5"">Hoospital Address</p>
						<address>
							Street Address<br>
							State, City<br>
							Region, Postal Code<br>
							abc@example.com
						</address>
					</div>
				</div>
				<div class=""table-responsive push"">
					<table class=""table table-bordered table-hover mb-0"">
						<thead>
                            <tr>
");
            WriteLiteral(@"                                <td>Bed No</td>
                                <td>Patient Name</td>
                                <td>Hospital Name</td>
                                <td>Service Type</td>
                                <td>Instruction</td>
                                <td>FP Name</td>
                                <td>Out From Kitchen</td>
                                <td>TAT-Delivery</td>
                                <td>Delivery To Patient</td>
                                <td>TAT-Clearance</td>
                                <td>Clearance</td>
                                <td>Stastus</td>
                                <td>Feedback</td>
                            </tr>
                        </thead>
                        <tbody id=""dietreport"">
                        </tbody>
					</table> 
				</div>
                <div class=""card-footer text-right"">
                    <button type=""button"" class=""btn btn-primary mb-1"" ><i class=""si s");
            WriteLiteral(@"i-wallet""></i>Export Excel</button>
	                <button type=""button"" class=""btn btn-success mb-1"" id=""download-pdf-button""><i class=""si si-paper-plane""></i> Export PDF</button>
		            <button type=""button"" class=""btn btn-info mb-1"" onclick=""javascript:window.print();""><i class=""si si-printer""></i> Print </button>
		        </div>
			</div>
		</div>
        
	</div><!-- COL-END -->
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        GetHospitalList()\r\n        function GetHospitalList(Id) {\r\n            var opt = \'\';\r\n            $.ajax({\r\n                type: \"GET\",\r\n                url: \"");
#nullable restore
#line 125 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Report\DeliveryReport.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Hospital/GetHospitalList\",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                    \"authorization\": \"Bearer ");
#nullable restore
#line 128 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Report\DeliveryReport.cshtml"
                                        Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                success: function (res) {
                    console.log(res)
                    var options = [];
                    options.push('<option value="""">Select Hospital</option>');
                    for (var i = 0; i < res.data.length; i++) {
                        if (Id == res.data[i].hospitalMasterid) {
                            opt = 'selected'
                        } else {
                            opt = '';
                        }
                        options.push('<option value=""' + res.data[i].hospitalMasterid + '"" ' + opt + '>' + res.data[i].hospitalName + '</option>');
                    }
                    $(""#hospitalid"").html(options.join(''));
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                 ");
                WriteLiteral("       window.location.replace(\'/Message/Unauthorize\');\r\n                    }\r\n                }\r\n            });\r\n        }\r\n\r\n        $(\"#btnShow\").click(function (e) {\r\n\r\n            $.ajax({\r\n                type: \"GET\",\r\n                url: \"");
#nullable restore
#line 159 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Report\DeliveryReport.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/api/DIETMaster/GetDietReport/"" + $('#hospitalid').val() /*+ ""/"" + $('#date').val()*/,
                contentType: ""application/json; charset=utf-8"",

                dataType: ""json"",
                success: function (res) {
                    var z = ''
                    for (var i = 0; i < res.data.length; i++) {
                        z = z + ""<tr><td>"" + res.data[i].bedNo + ""</td><td>"" + res.data[i].patientName + ""</td><td>"" + res.data[i].hospitalName + ""</td><td>"" + res.data[i].foodServiceTypeName + ""</td><td>"" + res.data[i].specialInstruction + ""</td><td>"" + res.data[i].foodProviderName + ""</td><td>"" + res.data[i].plateReciveDate + ""</td><td>"" + res.data[i].tat1 + ""</td><td>"" + res.data[i].plateDeliverDate + ""</td><td>"" + res.data[i].tat2 + ""</td><td>"" + res.data[i].plateCollectionDate + ""</td><td>"" + res.data[i].status + ""</td><td>"" + res.data[i].feedback + ""</td></tr>""
                    }
                    $('#dietreport').html(z);
                },
                error: functi");
                WriteLiteral(@"on (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
                }
            });
        });
    </script>
    <script>
        n =  new Date();
        y = n.getFullYear();
        m = n.getMonth() + 1;
        d = n.getDate();
        document.getElementById(""date"").innerHTML = m + ""/"" + d + ""/"" + y;
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
