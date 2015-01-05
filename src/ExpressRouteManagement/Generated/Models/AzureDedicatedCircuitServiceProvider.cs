// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.ExpressRoute.Models;

namespace Microsoft.WindowsAzure.Management.ExpressRoute.Models
{
    /// <summary>
    /// Describes a Dedicated Circuit Service Provider.
    /// </summary>
    public partial class AzureDedicatedCircuitServiceProvider
    {
        private IList<DedicatedCircuitBandwidth> _dedicatedCircuitBandwidths;
        
        /// <summary>
        /// Required. Bandwidths available to create dedicated circuits.
        /// </summary>
        public IList<DedicatedCircuitBandwidth> DedicatedCircuitBandwidths
        {
            get { return this._dedicatedCircuitBandwidths; }
            set { this._dedicatedCircuitBandwidths = value; }
        }
        
        private string _dedicatedCircuitLocations;
        
        /// <summary>
        /// Required. Locations available for peering with Azure.
        /// </summary>
        public string DedicatedCircuitLocations
        {
            get { return this._dedicatedCircuitLocations; }
            set { this._dedicatedCircuitLocations = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Name of the dedicated circuit service provider.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Required. Type of the dedicated circuit service provider. Can be
        /// IXP or Telco.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// AzureDedicatedCircuitServiceProvider class.
        /// </summary>
        public AzureDedicatedCircuitServiceProvider()
        {
            this.DedicatedCircuitBandwidths = new LazyList<DedicatedCircuitBandwidth>();
        }
    }
}
