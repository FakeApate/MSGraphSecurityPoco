namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record CloudLogonRequestEvidence : AlertEvidence
{
    public string? RequestId { get; init; }



}
