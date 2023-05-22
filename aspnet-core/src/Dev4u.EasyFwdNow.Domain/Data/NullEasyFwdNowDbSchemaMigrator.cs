using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Dev4u.EasyFwdNow.Data;

/* This is used if database provider does't define
 * IEasyFwdNowDbSchemaMigrator implementation.
 */
public class NullEasyFwdNowDbSchemaMigrator : IEasyFwdNowDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
