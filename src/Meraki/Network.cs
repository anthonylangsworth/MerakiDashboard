﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki
{
    /// <summary>
    /// A Meraki Network.
    /// </summary>
    public class Network
    {
        [DataMember(Name="id")]
        public string Id { get; set; }

        [DataMember(Name= "organizationId")]
        public int OrganizationId { get; set; }

        [DataMember(Name = "type")]
        public string NetworkType { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "timeZone")]
        public string TimeZone { get; set; }

        [DataMember(Name = "tags")]
        public string Tags { get; set; }
    }
}