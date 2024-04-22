public class RedisConnectionConfiguration {
    public string Uri {get;set;} = "localhost:6379";
    public string? Username { get; set; } = string.Empty;
    public string? Password { get; set; } = string.Empty;
    public string? KeyPrefix { get; set; } = string.Empty;
    public bool? Ssl { get; set; } = false;
    public int? TimeoutMs { get; set; } = 3000;
}