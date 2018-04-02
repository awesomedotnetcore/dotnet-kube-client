using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.
    /// </summary>
    [KubeObject("LocalObjectReference", "v1")]
    public partial class LocalObjectReferenceV1
    {
        /// <summary>
        ///     Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
