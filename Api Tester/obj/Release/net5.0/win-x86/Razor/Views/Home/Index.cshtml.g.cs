#pragma checksum "F:\Api Tester\Api Tester\Api Tester\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14c822cd5e8c1d29bc4fecc729766dd72b685f6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "F:\Api Tester\Api Tester\Api Tester\Views\_ViewImports.cshtml"
using Api_Tester;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Api Tester\Api Tester\Api Tester\Views\_ViewImports.cshtml"
using Api_Tester.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14c822cd5e8c1d29bc4fecc729766dd72b685f6a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0115734bb821417ad9273f1f50a1c639f911bb39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Api Tester\Api Tester\Api Tester\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class="" form-group col-12 "">
        <label for=""BaseUrl"">BaseUrl</label>
        <input type=""text"" id=""BaseUrl"" name=""BaseUrl"" class=""form-control"" />
    </div>
    <div class=""form-group col-12"">
        <label for=""JsonValue"">Json Value:</label>
        <textarea class=""form-control"" rows=""5"" id=""JsonValue"" name=""JsonValue""></textarea>
    </div>
    <div class=""form-group col-6 "">
        <label for=""Times"">Times</label>
        <input type=""text"" id=""Times"" name=""Times"" class=""form-control"" value=""1"" />
    </div>
    <div class=""form-group col-6 "">
        <label for=""ApiUser"">ApiUser</label>
        <input type=""text"" id=""ApiUser"" name=""ApiUser"" class=""form-control"" value=""PrabhuPay"" />
    </div>
    <div class=""form-group col-12 "">
        <label for=""ApiToken"">ApiToken</label>
        <input type=""text"" id=""ApiToken"" name=""ApiToken"" class=""form-control"" value=""eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IlByYWJodVBheSIsImV4cCI6MTYyNDYwMDU5MCwiaXNzIj");
            WriteLiteral(@"oiaHR0cDovL2xvY2FsaG9zdDo0NDM4Ny8iLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjQ0Mzg3LyJ9.DJgSc8By9R7qQE7uPVibTNR76AifV6MYwIhuvxOSEoc"" />
    </div>

    <div class=""col-12"">
        <button type=""button"" class=""btn btn-primary"" onclick=""CallApi()"">Call Api</button>
    </div>
    <div class=""col-12 card-body"">
        <pre id=""json""></pre>
        </div>
    </div>
    <script>
       // var x = [];
        function CallApi() {

            var BaseUrl = $(""#BaseUrl"").val();
            var JsonVal = $(""#JsonValue"").val();
            var times = $(""#Times"").val();
            var ApiToken = $(""#ApiToken"").val();
            var ApiUser = $(""#ApiUser"").val();

            for (i = 0; i < parseInt(times); i++) {
                //  console.log(JsonVal + i);
                $.ajax({
                    data: {
                        BaseUrl: BaseUrl,
                        JsonVal: JsonVal,
                        ApiToken: ApiToken,
                        ApiUser: ApiUser
                 ");
            WriteLiteral(@"   },
                    type: ""POST"",//HTTP POST Method
                    url: ""/Home/CallApi"",// Controller/View
                    success: function (response) {
                        //console.log(response);
                        var data = response;
                        //parser = new DOMParser();
                        //xmlDoc = parser.parseFromString(data.ResultCommon, ""text/xml"");
                        //x = xml2json(xmlDoc)
                        document.getElementById(""json"").innerHTML = JSON.stringify(data, undefined, 2);
                    }

                });
            }
        }
        //function xml2json(xml) {
        //    debugger;
        //    try {
        //        var obj = {};
        //        if (xml.children.length > 0) {
        //            for (var i = 0; i < xml.children.length; i++) {
        //                var item = xml.children.item(i);
        //                var nodeName = item.nodeName;

        //                if (t");
            WriteLiteral(@"ypeof (obj[nodeName]) == ""undefined"") {
        //                    obj[nodeName] = xml2json(item);
        //                } else {
        //                    if (typeof (obj[nodeName].push) == ""undefined"") {
        //                        var old = obj[nodeName];

        //                        obj[nodeName] = [];
        //                        obj[nodeName].push(old);
        //                    }
        //                    obj[nodeName].push(xml2json(item));
        //                }
        //            }
        //        } else {
        //            obj = xml.textContent;
        //        }
        //        return obj;
        //    } catch (e) {
        //        console.log(e.message);
        //    }
        //}
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
