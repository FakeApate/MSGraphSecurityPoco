namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Alert;

public partial record AlertComment
{
    public AlertComment() { }

    public AlertComment(DateTimeOffset createdDateTime) => this.CreatedDateTime = createdDateTime;

    public string? Comment { get; init; }

    public string? CreatedByDisplayName { get; init; }

    public DateTimeOffset CreatedDateTime { get; init; }



}
