#pragma checksum "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90da523f8dd3134745cd1db93963d87dc39e3239"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Create), @"mvc.1.0.view", @"/Views/Employees/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90da523f8dd3134745cd1db93963d87dc39e3239", @"/Views/Employees/Create.cshtml")]
    public class Views_Employees_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartHRMApi.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Employee</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""EmployeeName"" class=""control-label""></label>
                <input asp-for=""EmployeeName"" class=""form-control"" />
                <span asp-validation-for=""EmployeeName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Status"" class=""control-label""></label>
                <input asp-for=""Status"" class=""form-control"" />
                <span asp-validation-for=""Status"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Dob"" class=""control-label""></label>
                <input asp-for=""Dob"" class=""form-control"" />
                <span asp-validation-for=""Dob"" class=""text-danger""></span>
  ");
            WriteLiteral(@"          </div>
            <div class=""form-group"">
                <label asp-for=""Doj"" class=""control-label""></label>
                <input asp-for=""Doj"" class=""form-control"" />
                <span asp-validation-for=""Doj"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Gender"" class=""control-label""></label>
                <input asp-for=""Gender"" class=""form-control"" />
                <span asp-validation-for=""Gender"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DepartmentId"" class=""control-label""></label>
                <select asp-for=""DepartmentId"" class =""form-control"" asp-items=""ViewBag.DepartmentId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Designation"" class=""control-label""></label>
                <input asp-for=""Designation"" class=""form-control"" />
                <span asp-validat");
            WriteLiteral(@"ion-for=""Designation"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Address1"" class=""control-label""></label>
                <input asp-for=""Address1"" class=""form-control"" />
                <span asp-validation-for=""Address1"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Address2"" class=""control-label""></label>
                <input asp-for=""Address2"" class=""form-control"" />
                <span asp-validation-for=""Address2"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ZipCode"" class=""control-label""></label>
                <input asp-for=""ZipCode"" class=""form-control"" />
                <span asp-validation-for=""ZipCode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""City"" class=""control-label""></label>
        ");
            WriteLiteral(@"        <input asp-for=""City"" class=""form-control"" />
                <span asp-validation-for=""City"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""State"" class=""control-label""></label>
                <input asp-for=""State"" class=""form-control"" />
                <span asp-validation-for=""State"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-for=""Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 91 "D:\Gokuldass\MyWorkArea\WebApi\SmartHRMApi\SmartHRMApi\Views\Employees\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartHRMApi.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
