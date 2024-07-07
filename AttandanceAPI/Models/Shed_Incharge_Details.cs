using System.ComponentModel.DataAnnotations;

namespace AttandanceAPI.Models
{
    public class Shed_Incharge_Details
    {
        [Key]
        public string ShedIncharge_StaffNo { get; set; }
        public string ContactNo { get; set; }
        public string Name { get; set; }
        public string AddressOffice {  get; set; }
        public string AddressHome { get; set; }
        public string AttendanceUserId { get; set; }
        public string AttendanceUserPassword { get; set; }
        public bool AdminTag { get; set; }
    }
}
