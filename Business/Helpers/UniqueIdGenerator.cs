namespace Business.Helpers;

internal static class UniqueIdGenerator
{
    public static string GenerateUniqueId()
    {
        return Guid.NewGuid().ToString();
    }
}
