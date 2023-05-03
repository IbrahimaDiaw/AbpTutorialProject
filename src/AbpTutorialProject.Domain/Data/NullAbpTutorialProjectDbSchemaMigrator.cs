using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpTutorialProject.Data;

/* This is used if database provider does't define
 * IAbpTutorialProjectDbSchemaMigrator implementation.
 */
public class NullAbpTutorialProjectDbSchemaMigrator : IAbpTutorialProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
