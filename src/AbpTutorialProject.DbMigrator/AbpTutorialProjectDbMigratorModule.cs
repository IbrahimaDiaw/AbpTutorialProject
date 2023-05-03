using AbpTutorialProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpTutorialProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpTutorialProjectEntityFrameworkCoreModule),
    typeof(AbpTutorialProjectApplicationContractsModule)
    )]
public class AbpTutorialProjectDbMigratorModule : AbpModule
{

}
