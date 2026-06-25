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
    
    public void Retornar(int niveis)
    {
        Console.WriteLine("\n---- Retornando {0} níveis", niveis);

        for (int i = 0; i < niveis; i++)
        {
            if (_total >= _commands.Count - 1) continue;
            var command = _commands[_total++];
            command.Executar();
        }
    }

    public void Desfazer(int niveis)
    {
        Console.WriteLine("\n---- Retornando {0} níveis", niveis);
        for (int i = 0; i < niveis; i++)
        {
            if (_total < 0) continue;
            var command = _commands[--_total];
            command.Desfazer();
        }
    }
}