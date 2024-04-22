using System.Text;

internal class KeyBuilder 
{
    private readonly string _keyPrefix;
    private static readonly StringBuilder _stringBuilder = new();

    private static readonly string Seperator = ":";

    internal KeyBuilder(RedisConnectionConfiguration configuration)
    {
        _keyPrefix = configuration.KeyPrefix ?? string.Empty;
    }

    internal string Build(string key) 
    {
        if (string.IsNullOrEmpty(_keyPrefix) || string.IsNullOrWhiteSpace(_keyPrefix)) 
        {
            return key;
        }

        if (_stringBuilder.Length > 0) {
            _stringBuilder.Clear();
        }
        
        _stringBuilder.Append(_keyPrefix);
        _stringBuilder.Append(Seperator);
        _stringBuilder.Append(key);
        return _stringBuilder.ToString();
    }
}