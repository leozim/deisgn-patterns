using DesignPatterns._02___Structural._2._1___Adapter.Interfaces;

namespace DesignPatterns._02___Structural._2._1___Adapter.Client;

public class ClientTransacaoService
{
    private readonly ILogger _logger;

    public ClientTransacaoService(ILogger ffer)
    {
        _logger = _logger;
    }
    
    public void RealizarTransacao()
    {
        // Transação
        _logger.Log("Transação realizada");
    }
}