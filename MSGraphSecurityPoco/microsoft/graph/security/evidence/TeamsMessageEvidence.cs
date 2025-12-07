namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record TeamsMessageEvidence : AlertEvidence
{
    public string? CampaignId { get; init; }

    public string? ChannelId { get; init; }

    public TeamsMessageDeliveryAction? DeliveryAction { get; init; }

    public TeamsDeliveryLocation? DeliveryLocation { get; init; }

    public List<FileEvidence>? Files { get; init; }

    public string? GroupId { get; init; }

    public bool? IsExternal { get; init; }

    public bool? IsOwned { get; init; }

    public DateTimeOffset? LastModifiedDateTime { get; init; }

    public AntispamTeamsDirection? MessageDirection { get; init; }

    public string? MessageId { get; init; }

    public Guid? OwningTenantId { get; init; }

    public string? ParentMessageId { get; init; }

    public DateTimeOffset? ReceivedDateTime { get; init; }

    public List<string>? Recipients { get; init; }

    public string? SenderFromAddress { get; init; }

    public string? SenderIP { get; init; }

    public string? SourceAppName { get; init; }

    public string? SourceId { get; init; }

    public string? Subject { get; init; }

    public List<string>? SuspiciousRecipients { get; init; }

    public string? ThreadId { get; init; }

    public string? ThreadType { get; init; }

    public List<UrlEvidence>? Urls { get; init; }



}
