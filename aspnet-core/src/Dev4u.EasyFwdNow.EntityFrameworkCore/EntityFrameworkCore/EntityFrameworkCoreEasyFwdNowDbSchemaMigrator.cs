using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dev4u.EasyFwdNow.Data;
using Volo.Abp.DependencyInjection;

namespace Dev4u.EasyFwdNow.EntityFrameworkCore;

public class EntityFrameworkCoreEasyFwdNowDbSchemaMigrator
    : IEasyFwdNowDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEasyFwdNowDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the EasyFwdNowDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EasyFwdNowDbContext>()
            .Database
            .MigrateAsync();
    }
}
