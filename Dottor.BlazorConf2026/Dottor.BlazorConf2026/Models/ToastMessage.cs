namespace Dottor.BlazorConf2026.Models;

public enum ToastLevel
{
    Info,
    Success,
    Warning,
    Error
}

public record ToastMessage(string Title, string Text, ToastLevel Level)
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateTime CreatedAt { get; init; } = DateTime.Now;
}
