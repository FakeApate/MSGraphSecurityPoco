namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record SubmissionMailEvidence : AlertEvidence
{
    public string? NetworkMessageId { get; init; }

    public string? Recipient { get; init; }

    public string? ReportType { get; init; }

    public string? Sender { get; init; }

    public string? SenderIp { get; init; }

    public string? Subject { get; init; }

    public DateTimeOffset? SubmissionDateTime { get; init; }

    public string? SubmissionId { get; init; }

    public string? Submitter { get; init; }



}
