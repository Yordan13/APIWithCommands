using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ApplicationAPI.Controllers;
using ApplicationAPI.Repository.Commands;
using ApplicationAPI.Repository.CommandService;
using ApplicationAPI.Repository.CommandService.MySQL;
using ApplicationAPI.Repository.Connection;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : MyController
    {
        [HttpGet]
        public DataTable GetStudents(){
            var command = this.service.GetRemoteCommand<ProcedureGetStudents>();
            return command.Execute;
        }

        [Route("update={id},{lastname},{Name},{date}")]
        [HttpGet]
        public DataTable UpdateStudent(string id, string lastName, string Name, string date) {
            var command = this.service.GetRemoteCommand<UpdateStudentProcedure>();
            command.EnrollmentDate = date;
            command.FirstMidName = Name;
            command.ID = id;
            command.LastName = lastName;
            return command.Execute;
        }

        [Route("add={lastname},{Name},{date}")]
        [HttpGet]
        public DataTable AddStudent(string lastName, string Name, string date)
        {
            var command = this.service.GetRemoteCommand<AddStudentProcedure>();
            command.EnrollmentDate = date;
            command.FirstMidName = Name;
            command.LastName = lastName;
            return command.Execute;
        }

        [Route("courses={id}")]
        [HttpGet]
        public DataTable GetCourses(string id)
        {
            var command = this.service.GetRemoteCommand<GetCourseByStudent>();
            command.ID = id;
            return command.Execute;
        }
    }
}
