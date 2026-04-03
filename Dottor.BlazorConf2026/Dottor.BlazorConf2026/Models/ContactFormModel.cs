using System.ComponentModel.DataAnnotations;

namespace Dottor.BlazorConf2026.Models;

public class ContactFormModel
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Category is required.")]
    public string Category { get; set; } = string.Empty;

    [Required(ErrorMessage = "Message is required.")]
    [StringLength(500, MinimumLength = 10, ErrorMessage = "Message must be between 10 and 500 characters.")]
    public string Message { get; set; } = string.Empty;
}
