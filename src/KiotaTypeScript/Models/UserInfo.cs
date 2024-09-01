namespace KiotaTypeScript.Models;

public record UserInfo
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Username { get; set; } = string.Empty;
}