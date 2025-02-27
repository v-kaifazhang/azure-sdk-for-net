// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum to determine the Job Output Type. </summary>
    internal readonly partial struct JobOutputType : IEquatable<JobOutputType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JobOutputType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobOutputType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UriFileValue = "UriFile";
        private const string UriFolderValue = "UriFolder";
        private const string MLTableValue = "MLTable";
        private const string CustomModelValue = "CustomModel";
        private const string MLFlowModelValue = "MLFlowModel";
        private const string TritonModelValue = "TritonModel";

        /// <summary> UriFile. </summary>
        public static JobOutputType UriFile { get; } = new JobOutputType(UriFileValue);
        /// <summary> UriFolder. </summary>
        public static JobOutputType UriFolder { get; } = new JobOutputType(UriFolderValue);
        /// <summary> MLTable. </summary>
        public static JobOutputType MLTable { get; } = new JobOutputType(MLTableValue);
        /// <summary> CustomModel. </summary>
        public static JobOutputType CustomModel { get; } = new JobOutputType(CustomModelValue);
        /// <summary> MLFlowModel. </summary>
        public static JobOutputType MLFlowModel { get; } = new JobOutputType(MLFlowModelValue);
        /// <summary> TritonModel. </summary>
        public static JobOutputType TritonModel { get; } = new JobOutputType(TritonModelValue);
        /// <summary> Determines if two <see cref="JobOutputType"/> values are the same. </summary>
        public static bool operator ==(JobOutputType left, JobOutputType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobOutputType"/> values are not the same. </summary>
        public static bool operator !=(JobOutputType left, JobOutputType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobOutputType"/>. </summary>
        public static implicit operator JobOutputType(string value) => new JobOutputType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobOutputType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobOutputType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
