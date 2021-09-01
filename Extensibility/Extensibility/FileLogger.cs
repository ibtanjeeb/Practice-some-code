using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            log(message , "ERROR");
        }

        public void LogInfo(string message)
        {
            log(message, "Info");
        }
        private void log(string message, string messageType)
        {
            using (var streamwriter = new StreamWriter(_path, true))
                streamwriter.WriteLine(messageType+ ": " + message);
        }
    }
}
