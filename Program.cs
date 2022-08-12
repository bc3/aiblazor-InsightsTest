using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using aiblazor_InsightsTest;
using BlazorApplicationInsights;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazorApplicationInsights(async applicationInsights =>
{
    await applicationInsights.SetInstrumentationKey("66f04b60-46b3-493e-891e-6000f681eea8");
        
    await applicationInsights.TrackPageView();
});

await builder.Build().RunAsync();
