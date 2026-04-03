using Dottor.BlazorConf2026.Models;

namespace Dottor.BlazorConf2026.Services;

public class ToastService
{
    public event Action<ToastMessage>? OnShow;

    public void Show(string title, string text, ToastLevel level = ToastLevel.Info)
    {
        var message = new ToastMessage(title, text, level);
        OnShow?.Invoke(message);
    }

    public void Info(string title, string text) => Show(title, text, ToastLevel.Info);
    public void Success(string title, string text) => Show(title, text, ToastLevel.Success);
    public void Warning(string title, string text) => Show(title, text, ToastLevel.Warning);
    public void Error(string title, string text) => Show(title, text, ToastLevel.Error);
}
