#pragma checksum "C:\Users\Baku\Desktop\ASP.NETCoreTask\FinalProject\FinalProject\Views\Clothing\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6703780c62a5427b73b190c982efcc592c349dfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clothing_Shop), @"mvc.1.0.view", @"/Views/Clothing/Shop.cshtml")]
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
#line 1 "C:\Users\Baku\Desktop\ASP.NETCoreTask\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Baku\Desktop\ASP.NETCoreTask\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.HomeVMs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6703780c62a5427b73b190c982efcc592c349dfa", @"/Views/Clothing/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"717a3f4845268dcfbcc2a98a0e78f08a69c2d051", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Clothing_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Clothing>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h6 text-decoration-none text-truncate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "clothing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Baku\Desktop\ASP.NETCoreTask\FinalProject\FinalProject\Views\Clothing\Shop.cshtml"
  
    ViewData["Title"] = "Shop";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Shop Start -->
<div class=""container-fluid"">
    <div class=""row px-xl-5"">
        <!-- Shop Sidebar Start -->
        <div class=""col-lg-3 col-md-4"">
            <!-- Price Start -->
            <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Filter by price</span></h5>
            <div class=""bg-light p-4 mb-30"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6703780c62a5427b73b190c982efcc592c349dfa5900", async() => {
                WriteLiteral(@"
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" checked id=""price-all"">
                        <label class=""custom-control-label"" for=""price-all"">All Price</label>
                        <span class=""badge border font-weight-normal"">1000</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""price-1"">
                        <label class=""custom-control-label"" for=""price-1"">$0 - $100</label>
                        <span class=""badge border font-weight-normal"">150</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""cust");
                WriteLiteral(@"om-control-input"" id=""price-2"">
                        <label class=""custom-control-label"" for=""price-2"">$100 - $200</label>
                        <span class=""badge border font-weight-normal"">295</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""price-3"">
                        <label class=""custom-control-label"" for=""price-3"">$200 - $300</label>
                        <span class=""badge border font-weight-normal"">246</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""price-4"">
                        <label class=""custom-control-label"" for=""price-4"">$300 - $400</label>
                        <span class=""badge border font-weight-");
                WriteLiteral(@"normal"">145</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""price-5"">
                        <label class=""custom-control-label"" for=""price-5"">$400 - $500</label>
                        <span class=""badge border font-weight-normal"">168</span>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <!-- Price End -->
            <!-- Color Start -->
            <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Filter by color</span></h5>
            <div class=""bg-light p-4 mb-30"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6703780c62a5427b73b190c982efcc592c349dfa10098", async() => {
                WriteLiteral(@"
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" checked id=""color-all"">
                        <label class=""custom-control-label"" for=""price-all"">All Color</label>
                        <span class=""badge border font-weight-normal"">1000</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""color-1"">
                        <label class=""custom-control-label"" for=""color-1"">Black</label>
                        <span class=""badge border font-weight-normal"">150</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-c");
                WriteLiteral(@"ontrol-input"" id=""color-2"">
                        <label class=""custom-control-label"" for=""color-2"">White</label>
                        <span class=""badge border font-weight-normal"">295</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""color-3"">
                        <label class=""custom-control-label"" for=""color-3"">Red</label>
                        <span class=""badge border font-weight-normal"">246</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""color-4"">
                        <label class=""custom-control-label"" for=""color-4"">Blue</label>
                        <span class=""badge border font-weight-normal"">145</span>
     ");
                WriteLiteral(@"               </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""color-5"">
                        <label class=""custom-control-label"" for=""color-5"">Green</label>
                        <span class=""badge border font-weight-normal"">168</span>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <!-- Color End -->
            <!-- Size Start -->
            <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Filter by size</span></h5>
            <div class=""bg-light p-4 mb-30"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6703780c62a5427b73b190c982efcc592c349dfa14264", async() => {
                WriteLiteral(@"
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" checked id=""size-all"">
                        <label class=""custom-control-label"" for=""size-all"">All Size</label>
                        <span class=""badge border font-weight-normal"">1000</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""size-1"">
                        <label class=""custom-control-label"" for=""size-1"">XS</label>
                        <span class=""badge border font-weight-normal"">150</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-i");
                WriteLiteral(@"nput"" id=""size-2"">
                        <label class=""custom-control-label"" for=""size-2"">S</label>
                        <span class=""badge border font-weight-normal"">295</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""size-3"">
                        <label class=""custom-control-label"" for=""size-3"">M</label>
                        <span class=""badge border font-weight-normal"">246</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""size-4"">
                        <label class=""custom-control-label"" for=""size-4"">L</label>
                        <span class=""badge border font-weight-normal"">145</span>
                    </div>
");
                WriteLiteral(@"                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""size-5"">
                        <label class=""custom-control-label"" for=""size-5"">XL</label>
                        <span class=""badge border font-weight-normal"">168</span>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <!-- Size End -->
        </div>
        <!-- Shop Sidebar End -->
        <!-- Shop Product Start -->
        <div class=""col-lg-9 col-md-8"">
            <div class=""row pb-3"">
                <div class=""col-12 pb-1"">
                    <div class=""d-flex align-items-center justify-content-between mb-4"">
                        <div>
                            <button class=""btn btn-sm btn-light""><i class=""fa fa-th-large""></i></button>
                            <button class=""btn btn-sm btn-light ml-2""><i class=""fa fa-bars""></i></button>
                        </div>
                        <div class=""ml-2"">
                            <div class=""btn-group"">
                                <button type=""button"" class=""btn btn-sm btn-light dropdown-toggle"" data-toggle=""dropdown"">Sorting</button>
                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <a class=""dropdown-item"" href=""#"">Latest</a");
            WriteLiteral(@">
                                    <a class=""dropdown-item"" href=""#"">Popularity</a>
                                    <a class=""dropdown-item"" href=""#"">Best Rating</a>
                                </div>
                            </div>
                            <div class=""btn-group ml-2"">
                                <button type=""button"" class=""btn btn-sm btn-light dropdown-toggle"" data-toggle=""dropdown"">Showing</button>
                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <a class=""dropdown-item"" href=""#"">10</a>
                                    <a class=""dropdown-item"" href=""#"">20</a>
                                    <a class=""dropdown-item"" href=""#"">30</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

");
#nullable restore
#line 153 "C:\Users\Baku\Desktop\ASP.NETCoreTask\FinalProject\FinalProject\Views\Clothing\Shop.cshtml"
                 foreach (Clothing clothing in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 col-sm-6 pb-1\">\r\n                        <div class=\"product-item bg-light mb-4\">\r\n                            <div class=\"product-img position-relative overflow-hidden\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6703780c62a5427b73b190c982efcc592c349dfa20700", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10863, "~/assets/img/", 10863, 13, true);
#nullable restore
#line 158 "C:\Users\Baku\Desktop\ASP.NETCoreTask\FinalProject\FinalProject\Views\Clothing\Shop.cshtml"
AddHtmlAttributeValue("", 10876, clothing.Images.FirstOrDefault(i=>i.IsMain==true).Name, 10876, 55, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"product-action\">\r\n                                    <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 11082, "\"", 11089, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                                    <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 11210, "\"", 11217, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                                    <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 11331, "\"", 11338, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sync-alt\"></i></a>\r\n                                    <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 11454, "\"", 11461, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"text-center py-4\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6703780c62a5427b73b190c982efcc592c349dfa23707", async() => {
#nullable restore
#line 167 "C:\Users\Baku\Desktop\ASP.NETCoreTask\FinalProject\FinalProject\Views\Clothing\Shop.cshtml"
                                                                                                                                                      Write(clothing.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 167 "C:\Users\Baku\Desktop\ASP.NETCoreTask\FinalProject\FinalProject\Views\Clothing\Shop.cshtml"
                                                                                                                                 WriteLiteral(clothing.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"d-flex align-items-center justify-content-center mt-2\">\r\n                                    <h5>");
#nullable restore
#line 169 "C:\Users\Baku\Desktop\ASP.NETCoreTask\FinalProject\FinalProject\Views\Clothing\Shop.cshtml"
                                   Write(clothing.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                                </div>
                                <div class=""d-flex align-items-center justify-content-center mb-1"">
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small>(99)</small>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 182 "C:\Users\Baku\Desktop\ASP.NETCoreTask\FinalProject\FinalProject\Views\Clothing\Shop.cshtml"
                    
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-12"">
                    <nav>
                        <ul class=""pagination justify-content-center"">
                            <li class=""page-item disabled""><a class=""page-link"" href=""#"">Previous</span></a></li>
                            <li class=""page-item active""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
        <!-- Shop Product End -->
    </div>
</div>


");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Clothing>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
