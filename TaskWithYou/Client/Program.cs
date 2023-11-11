using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Fast.Components.FluentUI;
using TaskWithYou.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("TaskWithYou.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("TaskWithYou.ServerAPI"));

// FluentUI‚Ì“±“ü
builder.Services.AddFluentUIComponents(options =>
{
    options.HostingModel = BlazorHostingModel.WebAssembly;
});

// ViewModelFactory‚Ì“o˜^
builder.Services.AddSingleton<TaskWithYou.Client.ViewModelFactories.Cards.IViewModelFactory,
    TaskWithYou.Client.ViewModelFactories.Cards.ViewModelFacotry>();

builder.Services.AddApiAuthorization();


await builder.Build().RunAsync();
