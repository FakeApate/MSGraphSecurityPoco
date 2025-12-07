namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record DnsEvidence : AlertEvidence
{
    public IpEvidence? DnsServerIp { get; init; }

    public string? DomainName { get; init; }

    public IpEvidence? HostIpAddress { get; init; }

    public List<IpEvidence>? IpAddresses { get; init; }



}
