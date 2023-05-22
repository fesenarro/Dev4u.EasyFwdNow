using Volo.Abp.Modularity;

namespace Dev4u.EasyFwdNow;

[DependsOn(
    typeof(EasyFwdNowApplicationModule),
    typeof(EasyFwdNowDomainTestModule)
    )]
public class EasyFwdNowApplicationTestModule : AbpModule
{

}
