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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the Test Base Package to start a Test Run.
    /// </summary>
    public partial class PackageRunTestParameters
    {
        /// <summary>
        /// Initializes a new instance of the PackageRunTestParameters class.
        /// </summary>
        public PackageRunTestParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PackageRunTestParameters class.
        /// </summary>
        /// <param name="testType">The type of the test. Possible values
        /// include: 'OutOfBoxTest', 'FunctionalTest'</param>
        /// <param name="osName">The operating system name. e.g. Windows 10
        /// 1809.</param>
        /// <param name="osUpdateType">Specifies the OS update type to test
        /// against. Possible values include: 'SecurityUpdate',
        /// 'FeatureUpdate'</param>
        /// <param name="releaseName">The name of the tested release (OS
        /// update).</param>
        /// <param name="flightingRing">The flighting ring, only for release of
        /// feature updates.</param>
        public PackageRunTestParameters(string testType, string osName, string osUpdateType = default(string), string releaseName = default(string), string flightingRing = default(string))
        {
            TestType = testType;
            OsUpdateType = osUpdateType;
            OsName = osName;
            ReleaseName = releaseName;
            FlightingRing = flightingRing;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of the test. Possible values include:
        /// 'OutOfBoxTest', 'FunctionalTest'
        /// </summary>
        [JsonProperty(PropertyName = "testType")]
        public string TestType { get; set; }

        /// <summary>
        /// Gets or sets specifies the OS update type to test against. Possible
        /// values include: 'SecurityUpdate', 'FeatureUpdate'
        /// </summary>
        [JsonProperty(PropertyName = "osUpdateType")]
        public string OsUpdateType { get; set; }

        /// <summary>
        /// Gets or sets the operating system name. e.g. Windows 10 1809.
        /// </summary>
        [JsonProperty(PropertyName = "osName")]
        public string OsName { get; set; }

        /// <summary>
        /// Gets or sets the name of the tested release (OS update).
        /// </summary>
        [JsonProperty(PropertyName = "releaseName")]
        public string ReleaseName { get; set; }

        /// <summary>
        /// Gets or sets the flighting ring, only for release of feature
        /// updates.
        /// </summary>
        [JsonProperty(PropertyName = "flightingRing")]
        public string FlightingRing { get; set; }

    }
}
