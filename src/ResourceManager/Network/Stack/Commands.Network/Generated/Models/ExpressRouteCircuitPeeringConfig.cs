// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Specfies the peering config
    /// </summary>
    public partial class ExpressRouteCircuitPeeringConfig
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitPeeringConfig
        /// class.
        /// </summary>
        public ExpressRouteCircuitPeeringConfig() { }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitPeeringConfig
        /// class.
        /// </summary>
        public ExpressRouteCircuitPeeringConfig(IList<string> advertisedPublicPrefixes = default(IList<string>), string advertisedPublicPrefixesState = default(string), int? customerASN = default(int?), string routingRegistryName = default(string))
        {
            AdvertisedPublicPrefixes = advertisedPublicPrefixes;
            AdvertisedPublicPrefixesState = advertisedPublicPrefixesState;
            CustomerASN = customerASN;
            RoutingRegistryName = routingRegistryName;
        }

        /// <summary>
        /// Gets or sets the reference of AdvertisedPublicPrefixes
        /// </summary>
        [JsonProperty(PropertyName = "advertisedPublicPrefixes")]
        public IList<string> AdvertisedPublicPrefixes { get; set; }

        /// <summary>
        /// Gets or sets AdvertisedPublicPrefixState of the Peering resource .
        /// Possible values for this property include: 'NotConfigured',
        /// 'Configuring', 'Configured', 'ValidationNeeded'.
        /// </summary>
        [JsonProperty(PropertyName = "advertisedPublicPrefixesState")]
        public string AdvertisedPublicPrefixesState { get; set; }

        /// <summary>
        /// Gets or Sets CustomerAsn of the peering.
        /// </summary>
        [JsonProperty(PropertyName = "customerASN")]
        public int? CustomerASN { get; set; }

        /// <summary>
        /// Gets or Sets RoutingRegistryName of the config.
        /// </summary>
        [JsonProperty(PropertyName = "routingRegistryName")]
        public string RoutingRegistryName { get; set; }

    }
}
