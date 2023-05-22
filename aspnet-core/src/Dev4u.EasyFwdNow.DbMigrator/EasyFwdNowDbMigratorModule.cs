using Dev4u.EasyFwdNow.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Dev4u.EasyFwdNow.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EasyFwdNowEntityFrameworkCoreModule),
    typeof(EasyFwdNowApplicationContractsModule)
    )]
public class EasyFwdNowDbMigratorModule : AbpModule
{

}
