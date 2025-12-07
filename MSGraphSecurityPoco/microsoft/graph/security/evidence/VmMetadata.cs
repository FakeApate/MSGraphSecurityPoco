namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record VmMetadata
{
    public VmMetadata() { }

    public VmMetadata(VmCloudProvider cloudProvider) => this.CloudProvider = cloudProvider;

    public VmCloudProvider CloudProvider { get; init; }

    public string? ResourceId { get; init; }

    public string? SubscriptionId { get; init; }

    public string? VmId { get; init; }



}
