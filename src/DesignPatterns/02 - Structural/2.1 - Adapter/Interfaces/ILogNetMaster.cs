namespace DesignPatterns._02___Structural._2._1___Adapter.Interfaces;

public interface ILogNetMaster
{
    void LogInfo(string message);
    void LogException(Exception exception);
}