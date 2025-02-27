// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkUsage
    {
        internal static NetworkUsage DeserializeNetworkUsage(JsonElement element)
        {
            Optional<ResourceIdentifier> id = default;
            UsageUnit unit = default;
            long currentValue = default;
            long limit = default;
            UsageName name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = new UsageUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currentValue"))
                {
                    currentValue = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = UsageName.DeserializeUsageName(property.Value);
                    continue;
                }
            }
            return new NetworkUsage(id.Value, unit, currentValue, limit, name);
        }
    }
}
