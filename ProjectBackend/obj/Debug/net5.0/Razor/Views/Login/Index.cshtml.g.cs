#pragma checksum "C:\Users\Administrator\OneDrive\Desktop\BackendProject2021-master\ProjectBackend\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c81155b0adae1697ab9af4782078fd29d75128"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\OneDrive\Desktop\BackendProject2021-master\ProjectBackend\Views\_ViewImports.cshtml"
using ProjectBackend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\OneDrive\Desktop\BackendProject2021-master\ProjectBackend\Views\_ViewImports.cshtml"
using ProjectBackend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\OneDrive\Desktop\BackendProject2021-master\ProjectBackend\Views\_ViewImports.cshtml"
using ProjectBackend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c81155b0adae1697ab9af4782078fd29d75128", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81275836a00161a0475494c3501b89a2fe734d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"	<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>login</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Login start -->
<div class=""login-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-md-offset-3 text-center"">
                <div class=""login"">
                    <div class=""login-form-container"">
                        <div class=""login-text"">
                            <h2>login</h2>
                            <span>Please login using account detail bellow.</span>
                        </div>
                        <div clas");
            WriteLiteral(@"s=""login-form"">
                            <form action=""#"" method=""post"">
                                <input type=""text"" name=""user-name"" placeholder=""Username"">
                                <input type=""password"" name=""user-password"" placeholder=""Password"">
                                <div class=""button-box"">
                                    <div class=""login-toggle-btn"">
                                        <input type=""checkbox"" id=""remember"">
                                        <label for=""remember"">Remember me</label>
                                        <a href=""#"">Forgot Password?</a>
                                    </div>
                                    <button type=""submit"" class=""default-btn"">Login</button>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Login end -->
<!-- Subscribe Start -->
<div class=");
            WriteLiteral(@"""subscribe-area pt-60 pb-70"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-2"">
                <div class=""subscribe-content section-title text-center"">
                    <h2>subscribe our newsletter</h2>
                    <p>I must explain to you how all this mistaken idea </p>
                </div>
                <div class=""newsletter-form mc_embed_signup"">
                    <form action=""http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef"" method=""post"" id=""mc-embedded-subscribe-form"" name=""mc-embedded-subscribe-form"" class=""validate"" target=""_blank"" novalidate>
                        <div id=""mc_embed_signup_scroll"" class=""mc-form"">
                            <input type=""email""");
            BeginWriteAttribute("value", " value=\"", 2852, "\"", 2860, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""EMAIL"" class=""email"" id=""mce-EMAIL"" placeholder=""Enter your e-mail address"" required>
                            <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
                            <div class=""mc-news"" aria-hidden=""true""><input type=""text"" name=""b_6bbb9b6f5827bd842d9640c82_05d85f18ef"" tabindex=""-1""");
            BeginWriteAttribute("value", " value=\"", 3241, "\"", 3249, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            <button id=""mc-embedded-subscribe"" class=""default-btn"" type=""submit"" name=""subscribe""><span>subscribe</span></button>
                        </div>
                    </form>
                    <!-- mailchimp-alerts Start -->
                    <div class=""mailchimp-alerts"">
                        <div class=""mailchimp-submitting""></div><!-- mailchimp-submitting end -->
                        <div class=""mailchimp-success""></div><!-- mailchimp-success end -->
                        <div class=""mailchimp-error""></div><!-- mailchimp-error end -->
                    </div>
                    <!-- mailchimp-alerts end -->
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Subscribe End -->");
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