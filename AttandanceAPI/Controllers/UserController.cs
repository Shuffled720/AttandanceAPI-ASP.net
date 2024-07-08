using AttandanceAPI.Data;
using AttandanceAPI.Models.ApiResponse;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;
using System.Text;

namespace AttandanceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult PostUser(
                [FromBody] UserVerifyResponse model
            )
        {
            var user=_context.Shed_Incharge_Details.Where(i=>i.AttendanceUserId==model.UserId && i.AttendanceUserPassword==model.Password).ToList();

            if (user.Count() == 0) {
                return BadRequest(new { message = "User not found" });
            }
            var shedDetails=_context.Shed_Details.Where(i=>i.ShedIncharge_StaffNo==user[0].ShedIncharge_StaffNo).ToList();
            var shedLatitude=shedDetails[0].Shed_Latitude;
            var shedLongitude=shedDetails[0].Shed_Longitude;
            UserReturnResponse userReturnResponse=new UserReturnResponse();
            userReturnResponse.ShedIncharge_StaffNo=user[0].ShedIncharge_StaffNo;
            userReturnResponse.ContactNo=user[0].ContactNo;
            userReturnResponse.Name=user[0].Name;
            userReturnResponse.AttendanceUserId=user[0].AttendanceUserId;
            userReturnResponse.AdminTag=user[0].AdminTag;
            userReturnResponse.ZonalRLY=shedDetails[0].ZonalRLY;
            userReturnResponse.Shed_Name=shedDetails[0].Shed_Name;
            userReturnResponse.Shed_Latitude=shedLatitude;
            userReturnResponse.Shed_Longitude=shedLongitude;
            return Ok(userReturnResponse);
        }
    }
}
