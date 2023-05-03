using AbpTutorialProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpTutorialProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpTutorialProjectController : AbpControllerBase
{
    protected AbpTutorialProjectController()
    {
        LocalizationResource = typeof(AbpTutorialProjectResource);
    }
}
