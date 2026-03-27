namespace StudentPortal.Models
{
    public interface IRequestLogService
    {
        void AddLog(string log);
        List<string> GetLogs();
    }
}