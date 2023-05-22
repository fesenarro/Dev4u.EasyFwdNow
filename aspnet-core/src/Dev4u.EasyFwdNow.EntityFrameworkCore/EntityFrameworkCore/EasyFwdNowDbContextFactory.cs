using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Dev4u.EasyFwdNow.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class EasyFwdNowDbContextFactory : IDesignTimeDbContextFactory<EasyFwdNowDbContext>
{
    public EasyFwdNowDbContext CreateDbContext(string[] args)
    {
        EasyFwdNowEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<EasyFwdNowDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new EasyFwdNowDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Dev4u.EasyFwdNow.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
