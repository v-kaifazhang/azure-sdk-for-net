// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AssignedUser : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("objectId");
            writer.WriteStringValue(ObjectId);
            writer.WritePropertyName("tenantId");
            writer.WriteStringValue(TenantId);
            writer.WriteEndObject();
        }

        internal static AssignedUser DeserializeAssignedUser(JsonElement element)
        {
            string objectId = default;
            string tenantId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectId"))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
            }
            return new AssignedUser(objectId, tenantId);
        }
    }
}
