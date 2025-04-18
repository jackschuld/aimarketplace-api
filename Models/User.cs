// Models/User.cs
using System.ComponentModel.DataAnnotations;

namespace AiMarketplaceApi.Models;

public class User
{
    public int Id { get; set; }
    
    [Required]
    public string Username { get; set; } = string.Empty;
    
    [Required]
    public string Email { get; set; } = string.Empty;
    
    [Required]
    public string PasswordHash { get; set; } = string.Empty;
    
    public List<UserLevel> UserLevels { get; set; } = new();
    
    public int TotalPoints { get; set; }
}