namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record KubernetesNamespaceEvidence : AlertEvidence
{
    public KubernetesClusterEvidence? Cluster { get; init; }

    public EvidenceDataStore? Labels { get; init; }

    public string? Name { get; init; }



}
