using IdentityRolConfig.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace IdentityRolConfig.Extensions
{
    public static class MigrationManager 

    {
        public static IHost MigrateDatabase(this IHost webHost)  //Extension method: een manier om een class (of interface) uit te breiden zonder overerving te gebruiken
        {
            //voorwaarde van een extension method: MOET altijd 1) in een static class worden gedefinieerd
            //                                                 2) zelf static methode zijn 
            //                                                 3) eerste parameter van de static method moet met this keyword starten en daarna het type hebben die je wilt uitbreiden
            using (var scope = webHost.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    try
                    {
                        appContext.Database.Migrate();
                    }
                    catch (Exception ex)
                    {
                        //Log errors or do anything you think it's needed
                        throw;
                    }
                }
            }

            return webHost;
        }
    }
}
