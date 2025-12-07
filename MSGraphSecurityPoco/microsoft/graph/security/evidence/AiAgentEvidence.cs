namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record AiAgentEvidence : AlertEvidence
{
    public string? AgentId { get; init; }

    public string? AgentName { get; init; }

    public AiAgentPlatform? HostingPlatformType { get; init; }

    public string? Instructions { get; init; }



}
