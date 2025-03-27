using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.IdNameValue;

/// <summary>
/// A minimal Record type with an Id (string), Name (string), nullable Value (string?) and maximum JSON compatibility
/// </summary>
/// <remarks>Record type, so avoid modification after initial construction.</remarks>
public record IdNameValue : IdNamePair.IdNamePair
{
    [JsonPropertyName("value")]
    [JsonProperty("value")]
    public string? Value { get; set; }
}