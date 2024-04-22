using DRedis;

public class RedLockFactory() 
{
    public static IRedLock Create(string key) 
    {
        var value = GuidGenerator.Generate();
        return new RedLock(key, value);
    }
}