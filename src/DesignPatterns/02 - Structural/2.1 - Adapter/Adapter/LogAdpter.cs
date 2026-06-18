using DesignPatterns._02___Structural._2._1___Adapter.Interfaces;

namespace DesignPatterns._02___Structural._2._1___Adapter.Adapter;

public class LogAdpter : ILogger
{
    private readonly ILogNetMaster _logNetMaster;

    public LogAdpter(ILogNetMaster logNetMaster)
    {
        _logNetMaster = logNetMaster;
    }
    
    public void Log(string message)
    {
        _logNetMaster.LogInfo(message);
    }

    public void LogError(Exception exception)
    {
        _logNetMaster.LogException(exception);
    }
}