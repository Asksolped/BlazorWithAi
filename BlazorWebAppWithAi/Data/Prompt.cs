using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppWithAi.Data;

public class Prompt
{
    [Key]
    public int Id { get; set; }
    public string Content { get; set; } = default!;
    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    public ApplicationUser User { get; set; } = default!;
    public Chat Chat { get; set; } = default!;
}