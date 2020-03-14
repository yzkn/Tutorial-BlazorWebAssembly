using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;

// Blazored/LocalStorage
using Blazored.LocalStorage;
//

namespace MyApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            // Blazored/LocalStorage
            builder.Services.AddBlazoredLocalStorage();
            //

            await builder.Build().RunAsync();
        }
    }
}
