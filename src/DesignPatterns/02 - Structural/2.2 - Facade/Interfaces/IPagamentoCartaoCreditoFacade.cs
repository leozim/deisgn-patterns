using DesignPatterns._02___Structural._2._2___Facade.Domain.Models;

namespace DesignPatterns._02___Structural._2._2___Facade.Interfaces;

public interface IPagamentoCartaoCreditoFacade
{
    bool RealizarPagamento(Pedido Pedido, Pagamento pagamento);
}