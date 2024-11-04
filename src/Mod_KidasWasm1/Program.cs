using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Mod_KidasWasm1.L4_Service;
using BlazorStrap;// �K�[ BlazorStrap �A��

namespace Mod_KidasWasm1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            
            builder.Services.AddBlazorStrap();// �K�[ BlazorStrap �A��
            builder.Services.AddScoped<KidasServerService>(sp =>
                new KidasServerService(
                    
                    ));

            await builder.Build().RunAsync();
        }
    }
}
