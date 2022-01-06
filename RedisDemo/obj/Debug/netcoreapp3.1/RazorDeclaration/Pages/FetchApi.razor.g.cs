#pragma checksum "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\Pages\FetchApi.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e576a62dd4c99562f5b13053d23cbbd0073692f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RedisDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\_Imports.razor"
using RedisDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\_Imports.razor"
using RedisDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\_Imports.razor"
using Microsoft.Extensions.Caching.Distributed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\Pages\FetchApi.razor"
using RedisDemo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\Pages\FetchApi.razor"
using RedisDemo.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchapi")]
    public partial class FetchApi : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "A:\user\Ingenieurs\ENIT_Info_2021_2022_3eme\BIG DATA\Redis-BigData\RedisDemo\Pages\FetchApi.razor"
       
    MarketModel cryptocurrencies;
    string errorString;
    private string loadLocation = "";
    private string isCacheData = "";

    protected async Task Load()
    {
        cryptocurrencies = null;
        loadLocation = null;

        string recordKey = "ExchangeRates_" + DateTime.Now.ToString("yyyyMMdd");
        cryptocurrencies = await cache.GetRecordAsync<MarketModel>(recordKey);
        if (cryptocurrencies is null)
        {
            var client = _clientFactory.CreateClient();

            try
            {
                cryptocurrencies = await client.GetFromJsonAsync<MarketModel>("https://www.cryptingup.com/api/markets");
                errorString = null;
            }
            catch (Exception ex)
            {
                errorString = $"There was an error getting our data: { ex.Message }";
            }
            loadLocation = $"Loaded from API at { DateTime.Now }";
            isCacheData = "";

            await cache.SetRecordAsync(recordKey, cryptocurrencies);
        }
        else
        {
            loadLocation = $"Loaded from the cache at { DateTime.Now }";
            isCacheData = "text-danger";
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDistributedCache cache { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591