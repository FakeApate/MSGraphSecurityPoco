namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record UrlEvidence : AlertEvidence
{
    public string? Url { get; init; }



}
