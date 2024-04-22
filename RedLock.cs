
namespace DRedis;

public class RedLock: IRedLock, IDisposable, IAsyncDisposable
{
    private readonly string _key;
    private readonly string _value;

    public bool IsAcquired {get;set;}

    public RedLock(string key, string value)
    {
        _key = key;
        _value = value;
    }

    public void Release() 
    {
        if (!IsAcquired) return;
        throw new NotImplementedException();    
    }

    public Task ReleaseAsync()
    {
        throw new NotImplementedException();
    }

    public void Dispose() 
    {
        Release();        
    }

    public async ValueTask DisposeAsync() 
    {
        await ReleaseAsync();
    }
}
