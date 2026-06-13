using DesignPatterns._01___Creational._1._2___Factory_Method.AbstractProduct;
using DesignPatterns._01___Creational._1._2___Factory_Method.Factory.Abstract;
using DesignPatterns._01___Creational._1._2___Factory_Method.Product.Concrete;

namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory.Concrete;

public class OracleFactory : CreatorDbFactory
{
    public override DbConnector CreateConnector(string connectionString)
    {
        return new OracleConnector(connectionString);
    }
}