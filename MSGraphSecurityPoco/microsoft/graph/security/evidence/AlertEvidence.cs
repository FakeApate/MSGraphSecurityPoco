
namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record AlertEvidence
{
    public AlertEvidence() { }

    public AlertEvidence(DateTimeOffset createdDateTime, EvidenceRemediationStatus remediationStatus, EvidenceVerdict verdict)
    {
        this.CreatedDateTime = createdDateTime;
        this.RemediationStatus = remediationStatus;
        this.Verdict = verdict;
    }

    public DateTimeOffset CreatedDateTime { get; init; }

    public List<string>? DetailedRoles { get; init; }

    public EvidenceRemediationStatus RemediationStatus { get; init; }

    public string? RemediationStatusDetails { get; init; }

    public List<EvidenceRole>? Roles { get; init; }

    public List<string>? Tags { get; init; }

    public EvidenceVerdict Verdict { get; init; }



}
