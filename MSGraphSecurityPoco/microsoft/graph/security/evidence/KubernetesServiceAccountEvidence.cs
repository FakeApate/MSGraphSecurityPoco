namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

using Newtonsoft.Json;

public partial record KubernetesServiceAccountEvidence : AlertEvidence
{
    public string? Name { get; init; }

    [JsonProperty("namespace")]
    public KubernetesNamespaceEvidence? Namespace { get; init; }



}
