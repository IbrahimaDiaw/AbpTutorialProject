using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpTutorialProject.Web;

[Dependency(ReplaceServices = true)]
public class AbpTutorialProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpTutorialProject";
}
