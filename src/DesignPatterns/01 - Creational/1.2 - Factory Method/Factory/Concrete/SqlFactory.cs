using DesignPatterns._01___Creational._1._2___Factory_Method.AbstractProduct;
using DesignPatterns._01___Creational._1._2___Factory_Method.Factory.Abstract;
using DesignPatterns._01___Creational._1._2___Factory_Method.Product.Concrete;

namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory.Concrete;

public class SqlFactory : CreatorDbFactory
{
    public override DbConnector CreateConnector(string connectionString)
    {
        return new SqlServerConnector(connectionString);
    }
}