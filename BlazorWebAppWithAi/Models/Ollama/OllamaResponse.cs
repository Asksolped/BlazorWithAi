using System.Text.Json.Serialization;

namespace BlazorWebAppWithAi.Models.Ollama;

public class OllamaResponse
{
    [JsonPropertyName("model")]
    public string Model { get; set; }
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonPropertyName("response")]
    public string Response { get; set; }
    [JsonPropertyName("done")]
    public bool Done { get; set; }
    [JsonPropertyName("context")]
    public int[]?  Context { get; set; }
}