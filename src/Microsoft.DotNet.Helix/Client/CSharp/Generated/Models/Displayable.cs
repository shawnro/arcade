// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Helix.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Displayable
    {
        /// <summary>
        /// Initializes a new instance of the Displayable class.
        /// </summary>
        public Displayable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Displayable class.
        /// </summary>
        public Displayable(string name = default(string), string displayName = default(string))
        {
            Name = name;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

    }
}