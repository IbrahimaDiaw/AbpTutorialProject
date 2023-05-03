using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpTutorialProject.Data;
using Volo.Abp.DependencyInjection;

namespace AbpTutorialProject.EntityFrameworkCore;

public class EntityFrameworkCoreAbpTutorialProjectDbSchemaMigrator
    : IAbpTutorialProjectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpTutorialProjectDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpTutorialProjectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpTutorialProjectDbContext>()
            .Database
            .MigrateAsync();
    }
}
