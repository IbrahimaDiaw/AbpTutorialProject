using System.Threading.Tasks;

namespace AbpTutorialProject.Data;

public interface IAbpTutorialProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
