using System;
using Artisana.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Artisana.Areas.Identity.IdentityHostingStartup))]
namespace Artisana.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ArtisanaIdentityDbContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("ArtisanaIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<ArtisanaIdentityDbContext>();
            });
        }
    }
}