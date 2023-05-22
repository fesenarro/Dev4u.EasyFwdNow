using System.Threading.Tasks;

namespace Dev4u.EasyFwdNow.Data;

public interface IEasyFwdNowDbSchemaMigrator
{
    Task MigrateAsync();
}
