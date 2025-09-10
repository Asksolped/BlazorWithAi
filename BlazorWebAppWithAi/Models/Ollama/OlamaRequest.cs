using System.Text.Json.Serialization;

namespace BlazorWebAppWithAi.Models.Ollama;

public class OllamaRequest
{
    [JsonPropertyName("model")]
    public string Model { get; set; } = "gemma3:1b";
    [JsonPropertyName("prompt")]
    public string Prompt { get; set; } = string.Empty;
    [JsonPropertyName("stream")]
    public bool Stream { get; set; } = false;
    public int[]? Context { get; set; }
}