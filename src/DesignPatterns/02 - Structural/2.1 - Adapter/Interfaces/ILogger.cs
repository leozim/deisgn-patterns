namespace DesignPatterns._02___Structural._2._1___Adapter.Interfaces;

public interface ILogger
{
    void Log(string message);
    void LogError(Exception exception);
}