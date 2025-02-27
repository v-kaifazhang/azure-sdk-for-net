// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the security profile settings for the managed disk. &lt;br&gt;&lt;br&gt; NOTE: It can only be set for Confidential VMs. </summary>
    public partial class VmDiskSecurityProfile
    {
        /// <summary> Initializes a new instance of VmDiskSecurityProfile. </summary>
        public VmDiskSecurityProfile()
        {
        }

        /// <summary> Initializes a new instance of VmDiskSecurityProfile. </summary>
        /// <param name="securityEncryptionType"> Specifies the EncryptionType of the managed disk. &lt;br&gt; It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly for encryption of just the VMGuestState blob. &lt;br&gt;&lt;br&gt; NOTE: It can be set for only Confidential VMs. </param>
        /// <param name="diskEncryptionSet"> Specifies the customer managed disk encryption set resource id for the managed disk that is used for Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob. </param>
        internal VmDiskSecurityProfile(SecurityEncryptionTypes? securityEncryptionType, WritableSubResource diskEncryptionSet)
        {
            SecurityEncryptionType = securityEncryptionType;
            DiskEncryptionSet = diskEncryptionSet;
        }

        /// <summary> Specifies the EncryptionType of the managed disk. &lt;br&gt; It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly for encryption of just the VMGuestState blob. &lt;br&gt;&lt;br&gt; NOTE: It can be set for only Confidential VMs. </summary>
        public SecurityEncryptionTypes? SecurityEncryptionType { get; set; }
        /// <summary> Specifies the customer managed disk encryption set resource id for the managed disk that is used for Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob. </summary>
        internal WritableSubResource DiskEncryptionSet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DiskEncryptionSetId
        {
            get => DiskEncryptionSet is null ? default : DiskEncryptionSet.Id;
            set
            {
                if (DiskEncryptionSet is null)
                    DiskEncryptionSet = new WritableSubResource();
                DiskEncryptionSet.Id = value;
            }
        }
    }
}
