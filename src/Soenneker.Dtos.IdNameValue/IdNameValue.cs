using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.IdNameValue;

/// <summary>
/// Extends an identifier-and-name resource reference with an optional string value used for display or selection metadata.
/// </summary>
[PublicOpenApiObject]
public record IdNameValue : IdNamePair.IdNamePair
{
    /// <summary>
    /// Optional machine-readable or display value associated with the referenced resource.
    /// </summary>
    [JsonPropertyName("value")]
    [JsonProperty("value")]
    public string? Value { get; set; }
}
