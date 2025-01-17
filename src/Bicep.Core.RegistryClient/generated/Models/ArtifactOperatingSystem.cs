// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Bicep.Core.RegistryClient.Models
{
    /// <summary> The ArtifactOperatingSystem. </summary>
    public readonly partial struct ArtifactOperatingSystem : IEquatable<ArtifactOperatingSystem>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ArtifactOperatingSystem"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArtifactOperatingSystem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AixValue = "aix";
        private const string AndroidValue = "android";
        private const string DarwinValue = "darwin";
        private const string DragonflyValue = "dragonfly";
        private const string FreeBsdValue = "freebsd";
        private const string IllumosValue = "illumos";
        private const string IOSValue = "ios";
        private const string JSValue = "js";
        private const string LinuxValue = "linux";
        private const string NetBsdValue = "netbsd";
        private const string OpenBsdValue = "openbsd";
        private const string Plan9Value = "plan9";
        private const string SolarisValue = "solaris";
        private const string WindowsValue = "windows";

        /// <summary> aix. </summary>
        public static ArtifactOperatingSystem Aix { get; } = new ArtifactOperatingSystem(AixValue);
        /// <summary> android. </summary>
        public static ArtifactOperatingSystem Android { get; } = new ArtifactOperatingSystem(AndroidValue);
        /// <summary> darwin. </summary>
        public static ArtifactOperatingSystem Darwin { get; } = new ArtifactOperatingSystem(DarwinValue);
        /// <summary> dragonfly. </summary>
        public static ArtifactOperatingSystem Dragonfly { get; } = new ArtifactOperatingSystem(DragonflyValue);
        /// <summary> freebsd. </summary>
        public static ArtifactOperatingSystem FreeBsd { get; } = new ArtifactOperatingSystem(FreeBsdValue);
        /// <summary> illumos. </summary>
        public static ArtifactOperatingSystem Illumos { get; } = new ArtifactOperatingSystem(IllumosValue);
        /// <summary> ios. </summary>
        public static ArtifactOperatingSystem IOS { get; } = new ArtifactOperatingSystem(IOSValue);
        /// <summary> js. </summary>
        public static ArtifactOperatingSystem JS { get; } = new ArtifactOperatingSystem(JSValue);
        /// <summary> linux. </summary>
        public static ArtifactOperatingSystem Linux { get; } = new ArtifactOperatingSystem(LinuxValue);
        /// <summary> netbsd. </summary>
        public static ArtifactOperatingSystem NetBsd { get; } = new ArtifactOperatingSystem(NetBsdValue);
        /// <summary> openbsd. </summary>
        public static ArtifactOperatingSystem OpenBsd { get; } = new ArtifactOperatingSystem(OpenBsdValue);
        /// <summary> plan9. </summary>
        public static ArtifactOperatingSystem Plan9 { get; } = new ArtifactOperatingSystem(Plan9Value);
        /// <summary> solaris. </summary>
        public static ArtifactOperatingSystem Solaris { get; } = new ArtifactOperatingSystem(SolarisValue);
        /// <summary> windows. </summary>
        public static ArtifactOperatingSystem Windows { get; } = new ArtifactOperatingSystem(WindowsValue);
        /// <summary> Determines if two <see cref="ArtifactOperatingSystem"/> values are the same. </summary>
        public static bool operator ==(ArtifactOperatingSystem left, ArtifactOperatingSystem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArtifactOperatingSystem"/> values are not the same. </summary>
        public static bool operator !=(ArtifactOperatingSystem left, ArtifactOperatingSystem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ArtifactOperatingSystem"/>. </summary>
        public static implicit operator ArtifactOperatingSystem(string value) => new ArtifactOperatingSystem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArtifactOperatingSystem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArtifactOperatingSystem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
