namespace DesignPatterns._03___Behavioral.CommandPattern.Receiver;

public class Calculadora
{
    private int _valorAtual;

    public void Operacao(char operador, int valor)
    {
        switch (operador)
        {
            case '+':
                _valorAtual += valor;
                break;
            case '-':
                _valorAtual -= valor;
                break;
            case '*':
                _valorAtual *= valor;
                break;
            case '/':
                _valorAtual /= valor;
                break;
            default:
                throw new ArgumentException("Operador desconhecido");
        }

        Console.WriteLine("(dado {1} {2}) - Valor atual = {0, 3}", _valorAtual, operador, valor);
    }
}