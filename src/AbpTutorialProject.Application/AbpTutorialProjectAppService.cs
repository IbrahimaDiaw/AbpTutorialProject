using System;
using System.Collections.Generic;
using System.Text;
using AbpTutorialProject.Localization;
using Volo.Abp.Application.Services;

namespace AbpTutorialProject;

/* Inherit your application services from this class.
 */
public abstract class AbpTutorialProjectAppService : ApplicationService
{
    protected AbpTutorialProjectAppService()
    {
        LocalizationResource = typeof(AbpTutorialProjectResource);
    }
}
