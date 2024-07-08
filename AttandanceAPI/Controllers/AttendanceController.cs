using AttandanceAPI.Data;
using AttandanceAPI.Models;
using AttandanceAPI.Models.ApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace AttandanceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AttendanceController(ApplicationDbContext context)
        {
            _context= context;
        }
        [HttpPost]
        public IActionResult PostAttendance(
                [FromBody] AttendanceRegisterResponse model
            )
        {
            var user = _context.Shed_Incharge_Details.Where(i => i.AttendanceUserId == model.UserId).FirstOrDefault();
            if (user == null) {
                return BadRequest(new { message = "User not found" });
            }
            
            var shedDetails=_context.Shed_Details.Where(i=>i.ShedIncharge_StaffNo==user.ShedIncharge_StaffNo).FirstOrDefault();
            if (shedDetails == null) {
                return BadRequest(new { message = "Shed not found" });
            }



            if (model.Status == "PunchIn")
            {
                var attendanceCheck = _context.Attendance.Where(i => i.ShedIncharge_StaffNo == user.ShedIncharge_StaffNo).OrderBy(i => i.Id).LastOrDefault();
                if(attendanceCheck != null && attendanceCheck.CheckOut == null)
                {
                    return BadRequest(new { message = "PunchOut not done" });
                }
                Attendance attendance = new Attendance();
                attendance.ShedIncharge_StaffNo = user.ShedIncharge_StaffNo;
                attendance.ContactNo = user.ContactNo;
                attendance.Name = user.Name;
                attendance.AttendanceUserId = user.AttendanceUserId;
                attendance.AdminTag = user.AdminTag;
                attendance.ZonalRLY = shedDetails.ZonalRLY;
                attendance.Shed_Name = shedDetails.Shed_Name;
                attendance.CheckIn=System.DateTime.Now.ToString("dd/MM/yyyy");
                attendance.CheckInTime=System.DateTime.Now.ToString("HH:mm:ss");
                _context.Attendance.Add(attendance);
                _context.SaveChanges();
                return Ok(attendance);
            }
            if (model.Status == "PunchOut")
            {
                var attendanceCheck = _context.Attendance.Where(i => i.ShedIncharge_StaffNo == user.ShedIncharge_StaffNo).OrderBy(i => i.Id).LastOrDefault();
                if (attendanceCheck == null)
                {
                    return BadRequest(new { message = "PunchIn not found" });
                }
                else if(attendanceCheck.CheckOut != null)
                {
                    return BadRequest(new { message = "PunchOut already done" });
                }

                attendanceCheck.CheckOut = System.DateTime.Now.ToString("dd/MM/yyyy");
                attendanceCheck.CheckOutTime = System.DateTime.Now.ToString("HH:mm:ss");
                _context.SaveChanges();
                return Ok(attendanceCheck);


            }
            return BadRequest(new { message = "Invalid Status" });
            
        }
    }
}
