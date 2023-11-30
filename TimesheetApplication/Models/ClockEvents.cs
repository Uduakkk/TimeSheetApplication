namespace TimesheetApplication.Models
{
    public class ClockEvents
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public DateTime Time { get; set; }
        public string EventType { get; set; }
    }
}
