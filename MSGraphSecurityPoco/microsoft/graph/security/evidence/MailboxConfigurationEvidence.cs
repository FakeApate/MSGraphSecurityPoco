namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record MailboxConfigurationEvidence : AlertEvidence
{
    public string? ConfigurationId { get; init; }

    public MailboxConfigurationType? ConfigurationType { get; init; }

    public string? DisplayName { get; init; }

    public Guid? ExternalDirectoryObjectId { get; init; }

    public string? MailboxPrimaryAddress { get; init; }

    public string? Upn { get; init; }



}
