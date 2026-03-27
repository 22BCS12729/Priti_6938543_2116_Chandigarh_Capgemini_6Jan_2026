namespace StudentPortal.Models
{
    public class RequestLogService : IRequestLogService
    {
        private List<string> logs = new List<string>();

        public void AddLog(string log)
        {
            logs.Add(log);
        }

        public List<string> GetLogs()
        {
            return logs;
        }
    }
}