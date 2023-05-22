using Dev4u.EasyFwdNow.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dev4u.EasyFwdNow.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EasyFwdNowController : AbpControllerBase
{
    protected EasyFwdNowController()
    {
        LocalizationResource = typeof(EasyFwdNowResource);
    }
}
