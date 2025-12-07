namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

using Newtonsoft.Json;

public partial record KubernetesControllerEvidence : AlertEvidence
{
    public EvidenceDataStore? Labels { get; init; }

    public string? Name { get; init; }

    [JsonProperty("namespace")]
    public KubernetesNamespaceEvidence? Namespace { get; init; }

    public string? Type { get; init; }



}
