using System.Reflection.Metadata.Ecma335;

internal class InMemoryLocksRepository: IDisposable, IAsyncDisposable
{    
    private readonly static List<IRedLock> _locks = new();
    
    internal List<IRedLock> GetAll() 
    {
        return _locks;
    }

    internal void Add(IRedLock redlock) => _locks.Add(redlock);

    internal void RemoveLock(IRedLock redlock) => _locks.Remove(redlock);


    private void ReleaseAll() 
    {
        _locks.ForEach(redlock => {
            redlock.Release();
        });  

        _locks.RemoveAll(_ => true);
    }

    public async Task ReleaseAllAsync() 
    {
        var releaseTasks = _locks.Select(redlock => redlock.ReleaseAsync());
        await Task.WhenAll(releaseTasks);
    }

    public void Dispose() 
    {
        ReleaseAll();
    }
        
    public async ValueTask DisposeAsync() 
    {
        await ReleaseAllAsync();
    }

}