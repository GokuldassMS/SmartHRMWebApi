#pragma checksum "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0334034392b28b50e003eec30f4e90ae5c4c534"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Details), @"mvc.1.0.view", @"/Views/Employees/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0334034392b28b50e003eec30f4e90ae5c4c534", @"/Views/Employees/Details.cshtml")]
    public class Views_Employees_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartHRMApi.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Doj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Doj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Designation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Department.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2933, "\"", 2965, 1);
#nullable restore
#line 94 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Details.cshtml"
WriteAttributeValue("", 2948, Model.EmployeeId, 2948, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartHRMApi.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
