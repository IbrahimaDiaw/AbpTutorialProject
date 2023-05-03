using AbpTutorialProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpTutorialProject;

[DependsOn(
    typeof(AbpTutorialProjectEntityFrameworkCoreTestModule)
    )]
public class AbpTutorialProjectDomainTestModule : AbpModule
{

}
