#pragma checksum "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80843618d219999db2af354aa3885842a0f280b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(League.Pages.Players.Pages_Players_Player), @"mvc.1.0.razor-page", @"/Pages/Players/Player.cshtml")]
namespace League.Pages.Players
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
#line 1 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\_ViewImports.cshtml"
using League;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\_ViewImports.cshtml"
using League.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80843618d219999db2af354aa3885842a0f280b5", @"/Pages/Players/Player.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e3ff45e0845b767ce2e91c14cb4035fde88f59", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Players_Player : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"jumbotron p-2\">\r\n    <h1 class=\"display-4\">\r\n        <img");
            BeginWriteAttribute("src", " src=", 120, "", 142, 1);
#nullable restore
#line 8 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
WriteAttributeValue("", 125, Model.PlayerLogo, 125, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 9 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
   Write(Model.Player.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 10 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
   Write(Model.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 15 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
Write(Model.Player.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<hr />\r\n<div>\r\n    Rating: ");
#nullable restore
#line 19 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
       Write(Model.Player.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Rank: ");
#nullable restore
#line 22 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
     Write(Model.Player.Rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Depth: ");
#nullable restore
#line 25 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
      Write(Model.Player.Depth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<hr />\r\n<div>\r\n    Experience: ");
#nullable restore
#line 30 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
           Write(Model.Player.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    College: ");
#nullable restore
#line 33 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
        Write(Model.Player.College);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Draft: ");
#nullable restore
#line 36 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
      Write(Model.Player.DraftYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 36 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
                                Write(Model.Player.DraftRound);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 36 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
                                                           Write(Model.Player.DraftPick);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<hr />\r\n<div>\r\n    Height: ");
#nullable restore
#line 41 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
       Write(Model.Player.Height);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Weight: ");
#nullable restore
#line 44 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
       Write(Model.Player.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Age: ");
#nullable restore
#line 47 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
    Write(Model.Player.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Age: ");
#nullable restore
#line 50 "C:\Users\louis\OneDrive\Desktop\Code\Coding projects\Football\LeagueStarter\Pages\Players\Player.cshtml"
    Write(Model.Player.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Players.PlayerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Players.PlayerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Players.PlayerModel>)PageContext?.ViewData;
        public Players.PlayerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591