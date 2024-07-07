namespace AttandanceAPI.Models
{
    public class UserReturnResponse
    {
        public string ShedIncharge_StaffNo { get; set; }
        public string ContactNo { get; set; }
        public string Name { get; set; }
        public string AttendanceUserId { get; set; }
        public bool AdminTag { get; set; }
        public string ZonalRLY { get; set; }
        public string Shed_Name { get; set; }
        public string Shed_Latitude { get; set; }
        public string Shed_Longitude { get; set; }
    }
}
