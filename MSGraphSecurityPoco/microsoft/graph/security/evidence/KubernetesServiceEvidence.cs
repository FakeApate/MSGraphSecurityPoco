namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

using Newtonsoft.Json;

public partial record KubernetesServiceEvidence : AlertEvidence
{
    public KubernetesServiceEvidence() { }

    public KubernetesServiceEvidence(KubernetesServiceType serviceType) => this.ServiceType = serviceType;

    public IpEvidence? ClusterIP { get; init; }

    public List<IpEvidence>? ExternalIPs { get; init; }

    public EvidenceDataStore? Labels { get; init; }

    public string? Name { get; init; }

    [JsonProperty("namespace")]
    public KubernetesNamespaceEvidence? Namespace { get; init; }

    public EvidenceDataStore? Selector { get; init; }

    public List<KubernetesServicePort>? ServicePorts { get; init; }

    public KubernetesServiceType ServiceType { get; init; }



}
