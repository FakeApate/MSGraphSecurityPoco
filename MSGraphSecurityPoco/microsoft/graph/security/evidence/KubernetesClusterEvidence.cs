namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record KubernetesClusterEvidence : AlertEvidence
{
    public AlertEvidence? CloudResource { get; init; }

    public string? Distribution { get; init; }

    public string? Name { get; init; }

    public KubernetesPlatform? Platform { get; init; }

    public string? Version { get; init; }



}
