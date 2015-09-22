// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DocAsCode
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class MetadataJsonConfig : List<MetadataJsonItemConfig>
    {
        public string BaseDirectory { get; set; }
        
        public MetadataJsonConfig(IEnumerable<MetadataJsonItemConfig> configs) : base(configs) { }

        public MetadataJsonConfig(params MetadataJsonItemConfig[] configs) : base(configs)
        {
        }
    }

    internal class MetadataJsonItemConfig
    {
        [JsonProperty("src")]
        public FileMapping Source { get; set; }

        [JsonProperty("dest")]
        public string Destination { get; set; }

        [JsonProperty("force")]
        public bool Force { get; set; }

        [JsonProperty("raw")]
        public bool Raw { get; set; }
    }

}
