namespace DesignPatterns._02___Structural._2._2___Facade.CrossCuting;

public interface IPayPalGateway
{
    string GetPayPalServiceKey(string apiKey, string encriptionKey);
    string GetCardHasKey(string serviceKey, string cartaoCredito);
    bool CommitTransaction(string cardHashKey, string orderId, decimal amount);
}