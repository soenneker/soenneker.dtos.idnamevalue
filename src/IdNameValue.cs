using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.IdNameValue;

/// <summary>
/// A minimal Record type with an Id (string), Name (string), nullable Value (string?) and maximum JSON compatibility
/// </summary>
/// <remarks>Record type, so avoid modification after initial construction.</remarks>
[DataContract]
public record IdNameValue
{
    [Required]
    [DataMember(Name = "id")]
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public string Id { get; set; } = default!;

    [Required]
    [DataMember(Name = "name")]
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; } = default!;

    [DataMember(Name = "value")]
    [JsonPropertyName("value")]
    [JsonProperty("value")]
    public string? Value { get; set; }
}