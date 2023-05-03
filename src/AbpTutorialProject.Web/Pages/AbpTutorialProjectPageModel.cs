using AbpTutorialProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpTutorialProject.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AbpTutorialProjectPageModel : AbpPageModel
{
    protected AbpTutorialProjectPageModel()
    {
        LocalizationResourceType = typeof(AbpTutorialProjectResource);
    }
}
