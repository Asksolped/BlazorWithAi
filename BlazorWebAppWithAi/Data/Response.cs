using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppWithAi.Data;

public class Response
{
    [Key]
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public string ModelName { get; set; } 
    public Chat Chat { get; set; } = default!;
    public int[]? Context  { get; set; } = default!;
}