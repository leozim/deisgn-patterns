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

    public Pagamento RealizarPagamento(Pedido Pedido, Pagamento pagamento)
    {
        pagamento.Valor = Pedido.Produtos.Sum(p => p.Valor);
        Console.WriteLine("Iniciando Pagamento via Cartão de Crédito - Valor R$ " + pagamento.Valor);

        if (_pagamentoCartaoCreditoFacade.RealizarPagamento(Pedido, pagamento))
        {
            pagamento.Status = "Pago via Cartão de Crédito";
            return pagamento;
        }

        pagamento.Status = "Cartão de crédito recusado";
        return pagamento;

    }
}