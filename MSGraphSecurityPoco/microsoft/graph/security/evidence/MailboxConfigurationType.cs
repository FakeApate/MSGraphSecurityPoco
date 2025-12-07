namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public enum MailboxConfigurationType
{
    mailForwardingRule = 0,
    owaSettings = 1,
    ewsSettings = 2,
    mailDelegation = 3,
    userInboxRule = 4,
    unknownFutureValue = 31
}
