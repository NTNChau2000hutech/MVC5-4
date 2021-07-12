using bigschool_lap543.DTOs;
using bigschool_lap543.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AuthorizeAttribute = System.Web.Http.AuthorizeAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace bigschool_lap543.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
       public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();

        }

        public string UserId { get; private set; }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {

            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
                return BadRequest("The Attdance already exists!");
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = UserId
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return OK();
        }

        private IHttpActionResult OK()
        {
            throw new NotImplementedException();
        }
    }
}
