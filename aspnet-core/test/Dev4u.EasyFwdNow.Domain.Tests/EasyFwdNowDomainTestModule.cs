using Dev4u.EasyFwdNow.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dev4u.EasyFwdNow;

[DependsOn(
    typeof(EasyFwdNowEntityFrameworkCoreTestModule)
    )]
public class EasyFwdNowDomainTestModule : AbpModule
{

}
