namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

using Newtonsoft.Json;

public partial record KubernetesPodEvidence : AlertEvidence
{
    public List<ContainerEvidence>? Containers { get; init; }

    public KubernetesControllerEvidence? Controller { get; init; }

    public List<ContainerEvidence>? EphemeralContainers { get; init; }

    public List<ContainerEvidence>? InitContainers { get; init; }

    public EvidenceDataStore? Labels { get; init; }

    public string? Name { get; init; }

    [JsonProperty("namespace")]
    public KubernetesNamespaceEvidence? Namespace { get; init; }

    public IpEvidence? PodIp { get; init; }

    public KubernetesServiceAccountEvidence? ServiceAccount { get; init; }



}
