using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Dev4u.EasyFwdNow;

[Dependency(ReplaceServices = true)]
public class EasyFwdNowBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EasyFwdNow";
}
