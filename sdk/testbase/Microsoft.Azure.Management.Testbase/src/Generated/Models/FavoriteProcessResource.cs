// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.TestBase.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A favorite process identifier.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FavoriteProcessResource : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the FavoriteProcessResource class.
        /// </summary>
        public FavoriteProcessResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FavoriteProcessResource class.
        /// </summary>
        /// <param name="actualProcessName">The actual name of the favorite
        /// process. It will be equal to resource name except for the scenario
        /// that the process name contains characters that are not allowed in
        /// the resource name.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource</param>
        public FavoriteProcessResource(string actualProcessName, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            SystemData = systemData;
            ActualProcessName = actualProcessName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the system metadata relating to this resource
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

        /// <summary>
        /// Gets or sets the actual name of the favorite process. It will be
        /// equal to resource name except for the scenario that the process
        /// name contains characters that are not allowed in the resource name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.actualProcessName")]
        public string ActualProcessName { get; set; }

    }
}
