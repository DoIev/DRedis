
internal static class GuidGenerator 
{
    internal static string Generate() 
    {
        return Guid.NewGuid().ToString();
    }
}