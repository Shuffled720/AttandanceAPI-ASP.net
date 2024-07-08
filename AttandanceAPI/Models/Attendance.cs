namespace AttandanceAPI.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public string ShedIncharge_StaffNo { get; set; }
        public string ContactNo { get; set; }
        public string Name { get; set; }
        public string AttendanceUserId { get; set; }
        public bool AdminTag { get; set; }
        public string ZonalRLY { get; set; }
        public string Shed_Name { get; set; }
        public string CheckIn { get; set; }
        public string CheckInTime { get; set; }
        public string? CheckOut { get; set; }
        public string? CheckOutTime { get; set; }

    }
}
