using DesignPatterns._03___Behavioral.CommandPattern.Command;
using DesignPatterns._03___Behavioral.CommandPattern.Receiver;

namespace DesignPatterns._03___Behavioral.CommandPattern.ConcreteCommand;

public class CalculadoraConcreteCommand : Commander
{
    private char _operador;
    private int _valor;
    private readonly Calculadora _calculadora;

    public CalculadoraConcreteCommand(Calculadora calculadora,
                                      char operador,
                                      int valor)
    {
        _calculadora = calculadora;
        _operador = operador;
        _valor = valor;
    }

    public char Operator
    {
        set => _operador = value;
    }

    public int Operando
    {
        set => _valor = value;
    }
    
    public override void Executar()
    {
        _calculadora.Operacao(_operador, _valor);
    }

    public override void Desfazer()
    {
        _calculadora.Operacao(Desfazer(_operador), _valor);
    }

    private static char Desfazer(char operador)
    {
        switch (operador)
        {
            case '+': return '-';
            case '-': return '+';
            case '*': return '/';
            case '/': return '*';
            default: throw new ArgumentException("Operador desconhecido");
        }

        return operador;
    }
}