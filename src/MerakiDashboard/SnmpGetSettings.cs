﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

// Ignore XML documentation warnings
#pragma warning disable CS1591

namespace MerakiDashboard
{
    [DataContract]
    public class SnmpGetSettings
    {
        [DataMember(Name= "v2cEnabled")]
        public bool V2cEnabled { get; set; }

        [DataMember(Name= "v3Enabled")]
        public bool V3Enabled { get; set; }

        [DataMember(Name = "v3AuthMode")]
        public string V3AuthenticationModeRaw
        {
            get => V3AuthenticationMode != SnmpAuthenticationMode.Unknown
                ? V3AuthenticationMode.ToString().ToUpper()
                : null;
            set => V3AuthenticationMode = !string.IsNullOrWhiteSpace(value) 
                ? Enum.Parse<SnmpAuthenticationMode>(value, true) 
                : SnmpAuthenticationMode.Unknown;
        }

        [IgnoreDataMember]
        public SnmpAuthenticationMode V3AuthenticationMode { get; set; }

        [DataMember(Name = "v3PrivMode")]
        public string V3PrivacyModeRaw
        {
            get => V3PrivacyMode != SnmpPrivacyMode.Unknown 
                ? V3PrivacyMode.ToString().ToUpper()
                : null;
            set => V3PrivacyMode = !string.IsNullOrWhiteSpace(value) 
                ? Enum.Parse<SnmpPrivacyMode>(value, true)
                : SnmpPrivacyMode.Unknown;
        }

        [IgnoreDataMember]
        public SnmpPrivacyMode V3PrivacyMode { get; set; }

        [DataMember(Name = "hostname")]
        public string Hostname { get; set; }

        [DataMember(Name = "port")]
        public uint Port { get; set; }
    }
}
