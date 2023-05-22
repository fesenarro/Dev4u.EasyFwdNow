using System;
using System.Collections.Generic;
using System.Text;
using Dev4u.EasyFwdNow.Localization;
using Volo.Abp.Application.Services;

namespace Dev4u.EasyFwdNow;

/* Inherit your application services from this class.
 */
public abstract class EasyFwdNowAppService : ApplicationService
{
    protected EasyFwdNowAppService()
    {
        LocalizationResource = typeof(EasyFwdNowResource);
    }
}
