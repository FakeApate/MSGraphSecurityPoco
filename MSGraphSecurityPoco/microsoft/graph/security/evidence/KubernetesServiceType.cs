namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public enum KubernetesServiceType
{
    unknown = 0,
    clusterIP = 1,
    externalName = 2,
    nodePort = 3,
    loadBalancer = 4,
    unknownFutureValue = 31
}
