namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

using Newtonsoft.Json;

public partial record KubernetesSecretEvidence : AlertEvidence
{
    public string? Name { get; init; }

    [JsonProperty("namespace")]
    public KubernetesNamespaceEvidence? Namespace { get; init; }

    public string? SecretType { get; init; }



}
