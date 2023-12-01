namespace TimesheetApplication.DB.Entities
{
    public class TimeEntry
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; } 
        public string UserName { get; set; }
        public DateTime Time { get; set; }
        public string EventType { get; set; }

    }
}
