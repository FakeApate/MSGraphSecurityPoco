namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record ContainerImageEvidence : AlertEvidence
{
    public ContainerImageEvidence? DigestImage { get; init; }

    public string? ImageId { get; init; }

    public ContainerRegistryEvidence? Registry { get; init; }



}
