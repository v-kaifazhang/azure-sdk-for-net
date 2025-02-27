// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class GatewayApiMetadataProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title");
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Documentation))
            {
                writer.WritePropertyName("documentation");
                writer.WriteStringValue(Documentation);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(ServerUri))
            {
                writer.WritePropertyName("serverUrl");
                writer.WriteStringValue(ServerUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static GatewayApiMetadataProperties DeserializeGatewayApiMetadataProperties(JsonElement element)
        {
            Optional<string> title = default;
            Optional<string> description = default;
            Optional<string> documentation = default;
            Optional<string> version = default;
            Optional<Uri> serverUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("title"))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documentation"))
                {
                    documentation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        serverUrl = null;
                        continue;
                    }
                    serverUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new GatewayApiMetadataProperties(title.Value, description.Value, documentation.Value, version.Value, serverUrl.Value);
        }
    }
}
