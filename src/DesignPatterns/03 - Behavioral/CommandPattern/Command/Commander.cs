namespace DesignPatterns._03___Behavioral.CommandPattern.Command;

public abstract class Commander
{
    public abstract void Executar();
    public abstract void Desfazer();
}