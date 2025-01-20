using Business.Helpers;
namespace MainApp.Tests.Helpers;

public class UniqueIdGenerator_Tests
{
    [Fact]
    public void Generate_ShouldReturnGuidAsString()
    {
        
        var result = UniqueIdGenerator.GenerateUniqueId();

        
        Assert.NotNull(result);
        Assert.True(Guid.TryParse(result, out Guid _));
    }
}
