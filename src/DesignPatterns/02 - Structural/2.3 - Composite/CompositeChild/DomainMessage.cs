using DesignPatterns._02___Structural._2._3___Composite.Interfaces;

namespace DesignPatterns._02___Structural._2._3___Composite.CompositeChild;

public class DomainMessage : IMessage
{
    public string Nome { get; set; }

    public DomainMessage(string nome)
    {
        Nome = nome;
    }
    
    public void ExibirMessages(int sub)
    {
        Console.WriteLine(new string('-', sub) + Nome);
    }
}