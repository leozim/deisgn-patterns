namespace DesignPatterns._01___Creational._1._3___Singleton;

public class Singleton
{
    public static void Executar()
    {
        var b1 = LoadBalancer.GetInstanceLoadBalancer();
        var b2 = LoadBalancer.GetInstanceLoadBalancer();
        var b3 = LoadBalancer.GetInstanceLoadBalancer();
        var b4 = LoadBalancer.GetInstanceLoadBalancer();

        if (b1 == b2 && b2 == b3 && b3 == b4)
        {
            Console.WriteLine("Mesma instância\n");
        }

        var balancer = LoadBalancer.GetInstanceLoadBalancer();

        for (var i = 0; i < 15; i++)
        {
            var serverName = balancer.NextServer.Name;
            Console.WriteLine("Disparando request para: " + serverName);
        }
    }
}