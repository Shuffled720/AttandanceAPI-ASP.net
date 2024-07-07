namespace AttandanceAPI.Models
{
    public class Shed_Details
    {
        public string Id { get; set; }
        public string ZonalRLY { get; set; }
        public string Shed_Name { get; set; }
        public string Shed_Latitude { get; set; }
        public string Shed_Longitude { get; set; }
        public string Correspondence_Address { get; set; }
        public string Railway_ContactNumber { get; set; }
        public string ShedIncharge_StaffNo { get; set; }
        public Shed_Incharge_Details Shed_Incharge_Details { get; set; }

    }
}
