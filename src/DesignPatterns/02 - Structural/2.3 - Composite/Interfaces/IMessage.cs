namespace DesignPatterns._02___Structural._2._3___Composite.Interfaces;

public interface IMessage
{ 
    string Nome { get; set; }
    void ExibirMessages(int sub);
}