using DesignPatterns._02___Structural._2._1___Adapter.Interfaces;

namespace DesignPatterns._02___Structural._2._1___Adapter.Services;

public class AdapteeLogNetMasterService : ILogNetMaster
{
    public void LogInfo(string message)
    {
        Console.WriteLine("Log Customizado - " + message);
    }

    public void LogException(Exception exception)
    {
        Console.WriteLine("Log Customizado - " + exception.Message);
    }
}