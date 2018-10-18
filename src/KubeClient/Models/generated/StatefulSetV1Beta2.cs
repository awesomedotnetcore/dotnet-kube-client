using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     DEPRECATED - This group version of StatefulSet is deprecated by apps/v1/StatefulSet. See the release notes for more information. StatefulSet represents a set of pods with consistent identities. Identities are defined as:
    ///      - Network: A single stable DNS and hostname.
    ///      - Storage: As many VolumeClaims as requested.
    ///     The StatefulSet guarantees that a given network identity will always map to the same storage identity.
    /// </summary>
    [KubeObject("StatefulSet", "v1beta2")]
    [KubeApi(KubeAction.List, "apis/apps/v1beta2/statefulsets")]
    [KubeApi(KubeAction.WatchList, "apis/apps/v1beta2/watch/statefulsets")]
    [KubeApi(KubeAction.List, "apis/apps/v1beta2/namespaces/{namespace}/statefulsets")]
    [KubeApi(KubeAction.Create, "apis/apps/v1beta2/namespaces/{namespace}/statefulsets")]
    [KubeApi(KubeAction.Get, "apis/apps/v1beta2/namespaces/{namespace}/statefulsets/{name}")]
    [KubeApi(KubeAction.Patch, "apis/apps/v1beta2/namespaces/{namespace}/statefulsets/{name}")]
    [KubeApi(KubeAction.Delete, "apis/apps/v1beta2/namespaces/{namespace}/statefulsets/{name}")]
    [KubeApi(KubeAction.Update, "apis/apps/v1beta2/namespaces/{namespace}/statefulsets/{name}")]
    [KubeApi(KubeAction.WatchList, "apis/apps/v1beta2/watch/namespaces/{namespace}/statefulsets")]
    [KubeApi(KubeAction.DeleteCollection, "apis/apps/v1beta2/namespaces/{namespace}/statefulsets")]
    [KubeApi(KubeAction.Get, "apis/apps/v1beta2/namespaces/{namespace}/statefulsets/{name}/status")]
    [KubeApi(KubeAction.Watch, "apis/apps/v1beta2/watch/namespaces/{namespace}/statefulsets/{name}")]
    [KubeApi(KubeAction.Patch, "apis/apps/v1beta2/namespaces/{namespace}/statefulsets/{name}/status")]
    [KubeApi(KubeAction.Update, "apis/apps/v1beta2/namespaces/{namespace}/statefulsets/{name}/status")]
    public partial class StatefulSetV1Beta2 : KubeResourceV1
    {
        /// <summary>
        ///     Spec defines the desired identities of pods in this set.
        /// </summary>
        [YamlMember(Alias = "spec")]
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public StatefulSetSpecV1Beta2 Spec { get; set; }

        /// <summary>
        ///     Status is the current status of Pods in this StatefulSet. This data may be out of date by some window of time.
        /// </summary>
        [YamlMember(Alias = "status")]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatefulSetStatusV1Beta2 Status { get; set; }
    }
}
