using DesignPatterns._01___Creational._1._2___Factory_Method.AbstractProduct;

namespace DesignPatterns._01___Creational._1._2___Factory_Method.Product.Concrete;

public class OracleConnector : DbConnector
{
    public OracleConnector(string connectionString) : base(connectionString)
    {
        ConnectionString = connectionString;
    }

    public override Connection Connect()
    {
        Console.WriteLine("Conectando ao banco Oracle...");
        var connection = new Connection(ConnectionString);
        connection.Open();

        return connection;
    }
}