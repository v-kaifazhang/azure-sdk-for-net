// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class CalculatePriceResponse
    {
        internal static CalculatePriceResponse DeserializeCalculatePriceResponse(JsonElement element)
        {
            Optional<CalculatePriceResponseProperties> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = CalculatePriceResponseProperties.DeserializeCalculatePriceResponseProperties(property.Value);
                    continue;
                }
            }
            return new CalculatePriceResponse(properties.Value);
        }
    }
}
