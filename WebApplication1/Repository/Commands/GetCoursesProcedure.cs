using ApplicationAPI.Repository.CommandService;
using ApplicationAPI.Repository.CommandService.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAPI.Repository.Commands
{
    [Procedure("getCourses")]
    public class GetCoursesProcedure : Command
    {
    }
}
