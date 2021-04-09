#pragma checksum "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb666d6895bf181acf05a0f681024860c78e5afb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ElevatorsList), @"mvc.1.0.view", @"/Views/Home/ElevatorsList.cshtml")]
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
#line 1 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb666d6895bf181acf05a0f681024860c78e5afb", @"/Views/Home/ElevatorsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25f6d5fda41f36129904dab2a2a0a3fc6a06f30", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ElevatorsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml"
  
    ViewData["Title"] = "Elevators";
    var elv = ViewBag.elevators;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-6"">
            <h2>Elevators</h2>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-6"">
            <table id=""productTable"" class=""table table-bordered table-condensed table-striped"">
                <thead>
                    <tr>
                        <th>Elevator ID</th>
                        <th>Serial Number</th>
                        <th>Elevator Model</th>
                        <th>Elevator Type</th>
                        <th>Elevator Status</th>
                        <th>Date of Commissioning</th>
                        <th>Date of Last Inspection</th>
                        <th>Certificate of Iperation</th>
                        <th>Information</th>
                        <th>Notes</th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 34 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml"
                     foreach (var elevator in elv )
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 37 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml"
                           Write(elevator.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 38 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml"
                           Write(elevator.SerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 39 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml"
                           Write(elevator.ElevatorModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 40 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml"
                           Write(elevator.ElevatorType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 41 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml"
                           Write(elevator.ElevatorStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 42 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml"
                           Write(elevator.DateOfCommissioning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 43 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml"
                           Write(elevator.DateOfLastInspection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 44 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml"
                           Write(elevator.CertificateOfInspection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 45 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml"
                           Write(elevator.Information);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 46 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml"
                           Write(elevator.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 48 "C:\Users\Don\consolidation\Rocket_Elevators_Customer_Portal\Views\Home\ElevatorsList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
