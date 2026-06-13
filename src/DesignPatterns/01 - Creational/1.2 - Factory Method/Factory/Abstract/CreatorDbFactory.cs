using DesignPatterns._01___Creational._1._2___Factory_Method.AbstractProduct;
using DesignPatterns._01___Creational._1._2___Factory_Method.Enum;
using DesignPatterns._01___Creational._1._2___Factory_Method.Factory.Concrete;

namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory.Abstract;

// abstract creator
public abstract class CreatorDbFactory
{
    // Factory method
    public abstract DbConnector CreateConnector(string connectionString);

    public static CreatorDbFactory Database(DataBase database)
    {
        switch (database)
        {
            case DataBase.SqlServer:
                return new SqlFactory();
            case DataBase.Oracle:
                return new OracleFactory();
            default:
                throw new ApplicationException("Banco de dados não reconhecido");
        }
    }
}