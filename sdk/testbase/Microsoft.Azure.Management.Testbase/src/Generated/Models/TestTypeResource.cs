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
    /// The test type resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TestTypeResource : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the TestTypeResource class.
        /// </summary>
        public TestTypeResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestTypeResource class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource</param>
        /// <param name="actualTestTypeName">The actual name of a test type of
        /// a Test Base Account.</param>
        public TestTypeResource(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string actualTestTypeName = default(string))
            : base(id, name, type)
        {
            SystemData = systemData;
            ActualTestTypeName = actualTestTypeName;
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
        /// Gets or sets the actual name of a test type of a Test Base Account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.actualTestTypeName")]
        public string ActualTestTypeName { get; set; }

    }
}
