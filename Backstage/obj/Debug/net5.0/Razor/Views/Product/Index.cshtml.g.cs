#pragma checksum "C:\Users\tyler\Desktop\backstorage\Backstage\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa7572666b424824570ccc114e878002d4602c6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\tyler\Desktop\backstorage\Backstage\Views\_ViewImports.cshtml"
using Backstage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tyler\Desktop\backstorage\Backstage\Views\_ViewImports.cshtml"
using Backstage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tyler\Desktop\backstorage\Backstage\Views\_ViewImports.cshtml"
using Backstage.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa7572666b424824570ccc114e878002d4602c6c", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad07dbd786e43181f8694f545a580a0222c23d35", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tyler\Desktop\backstorage\Backstage\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>產品頁</h1>

<b-container fluid id=""app"">
    <!-- User Interface controls -->
    <b-row>
        <b-col lg=""6"" class=""my-1"">
            <b-form-group label=""排序""
                          label-for=""sort-by-select""
                          label-cols-sm=""3""
                          label-align-sm=""center""
                          label-size=""sm""
                          class=""mb-0 text-center""
                          v-slot=""{ ariaDescribedby }"">
                <b-input-group size=""sm"">
                    <b-form-select id=""sort-by-select""
                                   v-model=""sortBy""
                                   :options=""sortOptions""
                                   :aria-describedby=""ariaDescribedby""
                                   class=""w-75"">
                        <template #first>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa7572666b424824570ccc114e878002d4602c6c5307", async() => {
                WriteLiteral("-- 無 --");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </template>
                    </b-form-select>

                    <b-form-select v-model=""sortDesc""
                                   :disabled=""!sortBy""
                                   :aria-describedby=""ariaDescribedby""
                                   size=""sm""
                                   class=""w-25"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa7572666b424824570ccc114e878002d4602c6c6856", async() => {
                WriteLiteral("升序");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa7572666b424824570ccc114e878002d4602c6c7917", async() => {
                WriteLiteral("降序");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </b-form-select>
                </b-input-group>
            </b-form-group>
        </b-col>

        <b-col lg=""6"" class=""my-1"">
            <b-form-group label=""初始排序""
                          label-for=""initial-sort-select""
                          label-cols-sm=""3""
                          label-align-sm=""center""
                          label-size=""sm""
                          class=""mb-0"">
                <b-form-select id=""initial-sort-select""
                               v-model=""sortDirection""
                               :options=""['asc', 'desc', 'last']""
                               size=""sm""></b-form-select>
            </b-form-group>
        </b-col>

        <b-col lg=""6"" class=""my-1"">
            <b-form-group label=""篩選""
                          label-for=""filter-input""
                          label-cols-sm=""3""
                          label-align-sm=""center""
                          label-size=""sm""
                          class");
            WriteLiteral(@"=""mb-0"">
                <b-input-group size=""sm"">
                    <b-form-input id=""filter-input""
                                  v-model=""filter""
                                  type=""search""
                                  placeholder=""輸入以搜尋""></b-form-input>

                    <b-input-group-append>
                        <b-button :disabled=""!filter"" ");
            WriteLiteral(@"@click=""filter = ''"">清除</b-button>
                    </b-input-group-append>
                </b-input-group>
            </b-form-group>
        </b-col>

        <b-col lg=""6"" class=""my-1"">
            <b-form-group v-model=""sortDirection""
                          label=""過濾開啟""
                          label-cols-sm=""3""
                          label-align-sm=""center""
                          label-size=""sm""
                          class=""mb-0""
                          v-slot=""{ ariaDescribedby }"">
                <b-form-checkbox-group v-model=""filterOn""
                                       :aria-describedby=""ariaDescribedby""
                                       class=""mt-1 d-flex"">
                    <b-form-checkbox class=""mx-1"" value=""ProductName"">產品名稱</b-form-checkbox>
                    <b-form-checkbox class=""mx-1"" value=""ProductId"">產品編號</b-form-checkbox>
                    <b-form-checkbox class=""mx-1"" value=""DailyRate"">產品單價</b-form-checkbox>
                </b-fo");
            WriteLiteral(@"rm-checkbox-group>
            </b-form-group>
        </b-col>


    </b-row>

    <!-- Main table element -->
    <b-table :items=""items""
             :fields=""fields""
             :current-page=""currentPage""
             :per-page=""perPage""
             :filter=""filter""
             :filter-included-fields=""filterOn""
             :sort-by.sync=""sortBy""
             :sort-desc.sync=""sortDesc""
             :sort-direction=""sortDirection""
             :busy=""isBusy""
             stacked=""md""
             show-empty
             small
             ");
            WriteLiteral(@"@filtered=""onFiltered"">
        <template #table-busy>
            <div class=""text-center text-danger my-2"">
                <b-spinner class=""align-middle""></b-spinner>
                <strong>加載中...</strong>
            </div>
        </template>

        <template #cell(name)=""row"">
            {{ row.value.first }} {{ row.value.last }}
        </template>

        <template #cell(actions)=""row"">
            <b-button size=""sm"" ");
            WriteLiteral("@click=\"info(row.item, row.index, $event.target)\" class=\"mr-1\">\r\n                修改\r\n            </b-button>\r\n            <b-button size=\"sm\" ");
            WriteLiteral(@"@click=""row.toggleDetails"">
                {{ row.detailsShowing ? '隱藏' : '產品細節' }}
            </b-button>
        </template>

        <template #row-details=""row"">
            <b-card>
                <ul class=""d-flex flex-wrap justify-content-center"">
");
            WriteLiteral(@"                    <b-col sm=""6""><h5 class=""text-left""><strong>產品編號:</strong>&nbsp;{{ row.item.ProductId }}</h5></b-col>
                    <b-col sm=""6""><h5 class=""text-left""><strong>產品名稱:</strong>&nbsp;{{ row.item.ProductName }}</h5></b-col>
                    <b-col sm=""6""><h5 class=""text-left""><strong>產品單價:</strong>&nbsp;{{ row.item.DailyRate }}</h5></b-col>
                    <b-col sm=""6""><h5 class=""text-left""><strong>更新時間:</strong>&nbsp;{{ row.item.UpdateTime }}</h5></b-col>
                    <b-col sm=""6""><h5 class=""text-left""><strong>上架日期:</strong>&nbsp;{{ row.item.LaunchDate }}</h5></b-col>
                    <b-col sm=""6""><h5 class=""text-left""><strong>下架日期:</strong>&nbsp;{{ row.item.WithdrawalDate }}</h5></b-col>
");
            WriteLiteral(@"                    <b-col sm=""1"" v-for=""result in row.item.ProductImages""><b-img-lazy thumbnail rounded class=""mt-4"" style=""width:100px;height:100px;"" data-fancybox=""gallery"" v-bind:src=""result.SourceImages"" alt=""Center image""></b-img-lazy></b-col>
                    
                </ul>
            </b-card>
        </template>
    </b-table>
    <b-row>
        <b-col sm=""5"" md=""6"" class=""my-1"">
            <b-form-group label=""筆數""
                          label-for=""per-page-select""
                          label-cols-sm=""6""
                          label-cols-md=""4""
                          label-cols-lg=""3""
                          label-align-sm=""center""
                          label-size=""sm""
                          class=""mb-0"">
                <b-form-select id=""per-page-select""
                               v-model=""perPage""
                               :options=""pageOptions""
                               size=""sm""
                               class=""w-100""></b");
            WriteLiteral(@"-form-select>
            </b-form-group>
        </b-col>

        <b-col sm=""7"" md=""6"" class=""my-1"">
            <b-pagination v-model=""currentPage""
                          :total-rows=""totalRows""
                          :per-page=""perPage""
                          align=""fill""
                          size=""sm""
                          class=""my-0""></b-pagination>
        </b-col>
    </b-row>
    <!-- Info modal -->
    <b-modal :id=""infoModal.id"" :title=""infoModal.title"" ok-only>
        <pre>{{ infoModal.content }}</pre>
    </b-modal>
</b-container>



");
            DefineSection("topJS", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            DefineSection("topCSS", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            DefineSection("endJS", async() => {
                WriteLiteral(@"
    <script>
        Fancybox.bind(""[data-fancybox]"", {
            // Your options go here
        });
        </script>
    <script>
        var item;
        let vm;
        vm = new Vue({
            el: ""#app"",
            data: {
                isBusy: true,
                items: [],
                fields: [
                    { key: 'ProductId', label: '產品編號', class: 'text-center' },
                    { key: 'ProductName', label: '產品名子', class: 'text-center' },
                    { key: 'DailyRate', label: '單價', class: 'text-center' },
                    { key: 'UpdateTime', label: '更新時間', class: 'text-center', },
                    { key: 'LaunchDate', label: '上架日期', class: 'text-center' },
                    { key: 'WithdrawalDate', label: '下架時間', class: 'text-center', },
                    { key: 'actions', label: '動作' }
                ],
                totalRows: 1,
                currentPage: 1,
                perPage: 5,
                pageOptions: [5, 1");
                WriteLiteral(@"0, 15, { value: 1000, text: ""全部"" }],
                sortBy: '',
                sortDesc: false,
                sortDirection: 'asc',
                filter: null,
                filterOn: [],
                infoModal: {
                    id: 'info-modal',
                    title: '',
                    content: ''
                }

            },
            computed: {
                sortOptions() {
                    return this.fields
                        .map(f => {
                            return { text: f.label, value: f.key }
                        })
                }
            },
            mounted() {
                // Set the initial number of items
                this.totalRows = this.items.length
            },
            methods: {
                info(item, index, button) {
                    this.infoModal.title = `Row index: ${index}`
                    this.infoModal.content = JSON.stringify(item, null, 2)
                    this.$roo");
                WriteLiteral(@"t.$emit('bv::show::modal', this.infoModal.id, button)
                },
                resetInfoModal() {
                    this.infoModal.title = ''
                    this.infoModal.content = ''
                },
                onFiltered(filteredItems) {
                    // Trigger pagination to update the number of buttons/pages due to filtering
                    this.totalRows = filteredItems.length
                    this.currentPage = 1
                }
            },
            watch: {
                items: function () {
                    this.isBusy = false
                }
            },


        })
        function LoadData() {

            const Url = ""/api/Product""

            fetch(Url,
                {
                    method: ""Get"",
                    headers: { 'Content-Type': 'application/json' },
                })
                .then(res => res.json())
                .then(result => {
                    vm.$data.items = result;
                WriteLiteral("\n\r\n                })\r\n                .catch(ex => {\r\n                    console.log(\"資料撈失敗");
                WriteLiteral("@\");\r\n                })\r\n        };\r\n\r\n\r\n\r\n\r\n\r\n\r\n        $(document).ready(function () {\r\n            LoadData()\r\n\r\n        });\r\n\r\n\r\n    </script>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591