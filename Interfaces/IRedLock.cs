public interface IRedLock 
{
    bool IsAcquired {get;set;}
    void Release();
    Task ReleaseAsync();
}