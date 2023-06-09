namespace MultiplayerARPG.MMO
{
    public interface IDatabaseLogging
    {
        void LogInformation(string tag, string msg);
        void LogWarning(string tag, string msg);
        void LogError(string tag, string msg);
        void LogException(string tag, System.Exception ex);
    }
}
