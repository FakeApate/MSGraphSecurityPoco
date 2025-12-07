namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record ContainerRegistryEvidence : AlertEvidence
{
    public string? Registry { get; init; }



}
