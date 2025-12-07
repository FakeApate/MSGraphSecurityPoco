namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record ContainerEvidence : AlertEvidence
{
    public ContainerEvidence() { }

    public ContainerEvidence(bool isPrivileged) => this.IsPrivileged = isPrivileged;

    public List<string>? Args { get; init; }

    public List<string>? Command { get; init; }

    public string? ContainerId { get; init; }

    public ContainerImageEvidence? Image { get; init; }

    public bool IsPrivileged { get; init; }

    public string? Name { get; init; }

    public KubernetesPodEvidence? Pod { get; init; }



}
