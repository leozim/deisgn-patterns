using DesignPatterns._02___Structural._2._2___Facade.CrossCuting;
using DesignPatterns._02___Structural._2._2___Facade.Domain.Models;
using DesignPatterns._02___Structural._2._2___Facade.Interfaces;

namespace DesignPatterns._02___Structural._2._2___Facade.Facade;

public class PagamentoCartaoCreditoFacade : IPagamentoCartaoCreditoFacade
{
    private readonly IPayPalGateway _payPalGateway;
    private readonly IConfigurationManager _configurationManager;


    public PagamentoCartaoCreditoFacade(IPayPalGateway payPalGateway, 
                                        IConfigurationManager configurationManager)
    {
        _payPalGateway = payPalGateway;
        _configurationManager = configurationManager;
    }
    public bool RealizarPagamento(Pedido pedido, Pagamento pagamento)
    {
        var apiKey = _configurationManager.GetValue("apiKey");
        var encriptionKey = _configurationManager.GetValue("encriptionKey");

        var serviceKey = _payPalGateway.GetPayPalServiceKey(apiKey, encriptionKey);
        var cardHashKey = _payPalGateway.GetCardHashKey(serviceKey, pagamento.CartaoCredito);

        var pagamentoResult = _payPalGateway.CommitTransaction(cardHashKey, pedido.Id.ToString(), pagamento.Valor);

        return pagamentoResult;
    }
}