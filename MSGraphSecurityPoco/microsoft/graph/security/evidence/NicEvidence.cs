namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record NicEvidence : AlertEvidence
{
    public IpEvidence? IpAddress { get; init; }

    public string? MacAddress { get; init; }

    public List<string>? Vlans { get; init; }



}
