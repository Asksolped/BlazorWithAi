using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppWithAi.Data;

public class Chat
{
    [Key]
    public int Id { get; set; }
    public string ChatId { get; set; }
    [ForeignKey(nameof(Prompt))]
    public int PromptId { get; set; }
    [ForeignKey(nameof(Response))]
    public int ResponseId { get; set; }
    public Prompt Prompt { get; set; }
    public Response Response { get; set; }
}