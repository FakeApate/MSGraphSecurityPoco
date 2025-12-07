namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record AnalyzedMessageEvidence : AlertEvidence
{
    public string? AntiSpamDirection { get; init; }

    public long? AttachmentsCount { get; init; }

    public string? DeliveryAction { get; init; }

    public string? DeliveryLocation { get; init; }

    public string? InternetMessageId { get; init; }

    public string? Language { get; init; }

    public string? NetworkMessageId { get; init; }

    public EmailSender? P1Sender { get; init; }

    public EmailSender? P2Sender { get; init; }

    public DateTimeOffset? ReceivedDateTime { get; init; }

    public string? RecipientEmailAddress { get; init; }

    public string? SenderIp { get; init; }

    public string? Subject { get; init; }

    public List<string>? ThreatDetectionMethods { get; init; }

    public List<string>? Threats { get; init; }

    public long? UrlCount { get; init; }

    public List<string>? Urls { get; init; }

    public string? Urn { get; init; }



}
