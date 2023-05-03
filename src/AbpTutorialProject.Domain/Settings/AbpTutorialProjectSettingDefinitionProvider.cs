using Volo.Abp.Settings;

namespace AbpTutorialProject.Settings;

public class AbpTutorialProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpTutorialProjectSettings.MySetting1));
    }
}
