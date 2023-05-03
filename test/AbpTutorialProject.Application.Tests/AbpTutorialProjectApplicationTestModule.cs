using Volo.Abp.Modularity;

namespace AbpTutorialProject;

[DependsOn(
    typeof(AbpTutorialProjectApplicationModule),
    typeof(AbpTutorialProjectDomainTestModule)
    )]
public class AbpTutorialProjectApplicationTestModule : AbpModule
{

}
