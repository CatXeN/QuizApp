using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuizAppMain.Tests.Integration.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizAppMain.Tests.Integration
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup: class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // Create a new service provider.
                var serviceProvider = new ServiceCollection().AddEntityFrameworkInMemoryDatabase().BuildServiceProvider();

                // Add a database context (AppDbContext) using an in-memory database for testing.
                services.AddDbContext<DbContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryAppDb");
                    options.UseInternalServiceProvider(serviceProvider);
                });

                // Build the service provider.
                var sp = services.BuildServiceProvider();

                // Create a scope to obtain a reference to the database contexts
                using (var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var appDb = scopedServices.GetRequiredService<DbContext>();
                    // Ensure the database is created.
                    appDb.Database.EnsureCreated();

                    try
                    {
                        // Seed the database with some specific test data.
                        Utilities.InitDb(appDb);
                    }
                    catch (Exception ex)
                    {
                        //logger.LogError(ex, "An error occurred seeding the " + "database with test messages. Error: {ex.Message}");
                    }
                }
            });
        }
    }
}
