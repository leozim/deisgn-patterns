using DesignPatterns._02___Structural._2._2___Facade.Domain.Models;

namespace DesignPatterns._02___Structural._2._2___Facade.Interfaces;

public interface IPagamento
{
    Pagamento RealizarPagamento(Pedido Pedido, Pagamento pagamento);
}