using DesignPatterns._02___Structural._2._2___Facade.Domain.Models;
using DesignPatterns._02___Structural._2._2___Facade.Interfaces;

namespace DesignPatterns._02___Structural._2._2___Facade.Services;

public class PagamentoCartaoCreditoService : IPagamento
{
    private readonly IPagamentoCartaoCreditoFacade _pagamentoCartaoCreditoFacade;

    public PagamentoCartaoCreditoService(IPagamentoCartaoCreditoFacade pagamentoCartaoCreditoFacade)
    {
        _pagamentoCartaoCreditoFacade = pagamentoCartaoCreditoFacade;
    }

    public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
    {
        pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
        Console.WriteLine("Iniciando Pagamento via Cartão de Crédito - Valor R$ " + pagamento.Valor);

        if (_pagamentoCartaoCreditoFacade.RealizarPagamento(pedido, pagamento))
        {
            pagamento.Status = "Pago via Cartão de Crédito";
            return pagamento;
        }

        pagamento.Status = "Cartão de crédito recusado";
        return pagamento;

    }
}