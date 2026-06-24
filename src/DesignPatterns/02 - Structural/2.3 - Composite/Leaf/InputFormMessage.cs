using DesignPatterns._02___Structural._2._3___Composite.Interfaces;

namespace DesignPatterns._02___Structural._2._3___Composite.CompositeChild;

public class InputFormMessage : IMessage
{
    public string Nome { get; set; }

    public InputFormMessage(string name)
    {
        Nome = name;
    }
    public void ExibirMessages(int sub)
    {
        Console.WriteLine(new string('-', sub) + Nome);
    }
}