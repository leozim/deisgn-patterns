using DesignPatterns._03___Behavioral.CommandPattern.Command;
using DesignPatterns._03___Behavioral.CommandPattern.ConcreteCommand;
using DesignPatterns._03___Behavioral.CommandPattern.Receiver;

namespace DesignPatterns._03___Behavioral.CommandPattern.Model;

public class Usuario
{
    private readonly Calculadora _calculadora;
    private readonly List<Commander> _commands = new List<Commander>();
    private int _total;
    
    public void Adicionar(char operacao, int valor)
    {
        Commander command = new CalculadoraConcreteCommand(_calculadora, operacao, valor);
        command.Executar();
        
        _commands.Add(command);
        _total++;
    }

    public void Desfazer(int niveis)
    {
        throw new NotImplementedException();
    }

    public void Retornar(int niveis)
    {
        throw new NotImplementedException();
    }
}