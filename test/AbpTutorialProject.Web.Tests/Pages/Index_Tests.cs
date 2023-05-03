using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpTutorialProject.Pages;

public class Index_Tests : AbpTutorialProjectWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
