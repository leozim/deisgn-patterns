using DesignPatterns._01___Creational._1._2___Factory_Method.Enum;
using DesignPatterns._01___Creational._1._2___Factory_Method.Factory.Abstract;

namespace DesignPatterns._01___Creational._1._2___Factory_Method;

public class ExecutarFactoryMethod
{
    public static void Executar()
    {
        var sqlCn = CreatorDbFactory
            .Database(DataBase.SqlServer)
            .CreateConnector("minhaCS")
            .Connect();
        
        sqlCn.ExecuteCommand("SELECT * FROM tabelaSql");
        sqlCn.Close();
        
        Console.WriteLine("");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("");
        
        var oracleCn = CreatorDbFactory.Database(DataBase.Oracle)
            .CreateConnector("minhaCS")
            .Connect();

        oracleCn.ExecuteCommand("select * from tabelaOracle");
        oracleCn.Close();
    }
}