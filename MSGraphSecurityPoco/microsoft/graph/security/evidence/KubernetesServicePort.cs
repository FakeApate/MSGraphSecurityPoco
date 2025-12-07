namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record KubernetesServicePort
{
    public KubernetesServicePort() { }

    public KubernetesServicePort(int nodePort, int port)
    {
        this.NodePort = nodePort;
        this.Port = port;
    }

    public string? AppProtocol { get; init; }

    public string? Name { get; init; }

    public int NodePort { get; init; }

    public int Port { get; init; }

    public ContainerPortProtocol? Protocol { get; init; }

    public string? TargetPort { get; init; }



}
