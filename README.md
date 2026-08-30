[![](https://img.shields.io/nuget/v/soenneker.dtos.idnamevalue.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.idnamevalue/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idnamevalue/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idnamevalue/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.idnamevalue.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.idnamevalue/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idnamevalue/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idnamevalue/actions/workflows/codeql.yml)

# Soenneker.Dtos.IdNameValue

Extends an ID/name resource reference with an optional string value.

## Installation

```bash
dotnet add package Soenneker.Dtos.IdNameValue
```

## Usage

```csharp
using Soenneker.Dtos.IdNameValue;

var option = new IdNameValue
{
    Id = "priority-high",
    Name = "High priority",
    Value = "high"
};
```

Both System.Text.Json and Newtonsoft.Json serialize the inherited `id` and `name` fields plus `value`:

```json
{
  "id": "priority-high",
  "name": "High priority",
  "value": "high"
}
```

`Id` and `Name` are required during normal C# construction; `Value` is optional. The package does not define whether `Value` is a machine key, display text, external code, or nullable sentinel—the consuming API owns that meaning and validation.

Record equality and hash codes include all three properties. They are mutable, so do not modify an instance while it is used as a dictionary key or stored in a hash set. Use a `with` expression to create changed copies when stable value semantics matter.
