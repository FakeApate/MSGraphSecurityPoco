namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record CloudApplicationEvidence : AlertEvidence
{
    public long? AppId { get; init; }

    public string? DisplayName { get; init; }

    public long? InstanceId { get; init; }

    public string? InstanceName { get; init; }

    public long? SaasAppId { get; init; }

    public StreamName? Stream { get; init; }



}
