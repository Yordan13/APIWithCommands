using ApplicationAPI.Repository.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : MyController
    {
        [Route("add={title},{credits}")]
        [HttpGet]
        public DataTable AddCourse(string title, string credits)
        {
            var command = this.service.GetRemoteCommand<AddCourseProcedure>();
            command.Title = title;
            command.Credits = credits;
            return command.Execute;
        }

        [Route("update={id},{title},{credits}")]
        [HttpGet]
        public DataTable UpdateCourse(string id, string title, string credits)
        {
            var command = this.service.GetRemoteCommand<UpdateCourseProcedure>();
            command.CourseID = id;
            command.Title = title;
            command.Credits = credits;
            return command.Execute;
        }

        [HttpGet]
        public DataTable GetCourses()
        {
            var command = this.service.GetRemoteCommand<GetCoursesProcedure>();
            return command.Execute;
        }
    }
}
