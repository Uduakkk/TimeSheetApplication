using TimesheetApplication.DB.Entities;

namespace TimesheetApplication.Models
{
    public class GetUserEntries
    {
        public Guid UserId { get; set; }
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;

        public List<TimeEntry> timeEntries { get; set; } = new List<TimeEntry>();


    }
}
