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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class BillingHubGetFreeHourBalanceResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BillingHubGetFreeHourBalanceResponse class.
        /// </summary>
        public BillingHubGetFreeHourBalanceResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BillingHubGetFreeHourBalanceResponse class.
        /// </summary>
        public BillingHubGetFreeHourBalanceResponse(double? totalRemainingFreeHours = default(double?), IList<BillingHubFreeHourIncrementEntry> incrementEntries = default(IList<BillingHubFreeHourIncrementEntry>))
        {
            TotalRemainingFreeHours = totalRemainingFreeHours;
            IncrementEntries = incrementEntries;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalRemainingFreeHours")]
        public double? TotalRemainingFreeHours { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incrementEntries")]
        public IList<BillingHubFreeHourIncrementEntry> IncrementEntries { get; set; }

    }
}
